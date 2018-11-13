using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Collections;

namespace QLKho
{
	public class clsConnectionProvider : IDisposable
	{
		#region Class Member Declarations
			private	SqlConnection		m_scoDBConnection;
			private	bool				m_bIsTransactionPending, m_bIsDisposed;
			private	SqlTransaction		m_stCurrentTransaction;
			private	ArrayList			m_alSavePoints;
		#endregion


		public clsConnectionProvider()
		{
			// Init the class
			InitClass();
		}


		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}


		protected virtual void Dispose(bool bIsDisposing)
		{
			// Check to see if Dispose has already been called.
			if(!m_bIsDisposed)
			{
				if(bIsDisposing)
				{
					// Dispose managed resources.
					if(m_stCurrentTransaction != null)
					{
						m_stCurrentTransaction.Dispose();
						m_stCurrentTransaction = null;
					}
					if(m_scoDBConnection != null)
					{
						// closing the connection will abort (rollback) any pending transactions
						m_scoDBConnection.Close();
						m_scoDBConnection.Dispose();
						m_scoDBConnection = null;
					}
				}
			}
			m_bIsDisposed = true;
		}


		private void InitClass()
		{
			// create all the objects and initialize other members.
			m_scoDBConnection = new SqlConnection();
			AppSettingsReader m_asrConfigReader = new AppSettingsReader();

			// Set connection string of the sqlconnection object
			m_scoDBConnection.ConnectionString = 
						m_asrConfigReader.GetValue("Main.ConnectionString", typeof(string)).ToString();
			m_bIsDisposed = false;
			m_stCurrentTransaction = null;
			m_bIsTransactionPending = false;
			m_alSavePoints = new ArrayList();
		}


		public bool OpenConnection()
		{
			try
			{
				if((m_scoDBConnection.State & ConnectionState.Open) > 0)
				{
					// it's already open.
					throw new Exception("OpenConnection::Connection is already open.");
				}
				m_scoDBConnection.Open();
				m_bIsTransactionPending = false;
				return true;
			}
			catch(Exception ex)
			{
				// bubble exception
				throw ex;
			}
		}


		public bool BeginTransaction(string sTransactionName)
		{
			try
			{
				if(m_bIsTransactionPending)
				{
					// no nested transactions allowed.
					throw new Exception("BeginTransaction::Already transaction pending. Nesting not allowed");
				}
				if((m_scoDBConnection.State & ConnectionState.Open) == 0)
				{
					// no open connection
					throw new Exception("BeginTransaction::Connection is not open.");
				}
				// begin the transaction and store the transaction object.
				m_stCurrentTransaction = m_scoDBConnection.BeginTransaction(IsolationLevel.ReadCommitted, sTransactionName);
				m_bIsTransactionPending = true;
				m_alSavePoints.Clear();
				return true;
			}
			catch(Exception ex)
			{
				// bubble error
				throw ex;
			}
		}


		public bool CommitTransaction()
		{
			try
			{
				if(!m_bIsTransactionPending)
				{
					// no transaction pending
					throw new Exception("CommitTransaction::No transaction pending.");
				}
				if((m_scoDBConnection.State & ConnectionState.Open) == 0)
				{
					// no open connection
					throw new Exception("CommitTransaction::Connection is not open.");
				}
				// commit the transaction
				m_stCurrentTransaction.Commit();
				m_bIsTransactionPending = false;
				m_stCurrentTransaction.Dispose();
				m_stCurrentTransaction = null;
				m_alSavePoints.Clear();
				return true;
			}
			catch(Exception ex)
			{
				// bubble error
				throw ex;
			}
		}


		public bool RollbackTransaction(string sTransactionToRollback)
		{
			try
			{
				if(!m_bIsTransactionPending)
				{
					// no transaction pending
					throw new Exception("RollbackTransaction::No transaction pending.");
				}
				if((m_scoDBConnection.State & ConnectionState.Open) == 0)
				{
					// no open connection
					throw new Exception("RollbackTransaction::Connection is not open.");
				}
				// rollback the transaction
				m_stCurrentTransaction.Rollback(sTransactionToRollback);
				// if this wasn't a savepoint, we've rolled back the complete transaction, so we
				// can clean it up.
				if(!m_alSavePoints.Contains(sTransactionToRollback))
				{
					// it's not a savepoint
					m_bIsTransactionPending = false;
					m_stCurrentTransaction.Dispose();
					m_stCurrentTransaction = null;
					m_alSavePoints.Clear();
				}
				return true;
			}
			catch(Exception ex)
			{
				// bubble error
				throw ex;
			}
		}


		public bool SaveTransaction(string sSavePointName)
		{
			try
			{
				if(!m_bIsTransactionPending)
				{
					// no transaction pending
					throw new Exception("SaveTransaction::No transaction pending.");
				}
				if((m_scoDBConnection.State & ConnectionState.Open) == 0)
				{
					// no open connection
					throw new Exception("SaveTransaction::Connection is not open.");
				}
				// save the transaction
				m_stCurrentTransaction.Save(sSavePointName);
				// Store the savepoint in the list.
				m_alSavePoints.Add(sSavePointName);
				return true;
			}
			catch(Exception ex)
			{
				// bubble error
				throw ex;
			}
		}


		public bool CloseConnection(bool bCommitPendingTransaction)
		{
			try
			{
				if((m_scoDBConnection.State & ConnectionState.Open) == 0)
				{
					// no open connection
					return false;
				}
				if(m_bIsTransactionPending)
				{
					if(bCommitPendingTransaction)
					{
						// commit the pending transaction
						m_stCurrentTransaction.Commit();
					}
					else
					{
						// rollback the pending transaction
						m_stCurrentTransaction.Rollback();
					}
					m_bIsTransactionPending = false;
					m_stCurrentTransaction.Dispose();
					m_stCurrentTransaction = null;
					m_alSavePoints.Clear();
				}
				// close the connection
				m_scoDBConnection.Close();
				return true;
			}
			catch(Exception ex)
			{
				// bubble error
				throw ex;
			}
		}


		#region Class Property Declarations
		public SqlTransaction CurrentTransaction
		{
			get
			{
				return m_stCurrentTransaction;
			}
		}


		public bool IsTransactionPending
		{
			get
			{
				return m_bIsTransactionPending;
			}
		}


		public SqlConnection DBConnection
		{
			get
			{
				return m_scoDBConnection;
			}
		}
		#endregion
	}
}
