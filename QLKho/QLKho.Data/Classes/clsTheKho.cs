using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data;

namespace QLKho
{
    
    public partial class clsTheKho: clsDBInteractionBase
    {
        #region Class Member Declarations
            private SqlInt32 m_iID_TheKho, m_iID_PhieuNhap, m_iID_VatTu, m_iID_Kho, m_iSoLuong_BanDau, m_iSoLuong_HienTai;
            private SqlBoolean  m_bTonTai;
        #endregion


        public clsTheKho()
		{
			// Nothing for now.
		}
        public DataTable Select_TheKho_PX_PhieuNhap_SoLuong(int ID_PX)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_TheKho_Xuat_Select_PhieuNhap_SoLuong]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("PhieuXuat_ChiTiet_TheKho_SoLuong");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_VatTu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_VatTu));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Kho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Kho));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_PhieuXuat", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_PX));

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
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsPhieuXuat_ChiTiet_TheKho::SelectOne::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }
        public DataTable SelectVatTuWithID_XuatTheKho(int ID_VatTu, int ID_Kho)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_TheKho_Xuat_Select_PhieuNhap]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("DM_VatTu_Xuat_TheKho");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_VatTu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_VatTu));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_kho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_Kho));
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
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsDM_VatTu::Select_VatTu_W_ID_phieuNhap::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }


        public DataTable SelectSoLuongPhieuKhac(int ID_VatTu, int ID_Kho)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_TheKho_ShowSoLuongOPhieuKhac]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("DM_VatTu_Xuat_TheKho");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_VatTu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_VatTu));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_kho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_Kho));
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
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsDM_VatTu::Select_VatTu_W_ID_phieuNhap::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }


        public DataTable SelectVatTuWithID_Xuat(int ID_kho)
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_TheKho_Xuat_Select_VatTu]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("DM_VatTu_Xuat");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Kho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_kho));
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
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsDM_VatTu::Select_VatTu_W_ID_NhaCungCap::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        public override bool Insert()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_TheKho_Insert]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_PhieuNhap", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_PhieuNhap));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_VatTu", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_VatTu));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_Kho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_Kho));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@SoLuong_BanDau", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iSoLuong_BanDau));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@SoLuong_HienTai", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iSoLuong_HienTai));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@TonTai", SqlDbType.Bit,1, ParameterDirection.Input, false, 0, 0, "", DataRowVersion.Proposed, m_bTonTai));

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
                throw new Exception("clsTheKho::Insert::Error occured.", ex);
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

        public override bool Update()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_TheKho_Update]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {
                scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_TheKho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iID_TheKho));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@SoLuong_HienTai", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iSoLuong_HienTai));
                scmCmdToExecute.Parameters.Add(new SqlParameter("@SoLuong_BanDau", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, m_iSoLuong_BanDau));

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
                throw new Exception("clsTheKho::Insert::Error occured.", ex);
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

        //public override bool Update_KhiLuu(int ID_theKho)
        //{
        //    SqlCommand scmCmdToExecute = new SqlCommand();
        //    scmCmdToExecute.CommandText = "dbo.[pr_Kho_VatTu_Update_SoLuong_ChiTietTheKhoKhiLuu]";
        //    scmCmdToExecute.CommandType = CommandType.StoredProcedure;

        //    // Use base class' connection object
        //    scmCmdToExecute.Connection = m_scoMainConnection;

        //    try
        //    {
        //        scmCmdToExecute.Parameters.Add(new SqlParameter("@ID_TheKho", SqlDbType.Int, 4, ParameterDirection.Input, false, 10, 0, "", DataRowVersion.Proposed, ID_theKho));
        //        if (m_bMainConnectionIsCreatedLocal)
        //        {
        //            // Open connection.
        //            m_scoMainConnection.Open();
        //        }
        //        else
        //        {
        //            if (m_cpMainConnectionProvider.IsTransactionPending)
        //            {
        //                scmCmdToExecute.Transaction = m_cpMainConnectionProvider.CurrentTransaction;
        //            }
        //        }

        //        // Execute query.
        //        scmCmdToExecute.ExecuteNonQuery();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        // some error occured. Bubble it to caller and encapsulate Exception object
        //        throw new Exception("clsTheKho::Update::Error occured.", ex);
        //    }
        //    finally
        //    {
        //        if (m_bMainConnectionIsCreatedLocal)
        //        {
        //            // Close connection.
        //            m_scoMainConnection.Close();
        //        }
        //        scmCmdToExecute.Dispose();
        //    }
        //}


        public override DataTable SelectAll()
        {
            SqlCommand scmCmdToExecute = new SqlCommand();
            scmCmdToExecute.CommandText = "dbo.[pr_TheKho_SelectAll]";
            scmCmdToExecute.CommandType = CommandType.StoredProcedure;
            DataTable dtToReturn = new DataTable("TheKho");
            SqlDataAdapter sdaAdapter = new SqlDataAdapter(scmCmdToExecute);

            // Use base class' connection object
            scmCmdToExecute.Connection = m_scoMainConnection;

            try
            {

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
                sdaAdapter.Fill(dtToReturn);
                return dtToReturn;
            }
            catch (Exception ex)
            {
                // some error occured. Bubble it to caller and encapsulate Exception object
                throw new Exception("clsTheKho::SelectAll::Error occured.", ex);
            }
            finally
            {
                if (m_bMainConnectionIsCreatedLocal)
                {
                    // Close connection.
                    m_scoMainConnection.Close();
                }
                scmCmdToExecute.Dispose();
                sdaAdapter.Dispose();
            }
        }

        #region Class Property Declarations
        public SqlInt32 ID_TheKho
        {
            get
            {
                return m_iID_TheKho;
            }
            set
            {
                SqlInt32 iID_TheKhoTmp = (SqlInt32)value;
                if (iID_TheKhoTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("ID_TheKho", "ID_TheKho can't be NULL");
                }
                m_iID_TheKho = value;
            }
        }

        public SqlInt32 ID_PhieuNhap
        {
            get
            {
                return m_iID_PhieuNhap;
            }
            set
            {
                SqlInt32 iID_PhieuNhapTmp = (SqlInt32)value;
                if (iID_PhieuNhapTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("ID_PhieuNhap", "ID_PhieuNhap can't be NULL");
                }
                m_iID_PhieuNhap = value;
            }
        }


        public SqlInt32 ID_VatTu
        {
            get
            {
                return m_iID_VatTu;
            }
            set
            {
                SqlInt32 iID_VatTuTmp = (SqlInt32)value;
                if (iID_VatTuTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("ID_VatTu", "ID_VatTu can't be NULL");
                }
                m_iID_VatTu = value;
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
                SqlString iID_KhoTmp = (SqlString)value;
                if (iID_KhoTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("ID_Kho", "ID_Kho can't be NULL");
                }
                m_iID_Kho = value;
            }
        }


        public SqlInt32 SoLuong_BanDau
        {
            get
            {
                return m_iSoLuong_BanDau;
            }
            set
            {
                SqlInt32 iSoLuong_BanDauTmp = (SqlInt32)value;
                if (iSoLuong_BanDauTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("SoLuong_BanDau", "SoLuong_BanDau can't be NULL");
                }
                m_iSoLuong_BanDau = value;
            }
        }


        public SqlInt32 SoLuong_HienTai
        {
            get
            {
                return m_iSoLuong_HienTai;
            }
            set
            {
                SqlInt32 iSoLuong_HienTaiTmp = (SqlInt32)value;
                if (iSoLuong_HienTaiTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("SoLuong_HienTai", "SoLuong_HienTai can't be NULL");
                }
                m_iSoLuong_HienTai = value;
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
                if (bTonTaiTmp.IsNull)
                {
                    throw new ArgumentOutOfRangeException("TonTai", "TonTai can't be NULL");
                }
                m_bTonTai = value;
            }
        }

        #endregion
    }
}
