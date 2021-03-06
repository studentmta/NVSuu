using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace QLKho
{
	public enum LLBLError
	{
		AllOk
		// Add more here (check the comma's!)
	}


	public interface ICommonDBAccess
	{
		bool		Insert();
		bool		Update();
		bool		Delete();
		DataTable	SelectOne();
		DataTable	SelectAll();
	}


	public abstract class clsDBInteractionBase : IDisposable, ICommonDBAccess
	{
		#region Class Member Declarations
			protected	SqlConnection			m_scoMainConnection;
			protected	bool					m_bMainConnectionIsCreatedLocal;
			protected	clsConnectionProvider	m_cpMainConnectionProvider;
			private		bool					m_bIsDisposed;
		#endregion


		public clsDBInteractionBase()
		{
			// Initialize the class' members.
			InitClass();
		}


		private void InitClass()
		{
			// create all the objects and initialize other members.
			m_scoMainConnection = new SqlConnection();
			m_bMainConnectionIsCreatedLocal = true;
			m_cpMainConnectionProvider = null;
			AppSettingsReader m_asrConfigReader = new AppSettingsReader();

			// Set connection string of the sqlconnection object
			m_scoMainConnection.ConnectionString = 
						m_asrConfigReader.GetValue("Main.ConnectionString", typeof(string)).ToString();
			m_bIsDisposed = false;
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
					if(m_bMainConnectionIsCreatedLocal)
					{
						// Object is created in this class, so destroy it here.
						m_scoMainConnection.Close();
						m_scoMainConnection.Dispose();
						m_bMainConnectionIsCreatedLocal = false;
					}
					m_cpMainConnectionProvider = null;
					m_scoMainConnection = null;
				}
			}
			m_bIsDisposed = true;
		}


		public virtual bool Insert()
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}


		public virtual bool Delete()
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}


		public virtual bool Update()
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}


		public virtual DataTable SelectOne()
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}


		public virtual DataTable SelectAll()
		{
			// No implementation, throw exception
			throw new NotImplementedException();
		}


		#region Class Property Declarations
		public clsConnectionProvider MainConnectionProvider
		{
			set
			{
				if(value==null)
				{
					// Invalid value
					throw new ArgumentNullException("MainConnectionProvider", "Null passed as value to this property which is not allowed.");
				}

				// A connection provider object is passed to this class.
				// Retrieve the SqlConnection object, if present and create a
				// reference to it. If there is already a MainConnection object
				// referenced by the membervar, destroy that one or simply 
				// remove the reference, based on the flag.
				if(m_scoMainConnection!=null)
				{
					// First get rid of current connection object. Caller is responsible
					if(m_bMainConnectionIsCreatedLocal)
					{
						// Is local created object, close it and dispose it.
						m_scoMainConnection.Close();
						m_scoMainConnection.Dispose();
					}
					// Remove reference.
					m_scoMainConnection = null;
				}
				m_cpMainConnectionProvider = (clsConnectionProvider)value;
				m_scoMainConnection = m_cpMainConnectionProvider.DBConnection;
				m_bMainConnectionIsCreatedLocal = false;
			}
		}
		#endregion
	}
}
