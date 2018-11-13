using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QLKho
{
	public class clsDM_NhaCungCap : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bSuDung, m_bTonTai;
			private SqlInt32		m_iID_NhaCungCap;
			private SqlString		m_sTen_NhaCungCap, m_sEmail, m_sDiaChi, m_sSoDienThoai;
		#endregion


		public clsDM_NhaCungCap()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_NhaCungCap_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ten_NhaCungCap", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen_NhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDiaChi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmail));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDienThoai", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSoDienThoai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@SuDung", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bSuDung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NhaCungCap", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhaCungCap));

				if(m_bMainConnectionIsCreatedLocal)
				{
					// Open connection.
					m_scoMainConnection.Open();
				}
				else
				{
					if(m_cpMainConnectionProvider.IsTransactionPending)
					{
						scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				m_iID_NhaCungCap = (SqlInt32)scmCmdToExecute.Parameters["@ID_NhaCungCap"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_NhaCungCap::Insert::Error occured.", ex);
			}
			finally
			{
				if(m_bMainConnectionIsCreatedLocal)
				{
					// Close connection.
					m_scoMainConnection.Close();
				}
				scmCmdToExecute.Dispose();
			}
		}


		public override bool Update()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_NhaCungCap_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NhaCungCap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ten_NhaCungCap", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sTen_NhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@DiaChi", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sDiaChi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Email", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sEmail));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@SoDienThoai", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSoDienThoai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@SuDung", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bSuDung));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));

				if(m_bMainConnectionIsCreatedLocal)
				{
					// Open connection.
					m_scoMainConnection.Open();
				}
				else
				{
					if(m_cpMainConnectionProvider.IsTransactionPending)
					{
						scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_NhaCungCap::Update::Error occured.", ex);
			}
			finally
			{
				if(m_bMainConnectionIsCreatedLocal)
				{
					// Close connection.
					m_scoMainConnection.Close();
				}
				scmCmdToExecute.Dispose();
			}
		}


		public override bool Delete()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_NhaCungCap_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NhaCungCap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhaCungCap));

				if(m_bMainConnectionIsCreatedLocal)
				{
					// Open connection.
					m_scoMainConnection.Open();
				}
				else
				{
					if(m_cpMainConnectionProvider.IsTransactionPending)
					{
						scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				scmCmdToExecute.ExecuteNonQuery();
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_NhaCungCap::Delete::Error occured.", ex);
			}
			finally
			{
				if(m_bMainConnectionIsCreatedLocal)
				{
					// Close connection.
					m_scoMainConnection.Close();
				}
				scmCmdToExecute.Dispose();
			}
		}


		public override DataTable SelectOne()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_NhaCungCap_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DM_NhaCungCap");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NhaCungCap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhaCungCap));

				if(m_bMainConnectionIsCreatedLocal)
				{
					// Open connection.
					m_scoMainConnection.Open();
				}
				else
				{
					if(m_cpMainConnectionProvider.IsTransactionPending)
					{
						scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				if(dtToReturn.Rows.Count > 0)
				{
					m_iID_NhaCungCap = (Int32)dtToReturn.Rows[0]["ID_NhaCungCap"];
					m_sTen_NhaCungCap = (string)dtToReturn.Rows[0]["Ten_NhaCungCap"];
					m_sDiaChi = (string)dtToReturn.Rows[0]["DiaChi"];
					m_sEmail = (string)dtToReturn.Rows[0]["Email"];
					m_sSoDienThoai = (string)dtToReturn.Rows[0]["SoDienThoai"];
					m_bSuDung = (bool)dtToReturn.Rows[0]["SuDung"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_NhaCungCap::SelectOne::Error occured.", ex);
			}
			finally
			{
				if(m_bMainConnectionIsCreatedLocal)
				{
					// Close connection.
					m_scoMainConnection.Close();
				}
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		public override DataTable SelectAll()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_DM_NhaCungCap_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("DM_NhaCungCap");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{

				if(m_bMainConnectionIsCreatedLocal)
				{
					// Open connection.
					m_scoMainConnection.Open();
				}
				else
				{
					if(m_cpMainConnectionProvider.IsTransactionPending)
					{
						scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
					}
				}

				// Execute query.
				sdaAdapter.Fill(dtToReturn);
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsDM_NhaCungCap::SelectAll::Error occured.", ex);
			}
			finally
			{
				if(m_bMainConnectionIsCreatedLocal)
				{
					// Close connection.
					m_scoMainConnection.Close();
				}
				scmCmdToExecute.Dispose();
				sdaAdapter.Dispose();
			}
		}


		#region Class Property Declarations
		public SqlInt32 ID_NhaCungCap
		{
			get
			{
				return m_iID_NhaCungCap;
			}
			set
			{
				SqlInt32 iID_NhaCungCapTmp = (SqlInt32)value;
				if(iID_NhaCungCapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_NhaCungCap", "iD_NhaCungCap can't be NULL");
				}
				m_iID_NhaCungCap = value;
			}
		}


		public SqlString Ten_NhaCungCap
		{
			get
			{
				return m_sTen_NhaCungCap;
			}
			set
			{
				SqlString sTen_NhaCungCapTmp = (SqlString)value;
				if(sTen_NhaCungCapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ten_NhaCungCap", "ten_NhaCungCap can't be NULL");
				}
				m_sTen_NhaCungCap = value;
			}
		}


		public SqlString DiaChi
		{
			get
			{
				return m_sDiaChi;
			}
			set
			{
				SqlString sDiaChiTmp = (SqlString)value;
				if(sDiaChiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("diaChi", "diaChi can't be NULL");
				}
				m_sDiaChi = value;
			}
		}


		public SqlString Email
		{
			get
			{
				return m_sEmail;
			}
			set
			{
				SqlString sEmailTmp = (SqlString)value;
				if(sEmailTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("email", "email can't be NULL");
				}
				m_sEmail = value;
			}
		}


		public SqlString SoDienThoai
		{
			get
			{
				return m_sSoDienThoai;
			}
			set
			{
				SqlString sSoDienThoaiTmp = (SqlString)value;
				if(sSoDienThoaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("soDienThoai", "soDienThoai can't be NULL");
				}
				m_sSoDienThoai = value;
			}
		}


		public SqlBoolean SuDung
		{
			get
			{
				return m_bSuDung;
			}
			set
			{
				SqlBoolean bSuDungTmp = (SqlBoolean)value;
				if(bSuDungTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("suDung", "suDung can't be NULL");
				}
				m_bSuDung = value;
			}
		}


		public SqlBoolean TonTai
		{
			get
			{
				return m_bTonTai;
			}
			set
			{
				SqlBoolean bTonTaiTmp = (SqlBoolean)value;
				if(bTonTaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("tonTai", "tonTai can't be NULL");
				}
				m_bTonTai = value;
			}
		}
		#endregion
	}
}
