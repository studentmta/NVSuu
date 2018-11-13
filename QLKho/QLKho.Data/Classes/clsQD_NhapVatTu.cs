using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QLKho
{
	public partial class clsQD_NhapVatTu : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTonTai;
			private SqlInt32		m_iID_QuyetDinh, m_iID_NhaCungCap;
			private SqlString		m_sSo_QuyetDinh;
			private SqlDateTime		m_daNgay_QuyetDinh, m_daNgay_SuaCuoi, m_daNgayLap;
			private SqlByte			m_byTrangThai;
		#endregion


		public clsQD_NhapVatTu()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_QD_NhapVatTu_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NhaCungCap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@So_QuyetDinh", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSo_QuyetDinh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_QuyetDinh", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_QuyetDinh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@NgayLap", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgayLap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_SuaCuoi", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_SuaCuoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.TinyInt, 1, ParameterDirection.Input, false,3, 0, "", DataRowVersion.Proposed, m_byTrangThai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_QuyetDinh", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_QuyetDinh));

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
				m_iID_QuyetDinh = (SqlInt32)scmCmdToExecute.Parameters["@ID_QuyetDinh"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsQD_NhapVatTu::Insert::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_QD_NhapVatTu_Update]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_QuyetDinh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_QuyetDinh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_NhaCungCap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_NhaCungCap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@So_QuyetDinh", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSo_QuyetDinh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_QuyetDinh", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_QuyetDinh));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@NgayLap", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgayLap));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_SuaCuoi", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_SuaCuoi));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byTrangThai));
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
				throw new Exception("clsQD_NhapVatTu::Update::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_QD_NhapVatTu_Delete]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_QuyetDinh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_QuyetDinh));

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
				throw new Exception("clsQD_NhapVatTu::Delete::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_QD_NhapVatTu_SelectOne]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("QD_NhapVatTu");
			SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_QuyetDinh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_QuyetDinh));

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
					m_iID_QuyetDinh = (Int32)dtToReturn.Rows[0]["ID_QuyetDinh"];
					m_iID_NhaCungCap = (Int32)dtToReturn.Rows[0]["ID_NhaCungCap"];
					m_sSo_QuyetDinh = (string)dtToReturn.Rows[0]["So_QuyetDinh"];
					m_daNgay_QuyetDinh = (DateTime)dtToReturn.Rows[0]["Ngay_QuyetDinh"];
					m_daNgayLap = (DateTime)dtToReturn.Rows[0]["NgayLap"];
					m_daNgay_SuaCuoi = (DateTime)dtToReturn.Rows[0]["Ngay_SuaCuoi"];
					m_byTrangThai = (byte)dtToReturn.Rows[0]["TrangThai"];
					m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
				}
				return dtToReturn;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsQD_NhapVatTu::SelectOne::Error occured.", ex);
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
			scmCmdToExecute.CommandText = "dbo.[pr_QD_NhapVatTu_SelectAll]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;
			DataTable dtToReturn = new DataTable("QD_NhapVatTu");
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
				throw new Exception("clsQD_NhapVatTu::SelectAll::Error occured.", ex);
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
		public SqlInt32 ID_QuyetDinh
		{
			get
			{
				return m_iID_QuyetDinh;
			}
			set
			{
				SqlInt32 iID_QuyetDinhTmp = (SqlInt32)value;
				if(iID_QuyetDinhTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_QuyetDinh", "iD_QuyetDinh can't be NULL");
				}
				m_iID_QuyetDinh = value;
			}
		}


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


		public SqlString So_QuyetDinh
		{
			get
			{
				return m_sSo_QuyetDinh;
			}
			set
			{
				SqlString sSo_QuyetDinhTmp = (SqlString)value;
				if(sSo_QuyetDinhTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("so_QuyetDinh", "so_QuyetDinh can't be NULL");
				}
				m_sSo_QuyetDinh = value;
			}
		}


		public SqlDateTime Ngay_QuyetDinh
		{
			get
			{
				return m_daNgay_QuyetDinh;
			}
			set
			{
				SqlDateTime daNgay_QuyetDinhTmp = (SqlDateTime)value;
				if(daNgay_QuyetDinhTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ngay_QuyetDinh", "ngay_QuyetDinh can't be NULL");
				}
				m_daNgay_QuyetDinh = value;
			}
		}


		public SqlDateTime NgayLap
		{
			get
			{
				return m_daNgayLap;
			}
			set
			{
				SqlDateTime daNgayLapTmp = (SqlDateTime)value;
				if(daNgayLapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ngayLap", "ngayLap can't be NULL");
				}
				m_daNgayLap = value;
			}
		}


		public SqlDateTime Ngay_SuaCuoi
		{
			get
			{
				return m_daNgay_SuaCuoi;
			}
			set
			{
				SqlDateTime daNgay_SuaCuoiTmp = (SqlDateTime)value;
				if(daNgay_SuaCuoiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ngay_SuaCuoi", "ngay_SuaCuoi can't be NULL");
				}
				m_daNgay_SuaCuoi = value;
			}
		}


		public SqlByte TrangThai
		{
			get
			{
				return m_byTrangThai;
			}
			set
			{
				SqlByte byTrangThaiTmp = (SqlByte)value;
				if(byTrangThaiTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("trangThai", "trangThai can't be NULL");
				}
				m_byTrangThai = value;
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
