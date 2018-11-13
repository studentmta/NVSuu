using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using VSCM.Base.Utils;
using System.Data.SqlTypes;
using System.Collections.Specialized;

namespace QLKho
{
    public partial class frmQD_XuatVatTu : Form
    {
        #region Variables

        private CellStyle cs1, cs2, cs3, cs4, cs5, cs6;
       
        #endregion

        #region Constructor

        public frmQD_XuatVatTu()
        {
            InitializeComponent();
            InitCellStyles();
        }
        private void InitCellStyles()
        {
            cs1 = fgQDX.Styles.Add("Đang lập");
            cs1.BackColor = Color.White;
            cs2 = fgQDX.Styles.Add("Trình duyệt");
            cs2.BackColor = Color.LightSkyBlue;
            cs3 = fgQDX.Styles.Add("Hủy duyệt");
            cs3.BackColor = Color.Tomato;
            cs4 = fgQDX.Styles.Add("Phê duyệt");
            cs4.BackColor = Color.LightGreen;
            cs5 = fgQDX.Styles.Add("Ghi thẻ kho");
            cs5.BackColor = Color.Magenta;
            cs6 = fgChiTietXuat.Styles.Add("Tổng");
            cs6.BackColor = Color.Orange;
            //cs6.Font = Font.Bold;
        }
        #endregion

        #region Func/Sub

        #region SetButton
        private void SetButtonsStatus(byte trangThai)
        {
            switch (trangThai)
            {
                case 1:
                    Lock(false, false, false, true, true, false);
                    break;
                case 5:
                    Lock(false, false, false, false, true, true);
                    break;
                case 0:
                case 3:
                    Lock(true, true, true, false, false, false);
                    break;
                case 6:
                    Lock(false, false, false, false, false, false);
                    break;
                default:
                    Lock(false, false, false, false, false, false);
                    break;
            }
        }
        private void Lock(bool sua, bool xoa, bool trinhDuyet, bool pheDuyet, bool huyDuyet, bool GhiTheKho)
        {
            btnSua.Enabled = sua;
            btnXoa.Enabled = xoa;
            btnTrinhDuyet.Enabled = trinhDuyet;
            btnPheDuyet.Enabled = pheDuyet;
            btnHuyDuyet.Enabled = huyDuyet;
            btnGhiTheKho.Enabled = GhiTheKho;
        }
        #endregion SetButton

        private void LoadKho()
        {
            var cmb = cboKhoXuat;
            cmb.Tag = 0;
            clsDM_Kho cls = new clsDM_Kho();
            DataTable dt = cls.SelectAll();
            if(dt.Rows.Count > 0){
                dt.Rows.Add(0, "Tất cả", 1, 1);
            }
            //dt.DefaultView.RowFilter = "TonTai = 1";
            //dt.DefaultView.Sort = "Ten_Kho ASC";
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_Kho";
            cmb.Properties.ValueMember = "ID_Kho";
            cmb.EditValue = 0;
            cmb.Tag = 1;
        }
        private void LoadTrangThai()
        {
            var cbo = cboTrangThai;
            cbo.Tag = 0;
            clsQD_XuatVatTu cls = new clsQD_XuatVatTu();
            DataTable dt = cls.SelectAllDayDu();
            dt = dt.DefaultView.ToTable();
            //cbo.Properties.DataSource = dt;
            //cbo.Properties.DisplayMember = "Ten_TrangThai";
            //cbo.Properties.ValueMember = "TrangThai";
            //cbo.EditValue = 0;
            cbo.Tag = 1;
        }
        public void Loadfg()
        {
            fgQDX.Tag = 0;
            fgQDX.BeginUpdate();
            clsQD_XuatVatTu cls = new clsQD_XuatVatTu();
            DataTable dt = cls.SelectAllDayDu();
            dt.DefaultView.RowFilter = "TonTai = 1";
            int iSTT = 1;
            fgQDX.Rows.Count = fgQDX.Rows.Fixed;
            foreach (DataRow dr in dt.DefaultView.ToTable().Rows)
            {
                Row fgRow = fgQDX.Rows.Add();
                fgRow["STT"] = iSTT;
                iSTT++;
                fgRow["ID_PhieuXuat"] = dr["ID_PhieuXuat"];
                fgRow["ID_Kho"] = dr["ID_Kho"];
                fgRow["Ten_kho"] = dr["Ten_kho"];
                fgRow["So_PhieuXuat"] = dr["So_PhieuXuat"];
                fgRow["Ngay_XuatKho"] = dr["Ngay_XuatKho"];
                fgRow["Ngay_HachToan"] = dr["Ngay_HachToan"];
                fgRow["Nguoi_Lap"] = dr["Nguoi_Lap"];
                fgRow["Ngay_Lap"] = dr["Ngay_Lap"];
                fgRow["Nguoi_PheDuyet"] = dr["Nguoi_PheDuyet"];
                fgRow["Ngay_PheDuyet"] = dr["Ngay_PheDuyet"];
                fgRow["TrangThai"] = dr["TrangThai"];
                fgRow["Ten_TrangThai"] = dr["Ten_TrangThai"];
                fgRow["TonTai"] = dr["TonTai"];
                if (fgRow["Ten_TrangThai"].ToString() == "Đang lập")
                {
                    fgRow.Style = cs1;
                }
                if (fgRow["Ten_TrangThai"].ToString() == "Trình duyệt")
                {
                    fgRow.Style = cs2;
                }
                else if (fgRow["Ten_TrangThai"].ToString() == "Hủy duyệt")
                {
                    fgRow.Style = cs3;
                }
                else if (fgRow["Ten_TrangThai"].ToString() == "Phê duyệt")
                {
                    fgRow.Style = cs4;
                }
                else if (fgRow["Ten_TrangThai"].ToString() == "Ghi thẻ kho")
                {
                    fgRow.Style = cs5;
                }
            }

            fgQDX.Row = -1;
            fgQDX.AutoSizeRows();
            fgQDX.EndUpdate();
            fgQDX.Tag = 1;
        }
        private void LoadfgChiTiet(int ID_PhieuXuat)
        {
            int sum = 0;
            fgChiTietXuat.Tag = 0;
            fgChiTietXuat.BeginUpdate();
            int iSTT = 1;
            fgChiTietXuat.Rows.Count = fgChiTietXuat.Rows.Fixed + 1;

            fgChiTietXuat.Cols["SoLuongHienTai"].Visible = false;
            if (ID_PhieuXuat != 0) //Xem/Sua
            {
                clsQD_XuatVatTu_ChiTiet cls = new clsQD_XuatVatTu_ChiTiet();
                DataTable dt = cls.Select_DS_VatTu(int.Parse(fgQDX[fgQDX.Row, "ID_PhieuXuat"].ToString()));
                fgChiTietXuat[fgChiTietXuat.Rows.Count - 1, "Ten_VatTu"] = "Tổng";
                fgChiTietXuat.Rows[fgChiTietXuat.Rows.Count - 1].Style = cs6;
                foreach (DataRow dr in dt.Rows)
                {
                    Row fgRow = fgChiTietXuat.Rows.Add();
                    fgRow["STT"] = iSTT;
                    iSTT++;
                    fgRow["ID_PhieuXuat"] = dr["ID_PhieuXuat"];
                    fgRow["ID_VatTu"] = dr["ID_VatTu"];
                    fgRow["Ten_VatTu"] = dr["Ten_VatTu"];
                    fgRow["SoLuongXuat"] = dr["SoLuong"];
                    if (fgQDX[fgQDX.Row, "Ten_TrangThai"].ToString() == "Ghi thẻ kho")
                    {
                        fgRow["SoLuongDaXuat"] = dr["SoLuong"];
                    }
                    else
                    {
                        fgRow["SoLuongDaXuat"] = 0;
                    }
                    sum += int.Parse(dr["SoLuong"].ToString());
                }
                fgChiTietXuat[1, "SoLuongXuat"] = sum;
                if (fgQDX[fgQDX.Row, "Ten_TrangThai"].ToString() == "Ghi thẻ kho")
                {
                    fgChiTietXuat[1, "SoLuongDaXuat"] = sum;
                }
                else
                {
                    fgChiTietXuat[1, "SoLuongDaXuat"] = 0;
                }
            }


            fgChiTietXuat.Row = -1;
            fgChiTietXuat.AutoSizeRows();
            fgChiTietXuat.EndUpdate();
            fgChiTietXuat.Tag = 1;
        }
        private void LockEditfgChiTiet(bool isLock)
        {
            fgChiTietXuat.AllowEditing = isLock;
            fgChiTietXuat.Cols["Ten_vatTu"].AllowEditing = isLock;

        }
        private void LockEdit(bool isLock)
        {
            fgChiTietXuat.Enabled = !isLock;
            fgQDX.Enabled = isLock;
            btnThem.Visible = isLock;
            btnSua.Visible = isLock;
            btnXoa.Visible = isLock;
            btnHuyDuyet.Visible = isLock;
            btnPheDuyet.Visible = isLock;
            btnTrinhDuyet.Visible = isLock;
            btnGhiTheKho.Visible = isLock;
        }
        private void LoadTheKho()
        {
            var cbo = cboTheKho;
            cbo.Tag = 0;
            clsTheKho cls = new clsTheKho();
            DataTable dt = cls.SelectAll();
            dt = dt.DefaultView.ToTable();
            cbo.Properties.DataSource = dt;
            cbo.Properties.DisplayMember = "ID_TheKho";
            cbo.Properties.ValueMember = "ID_TheKho";
            cbo.Tag = 1;

        }

        private void LoadChiTiet(string title)
        {
            int IDPX = int.Parse(fgQDX[fgQDX.Row, "ID_PhieuXuat"].ToString());
            string TenPX = fgQDX[fgQDX.Row, "So_PhieuXuat"].ToString();
            int IDKho = int.Parse(fgQDX[fgQDX.Row, "ID_Kho"].ToString());
            string TenKho = fgQDX[fgQDX.Row, "Ten_Kho"].ToString();
            DateTime NgayXuat = (DateTime)fgQDX[fgQDX.Row, "Ngay_XuatKho"];
            DateTime NgayHachToan = (DateTime)fgQDX[fgQDX.Row, "Ngay_HachToan"];
            int TrangThai = int.Parse(fgQDX[fgQDX.Row, "TrangThai"].ToString());
            frmPhieuXuat_ChiTiet frm = new frmPhieuXuat_ChiTiet(IDPX, TenPX, IDKho, TenKho, NgayXuat, NgayHachToan, TrangThai);
            frm.Text = title;
            frm.ShowDialog();
            //LoadfgChiTiet(int.Parse(fgQDX.GetDataDisplay(fgQDX.Row, "ID_PhieuXuat")));
        }

        #endregion

        #region Events

        #region Duyet

        private void btnTrinhDuyet_Click(object sender, System.EventArgs e)
        {
            Duyet("Bạn có chắc chắn muốn trình duyệt?", 1, "Trình duyệt thành công!");
        }

        private void btnPheDuyet_Click(object sender, System.EventArgs e)
        {
            Duyet("Bạn có chắc chắn muốn phê duyệt?", 5, "Phê duyệt thành công!");
            Loadfg();
        }

        private void btnHuyDuyet_Click(object sender, System.EventArgs e)
        {
            Duyet("Bạn có chắc chắn muốn hủy duyệt?", 3, "Hủy duyệt thành công!");
            //clsKho_VatTu cls = new clsKho_VatTu();
            //cls.Update_SoLuong_Xuat(int.Parse(fgQDX[fgQDX.Row, "ID_PhieuXuat"].ToString()), 3);
        }

        private void btnGhiTheKho_Click(object sender, System.EventArgs e)
        {

            clsKho_VatTu cls = new clsKho_VatTu();
            int HieuSo = cls.KiemTraSoLuong(int.Parse(fgQDX[fgQDX.Row, "ID_PhieuXuat"].ToString()), int.Parse(fgQDX[fgQDX.Row, "ID_Kho"].ToString()), 0);
            if (HieuSo >= 0) // kiểm tra số lượng xuất
            {
                Duyet("Bạn có chắc chắn muốn ghi thẻ kho?", 6, "Ghi thành công!");
                cls.Update_SoLuong_Xuat(int.Parse(fgQDX[fgQDX.Row, "ID_PhieuXuat"].ToString()), 6);
            }
            else
            {
                BaseMessages.ShowErrorMessage("Số lượng xuất lớn hơn số lượng trong kho. Vui lòng cập nhật.");
                return;
            }
        }

        private void Duyet(string question, byte trangthai, string message)
        {
            if (fgQDX.Row < fgQDX.Rows.Fixed)
            {
                BaseMessages.ShowInformationMessage("Chưa chọn quyết định.");
                return;
            }
            if (MessageBox.Show(question, "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) return;

            int fgRow = fgQDX.Row;
            byte previousTrangThai = Convert.ToByte(fgQDX[fgQDX.Row, "TrangThai"]);

            clsQD_XuatVatTu cls = new clsQD_XuatVatTu();
            cls.ID_PhieuXuat = int.Parse(fgQDX.GetDataDisplay(fgQDX.Row, "ID_PhieuXuat"));
            cls.SelectOne();
            cls.TrangThai = trangthai;
            cls.UpdateTrangThai();
            BaseMessages.ShowInformationMessage(message);
            if (trangthai == (int)GlobalVariables.TrangThai.TrinhDuyet)
            {
                fgQDX[fgQDX.Row, "Ten_TrangThai"] = "Trình duyệt";
                fgQDX[fgQDX.Row, "TrangThai"] = 1;
                fgQDX.Rows[fgQDX.Row].Style = cs2;
            }
            else if (trangthai == (int)GlobalVariables.TrangThai.HuyDuyet)
            {
                fgQDX[fgQDX.Row, "Ten_TrangThai"] = "Hủy duyệt";
                fgQDX[fgQDX.Row, "TrangThai"] = 3;
                fgQDX.Rows[fgQDX.Row].Style = cs3;
            }
            else if (trangthai == (int)GlobalVariables.TrangThai.PheDuyet)
            {
                fgQDX[fgQDX.Row, "Ten_TrangThai"] = "Phê duyệt";
                fgQDX[fgQDX.Row, "TrangThai"] = 5;
                cls.ID_PhieuXuat = int.Parse(fgQDX.GetDataDisplay(fgQDX.Row, "ID_PhieuXuat"));
                cls.Nguoi_PheDuyet = "Admin";
                cls.UpdateNguoiPheDuyet();
                fgQDX.Rows[fgQDX.Row].Style = cs4;
            }
            else if (trangthai == (int)GlobalVariables.TrangThai.GhiTheKho)
            {
                fgQDX[fgQDX.Row, "Ten_TrangThai"] = "Ghi thẻ kho";
                fgQDX[fgQDX.Row, "TrangThai"] = 6;
                fgQDX.Rows[fgQDX.Row].Style = cs5;
            }
            LockEdit(true);
            Lock(false, false, false, false, false, false);
            fgQDX.Row = -1;

            txtSoPhieuXuat.ResetText();
            fgChiTietXuat.Rows.Count = fgChiTietXuat.Rows.Fixed;

            //focus
            fgQDX.Row = fgRow;
        }

        #endregion

        #region ThemSuaXoa

        private void btnThem_Click(object sender, System.EventArgs e)
        {
            GlobalVariables.m_Flag = 0;
            frmPhieuXuat_ChiTiet frm = new frmPhieuXuat_ChiTiet();
            frm.ShowDialog();
            Loadfg();
        }

        private void btnSua_Click(object sender, System.EventArgs e)
        {
            if (fgQDX.Row < 0)
            {
                BaseMessages.ShowInformationMessage("Chưa chọn quyết định.");
                return;
            }
            GlobalVariables.m_Flag = 1;
            LoadChiTiet("Sửa phiếu xuất chi tiết");
        }

        private void btnXoa_Click(object sender, System.EventArgs e)
        {
            DialogResult dg = BaseMessages.ShowQuestionMessage("Bạn có chắc chắn muốn xóa?");
            if (dg == DialogResult.Yes)
            {
                try
                {
                    clsPhieuXuat_ChiTiet cls0 = new clsPhieuXuat_ChiTiet();
                    cls0.ID_PhieuXuat = int.Parse(fgQDX[fgQDX.Row, "ID_PhieuXuat"].ToString());
                    cls0.DeleteWID_PhieuXuatLogic();
                    clsPhieuXuat_ChiTiet_TheKho cls1 = new clsPhieuXuat_ChiTiet_TheKho();
                    cls1.ID_PhieuXuat = int.Parse(fgQDX[fgQDX.Row, "ID_PhieuXuat"].ToString());
                    cls1.DeleteWID_PhieuXuatLogic();
                    clsQD_XuatVatTu cls = new clsQD_XuatVatTu();
                    cls.ID_PhieuXuat = int.Parse(fgQDX[fgQDX.Row, "ID_PhieuXuat"].ToString());
                    cls.Delete();
                    BaseMessages.ShowInformationMessage("Xóa thành công.");
                    Loadfg();
                }
                catch (Exception ex)
                {
                    BaseMessages.ShowErrorMessage("Lỗi" + ex.ToString());
                }
            }
        }

        #endregion

        private void frmQD_XuatVatTu_Load(object sender, EventArgs e)
        {
            LockEdit(true);
            LockEditfgChiTiet(true);
            LoadKho();
            //LoadTheKho();
            LoadTrangThai();
            Loadfg();
        }

        private void fgQDX_AfterRowChange(object sender, RangeEventArgs e)
        {
            if (fgQDX.Tag + "" == "0" || fgQDX.Row < fgQDX.Rows.Fixed)
            {
                SetButtonsStatus(99);
                return;
            }
            dtpNgayHachToanFrom.Value = Convert.ToDateTime(fgQDX.GetData(fgQDX.Row, "Ngay_HachToan"));
            dtpNgayHachToanTo.Value = Convert.ToDateTime(fgQDX.GetData(fgQDX.Row, "Ngay_HachToan"));
            dtpNgayXuatKho.Value = Convert.ToDateTime(fgQDX.GetData(fgQDX.Row, "Ngay_XuatKho"));
            SetButtonsStatus(byte.Parse(fgQDX.GetDataDisplay(fgQDX.Row, "TrangThai")));

            //LoadFgChiTiet
            int ID_PhieuXuat = int.Parse(fgQDX.GetDataDisplay(fgQDX.Row, "ID_PhieuXuat"));
            LoadfgChiTiet(ID_PhieuXuat);
        }

        private void cboKhoXuat_EditValueChanged(object sender, System.EventArgs e)
        {
            if ((int)cboKhoXuat.EditValue == 0)
            {
                Loadfg();
                return;
            }
            fgQDX.Filter("ID_Kho", cboKhoXuat.EditValue.ToString());
        }

        private void txtSoPhieuXuat_EditValueChanged(object sender, System.EventArgs e)
        {
            fgQDX.Filter("So_PhieuXuat", txtSoPhieuXuat.Text.Trim());
        }

        private void cboTrangThai_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (cboTrangThai.Text != "Tất cả")
            {
                fgQDX.Filter("Ten_TrangThai", cboTrangThai.Text);
            }
            else
                Loadfg();
        }

        private void cboTheKho_EditValueChanged(object sender, System.EventArgs e)
        {

        }

        private void dtpNgayHachToanFrom_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void dtpNgayHachToanTo_TextChanged(object sender, EventArgs e)
        {

        }

        private void fgQDX_DoubleClick(object sender, EventArgs e)
        {
            LoadChiTiet("Thông tin");
        }

        #endregion
        
    }
}
