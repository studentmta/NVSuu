using C1.Win.C1FlexGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VSCM.Base.Utils;

namespace QLKho
{
    public partial class frmPhieuXuat_ChiTiet : Form
    {
        #region Variables

        private CellStyle cs,cs1;
        DataTable m_dtTmp;
        int m_iID_PX;
        string m_sTen_PX;
        int m_iID_Kho;
        string m_sTenKho;
        DateTime m_daNgayXuatKho;
        DateTime m_daNgayHachToan;
        int m_iTrangThai;
        #endregion

        #region Constructors

        public frmPhieuXuat_ChiTiet()
        {
            InitializeComponent();
            InitCellStyles();
        }

        private void InitCellStyles()
        {
            cs = fgChiTietXuat.Styles.Add("Tổng");
            cs.BackColor = Color.Orange;
            cs1 = fgChiTietXuat.Styles.Add("Dòng");
            cs1.BackColor = System.Drawing.Color.Yellow;
        }
        public frmPhieuXuat_ChiTiet(int iID_PX, string sTen_PX, int iID_Kho, string sTenKho, DateTime daNgayXuatKho, DateTime daNgayHachToan, int iTrangThai)
            : this()
        {
            m_iID_PX = iID_PX;
            m_sTen_PX = sTen_PX;
            m_iID_Kho = iID_Kho;
            m_sTenKho = sTenKho;
            m_daNgayXuatKho = daNgayXuatKho;
            m_daNgayHachToan = daNgayHachToan;
            m_iTrangThai = iTrangThai;
        }

        #endregion

        #region Func/Sub

        private void LockEdit(bool isLock)
        {
            txtSoPhieuXuat.Enabled = isLock;
            cboKhoXuat.Enabled = isLock;
            dtpNgayXuatKho.Enabled = isLock;
            dtpNgayHachToan.Enabled = isLock;
            fgChiTietTheKho.Enabled = isLock;
            btnLuu.Visible = isLock;
            btnHuy.Visible = isLock;
        }
        private void LoadfgChiTietPhieuXuat(int ID_Kho)
        {
            fgChiTietXuat.BeginUpdate();
            clsTheKho cls = new clsTheKho();
            DataTable dt = cls.SelectVatTuWithID_Xuat(ID_Kho);
            int iSTT = 1;
            int sum = 0;
            fgChiTietXuat.Rows.Count = fgChiTietXuat.Rows.Fixed + 1;
            fgChiTietXuat[fgChiTietXuat.Rows.Count-1, "Ten_VatTu"] = "Tổng";
            fgChiTietXuat[fgChiTietXuat.Rows.Count - 1, "SoLuongXuat"] = 0;
            fgChiTietXuat.Rows[fgChiTietXuat.Rows.Count - 1].Style = cs;
            foreach (DataRow dr in dt.Rows)
            {
                Row fgRow = fgChiTietXuat.Rows.Add();
                fgRow["STT"] = iSTT;
                iSTT++;
                fgRow["ID_VatTu"] = dr["ID_VatTu"];
                fgRow["Ten_VatTu"] = dr["Ten_VatTu"];
                fgRow["SoLuongHienTai"] = dr["SoLuongHienTai"];
                fgRow["SoLuongXuat"] = 0;
                sum += int.Parse(dr["SoLuongHienTai"].ToString());
                fgChiTietXuat.SetCellStyle(iSTT, 4, cs1);
                
            }
            fgChiTietXuat[fgChiTietXuat.Rows.Fixed, "SoLuongHienTai"] = sum;

            fgChiTietXuat.EndUpdate();
        }
        private void LoadfgChiTietPhieuXuatWTSua(int iID_Kho, int iID_PhieuXuat)
        {
            fgChiTietXuat.BeginUpdate();
            clsPhieuXuat cls = new clsPhieuXuat();
            //txtSoPhieuXuat.Text = cls.So_PhieuXuat.ToString();
            cls.ID_Kho = iID_Kho;
            cls.ID_PhieuXuat = iID_PhieuXuat;
            DataTable dt = cls.SelectPX_SoLuong();
            int iSTT = 1;
            int sum = 0;
            int SLXuat = 0;
            fgChiTietXuat.Rows.Count = fgChiTietXuat.Rows.Fixed+1;
            fgChiTietXuat[fgChiTietXuat.Rows.Count - 1, "Ten_VatTu"] = "Tổng";
            fgChiTietXuat[fgChiTietXuat.Rows.Count - 1, "SoLuongXuat"] = 0;
            fgChiTietXuat.Rows[fgChiTietXuat.Rows.Count - 1].Style = cs;
            foreach (DataRow dr in dt.Rows)
            {
                Row fgRow = fgChiTietXuat.Rows.Add();
                fgRow["STT"] = iSTT;
                iSTT++;
                fgRow["ID_VatTu"] = dr["ID_VatTu"];
                fgRow["Ten_VatTu"] = dr["Ten_VatTu"];
                fgRow["SoLuongHienTai"] = dr["SoLuongHienTai"];
                if ((fgRow["SoLuongXuat"]??"").ToString() == "")
                {
                    fgRow["SoLuongXuat"] = 0;
                }

                fgRow["SoLuongXuat"] = dr["SoLuong"];
                fgChiTietXuat.SetCellStyle(iSTT, 4, cs1);
                sum += int.Parse(dr["SoLuongHienTai"].ToString());
            }
            for (int i = fgChiTietXuat.Rows.Fixed+1; i < fgChiTietXuat.Rows.Count; i++)
            {
                if (fgChiTietXuat[i, "SoLuongXuat"] != null)
                {
                    SLXuat += int.Parse(fgChiTietXuat[i, "SoLuongXuat"].ToString());
                }
            }

            fgChiTietXuat[fgChiTietXuat.Rows.Fixed, "SoLuongHienTai"] = sum;
            fgChiTietXuat[fgChiTietXuat.Rows.Fixed , "SoLuongXuat"] = SLXuat;

            fgChiTietXuat.EndUpdate();
        }
        private void UpdateFgPhieuXuat(int iSoLuong)
        {
            fgChiTietXuat.BeginUpdate();
            int iTong = 0;
            fgChiTietXuat[fgChiTietXuat.Row, "SoLuongXuat"] = iSoLuong;
            for (int i = fgChiTietXuat.Rows.Fixed+ 1; i < fgChiTietXuat.Rows.Count; i++)
            {
                if(fgChiTietXuat[i,"SoLuongXuat"] != null)
                {
                    iTong += int.Parse(fgChiTietXuat[i,"SoLuongXuat"].ToString());
                }
            }
            fgChiTietXuat[fgChiTietXuat.Rows.Fixed, "SoLuongXuat"] = iTong;
            fgChiTietXuat.EndUpdate();
        }
        private void UpdateFgPhieuXuatChiTiet(int iSoLuong)
        {
            fgChiTietTheKho.BeginUpdate();
            if (fgChiTietTheKho.Row > 0)
            {
                fgChiTietTheKho[fgChiTietTheKho.Rows.Fixed, "SoLuongXuat"] = iSoLuong; 
            }
            fgChiTietTheKho.EndUpdate();
        }
        private void LoadKho()
        {
            var cmb = cboKhoXuat;
            cmb.Tag = 0;
            clsDM_Kho cls = new clsDM_Kho();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai = 1";
            dt.DefaultView.Sort = "ID_Kho ASC";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_Kho";
            cmb.Properties.ValueMember = "ID_Kho";
            cmb.EditValue = 0;
            cmb.Tag = 1;
        }
        private bool IsValidPhieuXuat()
        {
            if ((txtSoPhieuXuat.Text ?? "") == "" || cboKhoXuat.EditValue == null || dtpNgayHachToan.Text == "" || dtpNgayXuatKho.Text == "")
            {
                BaseMessages.ShowInformationMessage("Vui lòng nhập đầy đủ thông tin.");
                return false;
            }
            else
            {
                clsPhieuXuat cls = new clsPhieuXuat();
                DataTable dt = cls.SelectAll();
                foreach (DataRow dr in dt.Rows)
                {
                    if (txtSoPhieuXuat.Text.Trim() == dr["So_PhieuXuat"].ToString().Trim())
                    {
                        if (GlobalVariables.m_Flag != 0) continue;
                        BaseMessages.ShowErrorMessage("Trùng số phiếu. Vui lòng nhập lại.");
                        return false;
                    }
                }

                if (fgChiTietTheKho.Row < 0 && GlobalVariables.m_Flag == 0)
                {
                    BaseMessages.ShowInformationMessage("Vui lòng chọn vật tư.");
                    return false;
                }
                if (!IsValidPhieuXuatTheKho())
                {
                    BaseMessages.ShowInformationMessage("Vui lòng nhập số lượng vật tư và số vật tư xuất phải bé hơn vật tư có trong kho.");
                    return false;
                }
            }
            return true;
        }
        private bool IsValidPhieuXuatTheKho()
        {
            for (int i = fgChiTietTheKho.Rows.Fixed; i < fgChiTietTheKho.Rows.Count; i++)
            {
                if (fgChiTietTheKho[i, "SoLuongXuat"] != null)
                {
                    if (int.Parse(fgChiTietTheKho[i, "SoLuongTrongKho"].ToString()) >= int.Parse(fgChiTietTheKho[i, "SoLuongXuat"].ToString()))
                    {
                        return true;
                    }
                    return true;
                }
            }

            return false;
        }
        public void LoadDetail()
        {
            txtSoPhieuXuat.Text = m_sTen_PX;
            cboKhoXuat.EditValue = m_iID_Kho;
            cboKhoXuat.SelectedText = m_sTenKho;
            dtpNgayXuatKho.Value = m_daNgayXuatKho;
            dtpNgayHachToan.Value = m_daNgayHachToan;
        }
        private bool Check_DB_PXCT(int i)
        {
            clsPhieuXuat_ChiTiet cls = new clsPhieuXuat_ChiTiet();
            cls.ID_PhieuXuat = m_iID_PX;
            DataTable dt = cls.SelectAllWTPX();
            foreach (DataRow dr in dt.Rows)
            {
                if (int.Parse(fgChiTietXuat[i, "ID_VatTu"].ToString()) == int.Parse(dr["ID_VatTu"].ToString()))
                    return false;
            }
            return true;
        }
        private void SavePhieuChiTiet(int ID_PhieuXuat)
        {
            clsPhieuXuat_ChiTiet cls1 = new clsPhieuXuat_ChiTiet();
            
            for (int i = fgChiTietXuat.Rows.Fixed +1; i < fgChiTietXuat.Rows.Count; i++)
            {
                if (int.Parse(fgChiTietXuat[i, "SoLuongXuat"].ToString()) != 0)
                {

                    if (Check_DB_PXCT(i))
                    {
                        cls1.ID_PhieuXuat = ID_PhieuXuat;
                        cls1.ID_VatTu = int.Parse(fgChiTietXuat[i, "ID_VatTu"].ToString());
                        cls1.SoLuong = int.Parse(fgChiTietXuat[i, "SoLuongXuat"].ToString());
                        cls1.Insert();
                    }
                    else
                        cls1.ID_PhieuXuat = ID_PhieuXuat;
                        cls1.ID_VatTu = int.Parse(fgChiTietXuat[i, "ID_VatTu"].ToString());
                        cls1.SoLuong = int.Parse(fgChiTietXuat[i, "SoLuongXuat"].ToString());
                        cls1.Update();
                }
                else
                {
                    DeleteVatTuWTIndex0(ID_PhieuXuat);
                    cls1.ID_PhieuXuat = ID_PhieuXuat;
                    cls1.ID_VatTu = int.Parse(fgChiTietXuat[i, "ID_VatTu"].ToString());
                    cls1.Delete();
                }
            }
        }
        private void DeleteVatTuWTIndex0(int ID_PhieuXuat)
        {
            clsPhieuXuat_ChiTiet_TheKho clss = new clsPhieuXuat_ChiTiet_TheKho();
            clss.ID_PhieuXuat = ID_PhieuXuat;
            clss.ID_VatTu = int.Parse(fgChiTietXuat[fgChiTietXuat.Row, "ID_VatTu"].ToString());
            for (int j = fgChiTietTheKho.Rows.Fixed + 1; j < fgChiTietTheKho.Rows.Count; j++)
            {
                if (int.Parse(fgChiTietTheKho[j, "SoLuongXuat"].ToString()) == 0)
                {
                    clss.ID_TheKho = int.Parse(fgChiTietTheKho[j, "ID_TheKho"].ToString());
                    clss.Delete();
                }
            }
            
        }
        private void SavePhieuChiTiet_TheKho(int ID_PhieuXuat)
        {
            clsPhieuXuat_ChiTiet_TheKho cls = new clsPhieuXuat_ChiTiet_TheKho();
            
            for (int i = fgChiTietTheKho.Rows.Fixed+1; i < fgChiTietTheKho.Rows.Count; i++)
            {
                if (GlobalVariables.m_Flag == 0)
                {
                    foreach (DataRow dr in m_dtTmp.Rows)
                    {
                        cls.ID_PhieuXuat = ID_PhieuXuat;
                        cls.ID_VatTu = int.Parse(dr["ID_VatTu"].ToString());
                        cls.ID_TheKho = int.Parse(dr["ID_TheKho"].ToString());
                        cls.SoLuong = int.Parse(dr["SoLuong"].ToString());
                        cls.Insert();
                    }
                }
                else
                {
                    LoadFgTheKho();
                    cls.ID_PhieuXuat = ID_PhieuXuat;
                    cls.ID_VatTu = int.Parse(fgChiTietXuat[fgChiTietXuat.Row,"ID_VatTu"].ToString());
                    cls.ID_TheKho = int.Parse(fgChiTietTheKho[i, "ID_TheKho"].ToString());
                    cls.SoLuong = int.Parse(fgChiTietTheKho[i, "SoLuongXuat"].ToString());
                    cls.Update();
                }
            }
            
        }
        private void LoadDataTableTmpWTVatTu()
        {
            for (int i = fgChiTietTheKho.Rows.Fixed +1 ; i < fgChiTietTheKho.Rows.Count; i++)
            {
                foreach (DataRow drTmp in m_dtTmp.Rows)
                {
                    if (int.Parse(fgChiTietXuat[fgChiTietXuat.Row, "ID_VatTu"].ToString().Trim()) == int.Parse(drTmp["ID_VatTu"].ToString().Trim())
                        && int.Parse(fgChiTietTheKho[i, "ID_TheKho"].ToString().Trim()) == int.Parse(drTmp["ID_TheKho"].ToString().Trim()))
                    {
                        fgChiTietTheKho[i, "SoLuongXuat"] = drTmp["SoLuong"];
                    }
                }
            }
        }
        private void ThemMoiDataTableTmp(DataRow dr)
        {
            dr["ID_VatTu"] = fgChiTietXuat[fgChiTietXuat.Row, "ID_VatTu"];
            dr["ID_TheKho"] = fgChiTietTheKho[fgChiTietTheKho.Row, "ID_TheKho"];

            if ((fgChiTietTheKho[fgChiTietTheKho.Row, "SoLuongXuat"] ?? "").ToString() == "")
            {
                dr["SoLuong"] = 0;
            }
            else
            {
                if(int.Parse(fgChiTietTheKho[fgChiTietTheKho.Row,"SoLuongXuat"].ToString()) < 0)
                {
                    BaseMessages.ShowErrorMessage("Số lượng xuất không âm.");
                    fgChiTietTheKho[fgChiTietTheKho.Row, "SoLuongXuat"] = 0;
                    return;
                }
                else
                {
                    if (int.Parse(fgChiTietTheKho[fgChiTietTheKho.Row, "SoLuongtrongkho"].ToString()) < (int.Parse(fgChiTietTheKho[fgChiTietTheKho.Row, "SoLuongXuat"].ToString())+ int.Parse(fgChiTietTheKho[fgChiTietTheKho.Row,"SoLuongKhac"].ToString())))
                    {
                        BaseMessages.ShowErrorMessage("Số lượng xuất phải bé hơn số lượng trong kho.");
                        fgChiTietTheKho[fgChiTietTheKho.Row, "SoLuongXuat"] = 0;
                        return;
                    }
                    else
                        dr["SoLuong"] = fgChiTietTheKho[fgChiTietTheKho.Row, "SoLuongXuat"];
                }
            }
        }
        private void UpdateSoLuongDataTableTmp(DataRow dr)
        {
            if (GlobalVariables.m_Flag == 0)
            {
                for (int i = 0; i < m_dtTmp.Rows.Count; i++)
                {
                    for (int j = i + 1; j < m_dtTmp.Rows.Count; j++)
                    {
                        if (int.Parse(m_dtTmp.Rows[i]["ID_TheKho"].ToString().Trim()) == int.Parse(m_dtTmp.Rows[j]["ID_TheKho"].ToString().Trim()))
                        {
                            m_dtTmp.Rows.Remove(dr);
                            m_dtTmp.Rows[i]["SoLuong"] = fgChiTietTheKho[fgChiTietTheKho.Row, "SoLuongXuat"];
                        }
                    }
                }
            }
            else
            {
                clsPhieuXuat_ChiTiet_TheKho cls = new clsPhieuXuat_ChiTiet_TheKho();
                cls.ID_PhieuXuat = m_iID_PX;
                cls.ID_VatTu = int.Parse(fgChiTietXuat[fgChiTietXuat.Row, "ID_VatTu"].ToString());
                cls.ID_TheKho = int.Parse(fgChiTietTheKho[fgChiTietTheKho.Row, "ID_TheKho"].ToString());
                cls.SoLuong = int.Parse(fgChiTietTheKho[fgChiTietTheKho.Row, "SoLuongXuat"].ToString());
                cls.Update();
            }
        }
        private void LoadTheKhoSoLuongKhac()
        {
            int sum = 0;
            clsTheKho clss = new clsTheKho();
            DataTable dtt = clss.SelectSoLuongPhieuKhac(int.Parse(fgChiTietXuat[fgChiTietXuat.Row, "ID_VatTu"].ToString()), int.Parse(cboKhoXuat.EditValue.ToString()));
            foreach (DataRow dr in dtt.Rows)
            {
                for (int j = fgChiTietTheKho.Rows.Fixed + 1; j < fgChiTietTheKho.Rows.Count; j++)
                {
                    if (int.Parse(dr["ID_TheKho"].ToString()) == int.Parse(fgChiTietTheKho.GetDataDisplay(j, "ID_TheKho")))
                    {
                        if (GlobalVariables.m_Flag == 0 || m_iTrangThai == (int)GlobalVariables.TrangThai.GhiTheKho)
                        {
                            fgChiTietTheKho[j, "SoLuongKhac"] = dr["SoLuongXuatOPhieuKhac"];
                        }
                        else
                        {
                            fgChiTietTheKho[j, "SoLuongKhac"] = int.Parse(dr["SoLuongXuatOPhieuKhac"].ToString()) - int.Parse(fgChiTietTheKho[j, "SoLuongXuat"].ToString());

                        }
                        sum += int.Parse(fgChiTietTheKho[j, "SoLuongKhac"].ToString());
                    }
                }
            }
            fgChiTietTheKho[fgChiTietTheKho.Rows.Fixed, "SoLuongKhac"] = sum;
        }
        private void LoadFgTheKho()
        {
            DataTable dt = new DataTable();
            if (GlobalVariables.m_Flag == 0)
            {
                clsTheKho cls = new clsTheKho();
                dt = cls.SelectVatTuWithID_XuatTheKho(int.Parse(fgChiTietXuat[fgChiTietXuat.Row, "ID_VatTu"].ToString()), int.Parse(cboKhoXuat.EditValue.ToString()));
            }
            else
            {
                clsTheKho cls = new clsTheKho();
                cls.ID_VatTu = int.Parse(fgChiTietXuat[fgChiTietXuat.Row, "ID_VatTu"].ToString());
                cls.ID_Kho = m_iID_Kho;
                dt = cls.Select_TheKho_PX_PhieuNhap_SoLuong(m_iID_PX);
            }
            int iSTT = 1;
            fgChiTietTheKho.Rows.Count = fgChiTietTheKho.Rows.Fixed + 1;
            fgChiTietTheKho[fgChiTietTheKho.Rows.Count - 1, "ID_TheKho"] = "Tổng";
            fgChiTietTheKho.Rows[fgChiTietTheKho.Rows.Count - 1].Style = cs;
            foreach (DataRow dr in dt.Rows)
            {
                Row fgRow = fgChiTietTheKho.Rows.Add();
                fgRow["STT"] = iSTT;
                iSTT++;
                fgRow["ID_TheKho"] = dr["ID_TheKho"];
                fgRow["ID_PhieuNhap"] = dr["ID_PhieuNhap"];
                fgRow["So_PhieuNhap"] = dr["So_QuyetDinh"];
                fgRow["SoLuongTrongKho"] = dr["SoLuong_HienTai"];
                fgRow["Ngay_NhapKho"] = dr["Ngay_QuyetDinh"];
                fgRow["SoLuongXuat"] = 0;
                fgRow["SoLuongKhac"] = 0;
                if (GlobalVariables.m_Flag != 0)
                {
                    fgRow["SoLuongXuat"] = dr["SoLuong"];
                }
                fgChiTietTheKho.SetCellStyle(iSTT, 7,cs1);
            }

        }

        #endregion

        #region Events

        private void btnLuu_Click(object sender, EventArgs e)
        {
            clsPhieuXuat cls = new clsPhieuXuat();
            cls.ID_Kho = int.Parse(cboKhoXuat.EditValue.ToString());
            cls.Ngay_HachToan = (DateTime)dtpNgayHachToan.Value;
            cls.So_PhieuXuat = txtSoPhieuXuat.Text;
            cls.Ngay_XuatKho = (DateTime)dtpNgayXuatKho.Value;
            cls.Ngay_Lap = GlobalVariables.NgayLV;
            cls.Ngay_PheDuyet = GlobalVariables.NgayLV;
            cls.Nguoi_Lap = "ABC";
            cls.Nguoi_PheDuyet = "";
            cls.TrangThai = 0;
            cls.TonTai = true;
            if (IsValidPhieuXuat())
            {
                
                try
                {
                    if (GlobalVariables.m_Flag == 0)
                    {
                        cls.Insert();
                        SavePhieuChiTiet(int.Parse(cls.ID_PhieuXuat.ToString()));
                        SavePhieuChiTiet_TheKho(int.Parse(cls.ID_PhieuXuat.ToString()));
                    }
                    else
                    {
                        cls.Update();
                        SavePhieuChiTiet(m_iID_PX);
                        SavePhieuChiTiet_TheKho(m_iID_PX);
                    }
                    BaseMessages.ShowInformationMessage("Cập nhật thành công.");
                    m_dtTmp.Dispose();
                    this.Close();
                    GlobalVariables.m_Flag = 100;
                }
                catch (Exception ex)
                {
                    BaseMessages.ShowErrorMessage(ex.ToString());
                }
            }
            
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            m_dtTmp.Dispose();
            this.Close();
            GlobalVariables.m_Flag = 100;
        }
        private void cboKhoXuat_EditValueChanged(object sender, EventArgs e)
        {
            //LoadfgChiTietPhieuXuat(int.Parse(cboKhoXuat.EditValue.ToString()));
            if (GlobalVariables.m_Flag == 0)
            {
                LoadfgChiTietPhieuXuat(int.Parse(cboKhoXuat.EditValue.ToString()));
            }
            else
            {
                //LoadfgChiTietPhieuXuatWTSua(iID_Kho, iID_PX);
            }
        }
        private void frmPhieuXuat_ChiTiet_Load(object sender, EventArgs e)
        {
            m_dtTmp = new DataTable("tableTmp");
            m_dtTmp.Columns.Add("ID_VatTu", typeof(int));
            m_dtTmp.Columns.Add("ID_TheKho", typeof(int));
            m_dtTmp.Columns.Add("SoLuong", typeof(int));
            if (GlobalVariables.m_Flag == 0)
            {
                // số phiếu xuất
                clsPhieuXuat cls = new clsPhieuXuat();
                cls.SelectLast_IDPX();
                txtSoPhieuXuat.Text = "PX-"+DateTime.Now.Year+"-"+DateTime.Now.Month+"-"+DateTime.Now.Day+"-"+cls.ID_PhieuXuat ;
                LoadKho();
                dtpNgayHachToan.Value = DateTime.Now;
                dtpNgayXuatKho.Value = DateTime.Now;
            }
            else
            {
                 LoadKho();
                 LoadDetail();
                 LoadfgChiTietPhieuXuatWTSua(m_iID_Kho, m_iID_PX);
                 if (m_iTrangThai == (int)GlobalVariables.TrangThai.GhiTheKho || m_iTrangThai == (int)GlobalVariables.TrangThai.PheDuyet
                 || m_iTrangThai == (int)GlobalVariables.TrangThai.TrinhDuyet)
                 {
                     LockEdit(false);
                 }
                 else
                    cboKhoXuat.Enabled = false;
            }
            
        }
        private void fgChiTietXuat_Click(object sender, EventArgs e)
        {
            if (fgChiTietXuat.Row <= 1) return;
            fgChiTietTheKho.BeginUpdate();
            LoadFgTheKho();
            LoadTheKhoSoLuongKhac();
            int sum = 0;
            int SLXuat = 0;
            for (int i = fgChiTietTheKho.Rows.Fixed+1; i < fgChiTietTheKho.Rows.Count; i++)
            {
                if (fgChiTietTheKho[i, "SoLuongXuat"] != null)
                {
                    sum += int.Parse(fgChiTietTheKho[i, "SoLuongTrongKho"].ToString());
                    SLXuat += int.Parse(fgChiTietTheKho[i, "SoLuongXuat"].ToString());
                }
            }
            fgChiTietTheKho[fgChiTietTheKho.Rows.Fixed , "SoLuongTrongKho"] = sum;
            fgChiTietTheKho[fgChiTietTheKho.Rows.Fixed , "SoLuongXuat"] = SLXuat;
            
            LoadDataTableTmpWTVatTu(); // load số lượng vật tư ứng thẻ kho
            fgChiTietTheKho.EndUpdate();
        }
        private void fgChiTietTheKho_AfterEdit(object sender, RowColEventArgs e)
        {
            int sl = 0;
            if (fgChiTietTheKho[fgChiTietTheKho.Row, "SoLuongXuat"] != null)
            {
                DataRow dr = m_dtTmp.NewRow();
                ThemMoiDataTableTmp(dr);
                m_dtTmp.Rows.Add(dr);
                UpdateSoLuongDataTableTmp(dr); // update số lượng vật tư trong thẻ kho khi thay đổi số lượng 
            }
            clsTheKho cls = new clsTheKho();
            DataTable dt = cls.SelectVatTuWithID_XuatTheKho(int.Parse(fgChiTietXuat[fgChiTietXuat.Row,"ID_VatTu"].ToString()),m_iID_Kho); 
            for (int i = fgChiTietTheKho.Rows.Fixed+1; i < fgChiTietTheKho.Rows.Count; i++)
            {
                if (fgChiTietTheKho[i, "SoLuongXuat"] != null)
                {
                    sl += int.Parse(fgChiTietTheKho[i, "SoLuongXuat"].ToString());
                }
            }
            UpdateFgPhieuXuatChiTiet(sl);
            UpdateFgPhieuXuat(sl);
        }
        private void frmPhieuXuat_ChiTiet_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalVariables.m_Flag = 100;
        }

        #endregion


    }
}
