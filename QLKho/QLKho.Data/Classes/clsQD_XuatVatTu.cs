using System;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace QLKho
{
	public partial class clsQD_XuatVatTu : clsDBInteractionBase
	{
		#region Class Member Declarations
			private SqlBoolean		m_bTonTai;
			private SqlInt32		m_iID_PhieuXuat, m_iID_Kho;
			private SqlString		m_sSo_PhieuXuat,m_sNguoiPheDuyet,m_sNguoi_Lap;
			private SqlDateTime		m_daNgay_XuatKho, m_daNgay_HachToan, m_daNgay_Lap,m_daNgayPheDuyet;
			private SqlByte			m_byTrangThai;
		#endregion


		public clsQD_XuatVatTu()
		{
			// Nothing for now.
		}


		public override bool Insert()
		{
			SqlCommand	scmCmdToExecute = new SqlCommand();
			scmCmdToExecute.CommandText = "dbo.[pr_QD_XuatVatTu_Insert]";
			scmCmdToExecute.CommandType = CommandType.StoredProcedure;

			// Use base class' connection object
			scmCmdToExecute.Connection = m_scoMainConnection;

			try
			{
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Kho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Kho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@So_PhieuXuat", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSo_PhieuXuat));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_XuatKho", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_XuatKho));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_HachToan", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_HachToan));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_Lap", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Lap));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@Nguoi_Lap", SqlDbType.NVarChar, 50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNguoi_Lap));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@Nguoi_PheDuyet", SqlDbType.NVarChar,50, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNguoiPheDuyet));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_PheDuyet", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgayPheDuyet));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.TinyInt, 1, ParameterDirection.Input, false,3, 0, "", DataRowVersion.Proposed, m_byTrangThai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@TonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));
				scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_PhieuXuat", SqlDbType.Int, 4, ParameterDirection.Output, false, 10, 0, "", DataRowVersion.Proposed, m_iID_PhieuXuat));

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
				m_iID_PhieuXuat = (SqlInt32)scmCmdToExecute.Parameters["@ID_PhieuXuat"].Value;
				return true;
			}
			catch(Exception ex)
			{
				// some error occured. Bubble it to caller and encapsulate Exception object
				throw new Exception("clsQD_XuatVatTu::Insert::Error occured.", ex);
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
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_PhieuXuat_Update]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_PhieuXuat", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_PhieuXuat));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Kho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Kho));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@So_PhieuXuat", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sSo_PhieuXuat));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_XuatKho", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_XuatKho));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_HachToan", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_HachToan));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@Nguoi_Lap", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNguoi_Lap));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_Lap", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgay_Lap));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@Nguoi_PheDuyet", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_sNguoiPheDuyet));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@Ngay_PheDuyet", SqlDbType.SmallDateTime, 4, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_daNgayPheDuyet));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byTrangThai));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@TonTai", SqlDbType.Bit, 1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));

                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    m_scoMainConnection.Open();
                }
                else
                {
                    if (m_cpMainConnectionProvider.IsTransactionPending)
                    {
                        scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
                    }
                }

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsPhieuXuat::Update::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
            }
        }

        public bool UpdateTrangThai()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_PhieuXuat_Update_TrangThai]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_PhieuXuat", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_PhieuXuat));    
                scmCmdToExecute.Parameters.Add(new SqlParameter("@TrangThai", SqlDbType.TinyInt, 1, ParameterDirection.Input, false, 3, 0, "", DataRowVersion.Proposed, m_byTrangThai));
                
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    m_scoMainConnection.Open();
                }
                else
                {
                    if (m_cpMainConnectionProvider.IsTransactionPending)
                    {
                        scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
                    }
                }

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsPhieuXuat::Update::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
            }
        }

        public bool UpdateNguoiPheDuyet()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_PhieuXuat_Update_Nguoi_PheDuyet]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_PhieuXuat", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_PhieuXuat));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@Nguoi_PheDuyet", SqlDbType.NVarChar, 255, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_sNguoiPheDuyet));

                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    m_scoMainConnection.Open();
                }
                else
                {
                    if (m_cpMainConnectionProvider.IsTransactionPending)
                    {
                        scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
                    }
                }

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsPhieuXuat::Update::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
            }
        }

        public override bool Delete()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_PhieuXuat_Delete]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_PhieuXuat", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_PhieuXuat));

                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Open connection.
                    m_scoMainConnection.Open();
                }
                else
                {
                    if (m_cpMainConnectionProvider.IsTransactionPending)
                    {
                        scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
                    }
                }

                // Execute query.
                scmCmdToExecute.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsPhieuXuat::Delete::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
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
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_QuyetDinh", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_PhieuXuat));

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
                    //m_iID_QuyetDinh = (Int32)dtToReturn.Rows[0]["ID_QuyetDinh"];
                    //m_iID_NhaCungCap = (Int32)dtToReturn.Rows[0]["ID_NhaCungCap"];
                    //m_sSo_QuyetDinh = (string)dtToReturn.Rows[0]["So_QuyetDinh"];
                    //m_daNgay_QuyetDinh = (DateTime)dtToReturn.Rows[0]["Ngay_QuyetDinh"];
                    //m_daNgayLap = (DateTime)dtToReturn.Rows[0]["NgayLap"];
                    //m_daNgay_SuaCuoi = (DateTime)dtToReturn.Rows[0]["Ngay_SuaCuoi"];
                    //m_byTrangThai = (byte)dtToReturn.Rows[0]["TrangThai"];
                    //m_bTonTai = (bool)dtToReturn.Rows[0]["TonTai"];
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
        public SqlInt32 ID_PhieuXuat
		{
			get
			{
                return m_iID_PhieuXuat;
			}
			set
			{
				SqlInt32 iID_QuyetDinhTmp = (SqlInt32)value;
				if(iID_QuyetDinhTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("iD_QuyetDinh", "iD_QuyetDinh can't be NULL");
				}
                m_iID_PhieuXuat = value;
			}
		}


        public SqlInt32 ID_Kho
        {
            get
            {
                return m_iID_Kho;
            }
            set
            {
                SqlInt32 iID_QuyetDinhTmp = (SqlInt32)value;
                if (iID_QuyetDinhTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("iD_QuyetDinh", "iD_QuyetDinh can't be NULL");
                }
                m_iID_Kho = value;
            }
        }

		public SqlString So_QuyetDinh
		{
			get
			{
				return m_sSo_PhieuXuat;
			}
			set
			{
				SqlString sSo_QuyetDinhTmp = (SqlString)value;
				if(sSo_QuyetDinhTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("so_QuyetDinh", "so_QuyetDinh can't be NULL");
				}
				m_sSo_PhieuXuat = value;
			}
		}


		public SqlDateTime Ngay_XuatKho
		{
			get
			{
                return m_daNgay_XuatKho;
			}
			set
			{
                SqlDateTime daNgay_XuatKhoTmp = (SqlDateTime)value;
                if (daNgay_XuatKhoTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ngay_QuyetDinh", "ngay_QuyetDinh can't be NULL");
				}
                m_daNgay_XuatKho = value;
			}
		}


        public SqlDateTime Ngay_HachToan
        {
            get
            {
                return m_daNgay_HachToan;
            }
            set
            {
                SqlDateTime daNgay_HachToanTmp = (SqlDateTime)value;
                if (daNgay_HachToanTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("Ngay_HachToan", "ngay_QuyetDinh can't be NULL");
                }
                m_daNgay_HachToan = value;
            }
        }

        public SqlString Nguoi_Lap
        {
            get
            {
                return m_sNguoi_Lap;
            }
            set
            {
                SqlString sNguoi_LapTmp = (SqlString)value;
                if (sNguoi_LapTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("Nguoi_Lap", "so_QuyetDinh can't be NULL");
                }
                m_sNguoi_Lap = value;
            }
        }


		public SqlDateTime Ngay_Lap
		{
			get
			{
				return m_daNgay_Lap;
			}
			set
			{
				SqlDateTime daNgay_LapTmp = (SqlDateTime)value;
				if(daNgay_LapTmp.IsNull)
				{
					throw new ArgumentOutOfRangeException("ngayLap", "ngayLap can't be NULL");
				}
				m_daNgay_Lap = value;
			}
		}


        public SqlString Nguoi_PheDuyet
        {
            get
            {
                return m_sNguoiPheDuyet;
            }
            set
            {
                SqlString sNguoi_PheDuyetTmp = (SqlString)value;
                if (sNguoi_PheDuyetTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("Nguoi_PheDuyet", "so_QuyetDinh can't be NULL");
                }
                m_sNguoiPheDuyet = value;
            }
        }

		public SqlDateTime Ngay_PheDuyet
		{
			get
			{
                return m_daNgayPheDuyet;
			}
			set
			{
                SqlDateTime daNgayPheDuyetTmp = (SqlDateTime)value;
                if (daNgayPheDuyetTmp.IsNull)
				{
                    throw new ArgumentOutOfRangeException("Ngay_PheDuyet", "ngay_SuaCuoi can't be NULL");
				}
                m_daNgayPheDuyet = value;
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
