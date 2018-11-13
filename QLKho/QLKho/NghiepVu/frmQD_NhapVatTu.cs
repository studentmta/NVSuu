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
    public partial class frmQD_NhapVatTu : Form
    {
        private bool m_blFlag = true;
        private CellStyle cs1, cs2, cs3, cs4 ,cs5;
        public frmQD_NhapVatTu()
        {
            InitializeComponent();
            InitCellStyles();
        }

        private void InitCellStyles()
        {
            cs1 = fgQD.Styles.Add("Đang lập");
            cs1.BackColor = Color.White;
            cs2 = fgQD.Styles.Add("Trình duyệt");
            cs2.BackColor = Color.LightSkyBlue;
            cs3 = fgQD.Styles.Add("Hủy duyệt");
            cs3.BackColor = Color.Tomato;
            cs4 = fgQD.Styles.Add("Phê duyệt");
            cs4.BackColor = Color.LightGreen;
            cs5 = fgQD.Styles.Add("Ghi thẻ kho");
            cs5.BackColor = Color.Magenta;
        }
        private void ResetTextboxs()
        {
            txtSoQuyetDinh.Text = "";
            cmbNhaCungCap.EditValue = 0;
            dtmNgayQD.Value = (new clsFunctions()).SelectCurrentDateTime();
        }
        #region SetButton
        private void SetButtonsStatus(byte trangThai)
        {
            switch (trangThai)
            {
                case 1:
                    Lock(false, false, false, true, true,false);
                    break;
                case 5:
                    Lock(false, false, false, false, true,true);
                    break;
                case 0:
                case 3:
                    Lock(true, true, true, false, false,false);
                    break;
                case 6:
                    Lock(false, false, false, false, false, false);
                    break;
                default:
                    Lock(false, false, false, false, false,false);
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

        #region Event
        private void frmQD_NhapVatTu_Load(object sender, EventArgs e)
        {
            LockEdit(true);
            LockEditfgChiTiet(true);
            Loadfg();
            LoadCmbNhaCungCap();
        }
        private void fg_AfterRowChange(object sender, C1.Win.C1FlexGrid.RangeEventArgs e)
        {
            if (fgQD.Tag + "" == "0" || fgQD.Row < fgQD.Rows.Fixed)
            {
                SetButtonsStatus(99);
                return;
            }

            txtSoQuyetDinh.Text = fgQD.GetDataDisplay(fgQD.Row, "So_QuyetDinh");
            dtmNgayQD.Value = Convert.ToDateTime(fgQD.GetData(fgQD.Row, "Ngay_QuyetDinh"));
            cmbNhaCungCap.EditValue = fgQD.GetIntValue(fgQD.Row, "ID_NhaCungCap");

            SetButtonsStatus(byte.Parse(fgQD.GetDataDisplay(fgQD.Row, "TrangThai")));

            //LoadFgChiTiet
            int ID_QuyetDinh = int.Parse(fgQD.GetDataDisplay(fgQD.Row, "ID_QuyetDinh"));
            int ID_NhaCungCap = int.Parse(fgQD.GetDataDisplay(fgQD.Row, "ID_NhaCungCap"));
            LoadfgChiTiet(ID_QuyetDinh, ID_NhaCungCap);
        }
        private void cmbNhaCungCap_EditValueChanged(object sender, EventArgs e)
        {
            if (!gbThongTinQD.Enabled) return;
            if (!m_blFlag)
            {
                LoadfgChiTiet(int.Parse(fgQD.GetDataDisplay(fgQD.Row, "ID_QuyetDinh")), int.Parse(cmbNhaCungCap.EditValue.ToString()));
            }
            else
            {
                LoadfgChiTiet(0, int.Parse(cmbNhaCungCap.EditValue.ToString()));
            }
        }
        #endregion Event

        #region TimKiem
        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            fgQD.Filter("So_QuyetDinh", "Ten_NhaCungCap", "Ten_TrangThai", txtTimKiem.Text.Trim());
        }
       
        private void txtTimKiemChiTiet_EditValueChanged(object sender, EventArgs e)
        {
            fgChiTiet.Filter("Ten_VatTu", "ID_Kho", txtTimKiemChiTiet.Text.Trim());
        }
        #endregion TimKiem

        /// <summary>
        /// Load flexgrids and comboboxs
        /// </summary>
        #region Load
        private void LoadCmbNhaCungCap()
        {
            var cmb = cmbNhaCungCap;
            cmb.Tag = 0;
            clsDM_NhaCungCap cls = new clsDM_NhaCungCap();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai = 1";
            dt.DefaultView.Sort = "ID_NhaCungCap ASC";
            //if (dt.DefaultView.ToTable().Rows.Count > 0)
            //{
            //    DataRow dr = dt.NewRow();
            //    dr["ID_NhaCungCap"] = 0;
            //    dr["Ten_NhaCungCap"] = "Tất cả";
            //    dt.Rows.InsertAt(dr, 0);
            //}
            dt = dt.DefaultView.ToTable();
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_NhaCungCap";
            cmb.Properties.ValueMember = "ID_NhaCungCap";
            cmb.EditValue = 0;
            cmb.Tag = 1;
        }
        private void Loadfg()
        {
            fgQD.Tag = 0;
            fgQD.BeginUpdate();
            clsQD_NhapVatTu cls = new clsQD_NhapVatTu();
            DataTable dt = cls.SelectAllDayDu();
            dt.DefaultView.RowFilter = "TonTai = 1";
            
            int iSTT = 1;
            fgQD.Rows.Count = fgQD.Rows.Fixed;
            foreach (DataRow dr in dt.DefaultView.ToTable().Rows)
            {
                Row fgRow = fgQD.Rows.Add();
                fgRow["STT"] = iSTT;
                iSTT++;
                fgRow["ID_QuyetDinh"] = dr["ID_QuyetDinh"];
                fgRow["So_QuyetDinh"] = dr["So_QuyetDinh"];
                fgRow["ID_NhaCungCap"] = dr["ID_NhaCungCap"];
                fgRow["Ten_NhaCungCap"] = dr["Ten_NhaCungCap"];
                fgRow["Ngay_QuyetDinh"] = dr["Ngay_QuyetDinh"];
                fgRow["NgayLap"] = dr["NgayLap"];
                fgRow["Ngay_SuaCuoi"] = dr["Ngay_SuaCuoi"];
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

            fgQD.Row = -1;
            fgQD.AutoSizeRows();
            fgQD.EndUpdate();
            fgQD.Tag = 1;
        }
        private void LoadfgChiTiet(int ID_QuyetDinh, int ID_NhaCungCap)
        {
            //if (fgQD.Row < fgQD.Rows.Fixed)
            //{
            //    return;
            //}
            var fg = fgChiTiet;
            fg.Tag = 0;
            fg.BeginUpdate();
            int iSTT = 1;
            fg.Rows.Count = fg.Rows.Fixed;
            if (ID_QuyetDinh != 0) //Xem/Sua
            {
                clsQD_NhapVatTu_ChiTiet cls = new clsQD_NhapVatTu_ChiTiet();
                Byte byLoai = 0; //dang xem
                if (!btnSua.Visible)
                    byLoai = 1; //dang cap nhat
                DataTable dt = cls.Select_DS_VatTuVer2(ID_QuyetDinh, ID_NhaCungCap, byLoai);
                foreach (DataRow dr in dt.Rows)
                {
                    Row fgRow = fg.Rows.Add();
                    fgRow["STT"] = iSTT;
                    iSTT++;
                    fgRow["ID_QuyetDinh"] = dr["ID_QuyetDinh"];
                    fgRow["Chon"] = dr["Chon"];
                    fgRow["ID_VatTu"] = dr["ID_VatTu"];
                    fgRow["Ten_VatTu"] = dr["Ten_VatTu"];
                    fgRow["ID_Kho"] = dr["ID_Kho"];
                    fgRow["Ten_Kho"] = dr["Ten_Kho"];
                    fgRow["SoLuong"] = dr["SoLuong"];
                }
            }
            else //ID_QuyetDinh = 0, Them moi' QD
            {
                clsDM_VatTu cls = new clsDM_VatTu();
                DataTable dt = cls.SelectVatTuWithID_NhaCungCap(ID_NhaCungCap);
                foreach (DataRow dr in dt.Rows)
                {
                    Row fgRow = fg.Rows.Add();
                    fgRow["STT"] = iSTT;
                    iSTT++;
                    fgRow["Chon"] = false;
                    fgRow["ID_VatTu"] = dr["ID_VatTu"];
                    fgRow["Ten_VatTu"] = dr["Ten_VatTu"];
                    fgRow["ID_Kho"] = dr["ID_Kho"];
                    fgRow["Ten_Kho"] = dr["Ten_Kho"];
                }
            }
            //
            //Tao combobox chon. Kho 
            //
            //clsDM_Kho clsKho = new clsDM_Kho();
            //DataTable dtKho = clsKho.SelectAll();
            //dtKho.DefaultView.RowFilter = "TonTai = 1";
            //ListDictionary datamap = new ListDictionary();
            //for (int i = 0; i <= dtKho.DefaultView.ToTable().Rows.Count - 1; i++)
            //{
            //    datamap.Add(dtKho.Rows[i][0], dtKho.Rows[i][1]);
            //}
            //fg.Cols["ID_Kho"].DataMap = datamap;
            //
            //
            fg.Row = -1;
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
        }
        #endregion Load

        /// <summary>
        /// LockEdit
        /// </summary>
        /// <param name="isLock"></param>
        #region LockEdit
        private void LockEdit(bool isLock)
        {
            gbThongTinQD.Enabled = !isLock;
            fgQD.Enabled = isLock;

            btnThemMoi.Visible = isLock;
            btnSua.Visible = isLock;
            btnXoa.Visible = isLock;
            btnHuyDuyet.Visible = isLock;
            btnPheDuyet.Visible = isLock;
            btnTrinhDuyet.Visible = isLock;

            btnLuu.Visible = !isLock;
            btnHuy.Visible = !isLock;
        }
        private void LockEditfgChiTiet(bool isLock)
        {
            fgChiTiet.AllowEditing = !isLock;
            fgChiTiet.Cols["Chon"].Visible = !isLock;
        }
        #endregion LockEdit

        /// <summary>
        /// Phe duyet, trinh duyet, huy duyet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region Duyet
        private void btnTrinhDuyet_Click(object sender, EventArgs e)
        {
            Duyet("Bạn có chắc chắn muốn trình duyệt?", 1, "Trình duyệt thành công!");
        }
        private void btnPheDuyet_Click(object sender, EventArgs e)
        {
            Duyet("Bạn có chắc chắn muốn phê duyệt?", 5, "Phê duyệt thành công!");
        }
        private void btnHuyDuyet_Click(object sender, EventArgs e)
        {
            Duyet("Bạn có chắc chắn muốn hủy duyệt?", 3, "Hủy duyệt thành công!");
        }
        private void Duyet(string question, byte trangthai, string message)
        {
            if (fgQD.Row < fgQD.Rows.Fixed)
            {
                BaseMessages.ShowInformationMessage("Chưa chọn quyết định.");
                return;
            }
            if (MessageBox.Show(question, "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.No) return;

            int fgRow = fgQD.Row;
            byte previousTrangThai = Convert.ToByte(fgQD[fgQD.Row,"TrangThai"]);

            clsQD_NhapVatTu cls = new clsQD_NhapVatTu();
            cls.ID_QuyetDinh = int.Parse(fgQD.GetDataDisplay(fgQD.Row, "ID_QuyetDinh"));
            cls.SelectOne();
            cls.TrangThai = trangthai;
            cls.Update();
            BaseMessages.ShowInformationMessage(message);
            if (trangthai == 1)
            {
                fgQD[fgQD.Row, "Ten_TrangThai"] = "Trình duyệt";
                fgQD[fgQD.Row, "TrangThai"] = 1;
                fgQD.Rows[fgQD.Row].Style = cs2;
            }
            else if (trangthai == 3)
            {
                fgQD[fgQD.Row, "Ten_TrangThai"] = "Hủy duyệt";
                fgQD[fgQD.Row, "TrangThai"] = 3;
                fgQD.Rows[fgQD.Row].Style = cs3;
                CapNhatSLVatTuKhoVer2(Convert.ToInt32(fgQD.GetDataDisplay(fgQD.Row, "ID_QuyetDinh")), 3);
            }
            else if (trangthai == 5)
            {
                fgQD[fgQD.Row, "Ten_TrangThai"] = "Phê duyệt";
                fgQD[fgQD.Row, "TrangThai"] = 5;
                fgQD.Rows[fgQD.Row].Style = cs4;
                
            }
            else if (trangthai == 6)
            {
                fgQD[fgQD.Row, "Ten_TrangThai"] = "Ghi thẻ kho";
                fgQD[fgQD.Row, "TrangThai"] = 6;
                fgQD.Rows[fgQD.Row].Style = cs5;
                CapNhatSLVatTuKhoVer2(Convert.ToInt32(fgQD.GetDataDisplay(fgQD.Row, "ID_QuyetDinh")), 6);
            }
            LockEdit(true);
            Lock(false, false, false, false, false,false);
            fgQD.Row = -1;

            ResetTextboxs();
            fgChiTiet.Rows.Count = fgChiTiet.Rows.Fixed;
            //focus
            fgQD.Row = fgRow;
        }

        //Cach 2
        private void CapNhatSLVatTuKhoVer2(int ID_QuyetDinh, byte trangthai)
        {
            clsKho_VatTu clsKVT = new clsKho_VatTu();
            clsKVT.Update_SoLuong(ID_QuyetDinh, trangthai);
        }
        
        //Cach 1
        private void CapNhatSLVatTuKhoVer1(int ID_QuyetDinh, byte trangthai)
        {
            clsQD_NhapVatTu_ChiTiet clsChiTiet = new clsQD_NhapVatTu_ChiTiet();
            clsKho_VatTu clsKVT = new clsKho_VatTu();
            DataTable dt = clsChiTiet.SelectAllW_ID_QuyetDinh(ID_QuyetDinh);
            foreach (DataRow dr in dt.Rows)
            {
                clsKVT.ID_Kho = Convert.ToInt32(dr["ID_Kho"]);
                clsKVT.ID_VatTu = Convert.ToInt32(dr["ID_VatTu"]);
                bool bInsert = clsKVT.SelectOne().Rows.Count == 0;

                if (trangthai == 5)
                {
                    if (bInsert)
                    {
                        clsKVT.SoLuong = Convert.ToInt32(dr["SoLuong"]);
                        clsKVT.Insert();
                    }
                    else
                    {
                        clsKVT.SoLuong = clsKVT.SoLuong + Convert.ToInt32(dr["SoLuong"]);
                        clsKVT.Update();
                    }
                }
                else if (trangthai == 3)
                {
                    clsKVT.SoLuong = clsKVT.SoLuong - Convert.ToInt32(dr["SoLuong"]);
                    clsKVT.Update();
                }
            }
        }
        //Cach 3
        private void CapNhatSLVatTuKhoVer3(int ID_QuyetDinh, byte trangthai)
        {
            clsQD_NhapVatTu_ChiTiet clsChiTiet = new clsQD_NhapVatTu_ChiTiet();
            clsKho_VatTu clsKVT = new clsKho_VatTu();

            DataTable dt = clsChiTiet.SelectAllW_ID_QuyetDinh(ID_QuyetDinh);
            foreach (DataRow dr in dt.Rows)
            {
                if (trangthai == 5)
                {
                    clsKVT.Update_SoLuongVer3(Convert.ToInt32(dr["ID_Kho"]), Convert.ToInt32(dr["ID_VatTu"]), Convert.ToInt32(dr["SoLuong"]));
                }
                else if (trangthai == 3)
                {
                    clsKVT.Update_SoLuongVer3(Convert.ToInt32(dr["ID_Kho"]), Convert.ToInt32(dr["ID_VatTu"]),(-1) * Convert.ToInt32(dr["SoLuong"]));
                }
            }
        }

        #endregion Duyet

        /// <summary>
        /// Them, sua, xoa quyet dinh, chi tiet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region ThemSuaXoaLuuHuy
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            m_blFlag = true;
            ResetTextboxs();
            txtSoQuyetDinh.Focus();
            LockEdit(false);
            LockEditfgChiTiet(false);
            fgChiTiet.Rows.Count = fgChiTiet.Rows.Fixed;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (fgQD.Row < fgQD.Rows.Fixed)
            {
                BaseMessages.ShowInformationMessage("Chưa chọn quyết định.");
                return;
            }
            if (BaseMessages.ShowDeleteQuestionMessage() == DialogResult.No) return;

            clsQD_NhapVatTu cls = new clsQD_NhapVatTu();
            cls.ID_QuyetDinh = int.Parse(fgQD.GetDataDisplay(fgQD.Row, "ID_QuyetDinh"));
            cls.SelectOne();
            cls.TonTai = false;
            cls.Update();
            BaseMessages.ShowInformationMessage("Xóa thành công!");

            LockEdit(true);
            Loadfg();

            ResetTextboxs();
            fgChiTiet.Rows.Count = fgChiTiet.Rows.Fixed;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (fgQD.Row < 0)
            {
                BaseMessages.ShowInformationMessage("Chưa chọn quyết định.");
                return;
            }
            m_blFlag = false;
            LockEdit(false);
            LockEditfgChiTiet(false);
            LoadfgChiTiet(int.Parse(fgQD.GetDataDisplay(fgQD.Row, "ID_QuyetDinh")),int.Parse(fgQD.GetDataDisplay(fgQD.Row, "ID_NhaCungCap")));
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            int fgRow = fgQD.Row;
            if (BaseMessages.ShowUndoQuestionMessage() == DialogResult.No) return;
            LockEdit(true);
            LockEditfgChiTiet(true);
            Loadfg();

            ResetTextboxs();
            fgChiTiet.Rows.Count = fgChiTiet.Rows.Fixed;

            fgQD.Row = fgRow;
        }

        private bool IsValid()
        {
            String soQuyetDinh = txtSoQuyetDinh.Text.Trim().ToLower();
            if (soQuyetDinh == "")
            {
                BaseMessages.ShowErrorMessage("Số QĐ không được rỗng!");
                return false;
            }
            if (int.Parse(cmbNhaCungCap.EditValue.ToString()) <= 0)
            {
                BaseMessages.ShowErrorMessage("Chưa chọn nhà cung cấp");
                return false;
            }
            for (int i = fgQD.Rows.Fixed; i < fgQD.Rows.Count; i++)
            {
                if (!m_blFlag && i == fgQD.Row) continue;
                if (fgQD.GetDataDisplay(i, "So_QuyetDinh").Trim().ToLower() == soQuyetDinh)
                {
                    BaseMessages.ShowErrorMessage("Số QĐ trùng với số QĐ dòng thứ " + i.ToString() + "!");
                    return false;
                }
            }
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int fgRow = 0;
            if (!IsValid() || !IsValidChiTiet()) return;

            clsQD_NhapVatTu cls = new clsQD_NhapVatTu();
            cls.So_QuyetDinh = txtSoQuyetDinh.Text.Trim();
            cls.Ngay_QuyetDinh = Convert.ToDateTime(dtmNgayQD.Value);
            cls.ID_NhaCungCap = int.Parse(cmbNhaCungCap.EditValue.ToString());
            SqlDateTime currentDateTime = (new clsFunctions()).SelectCurrentDateTime();
            cls.TonTai = true;

            if (m_blFlag) //Them moi' quyet dinh
            {
                cls.NgayLap = currentDateTime;
                cls.Ngay_SuaCuoi = currentDateTime;
                cls.TrangThai = 0;
                cls.Insert();
                SaveDataChiTiet(int.Parse(cls.ID_QuyetDinh.ToString()));
            }
            else //Sua quyet dinh
            {
                fgRow = fgQD.Row; //lưu lại vị trí dòng đang sửa
                cls.ID_QuyetDinh = Convert.ToInt32(fgQD.GetDataDisplay(fgQD.Row, "ID_QuyetDinh"));
                cls.Ngay_SuaCuoi = currentDateTime;
                cls.NgayLap = Convert.ToDateTime(fgQD.GetData(fgQD.Row, "NgayLap"));
                cls.TrangThai = Convert.ToByte(fgQD.GetDataDisplay(fgQD.Row, "TrangThai"));
                cls.Update();
                SaveDataChiTiet(int.Parse(cls.ID_QuyetDinh.ToString()));
            }

            BaseMessages.ShowInformationMessage("Cập nhật thành công!");
            LockEdit(true);
            LockEditfgChiTiet(true);
            Loadfg();

            ResetTextboxs();
            fgChiTiet.Rows.Count = fgChiTiet.Rows.Fixed;

            //option: focus vào dòng đã sửa
            if (!m_blFlag)
            {
                fgQD.Row = fgRow;
            }
        }

        private bool IsValidChiTiet()
        {
            //Check valid fg chi tiet
            for (int i = fgChiTiet.Rows.Fixed; i < fgChiTiet.Rows.Count; i++)
            {
                if (fgChiTiet.GetBoolValue(i, "Chon"))
                {
                    if (fgChiTiet.GetDataDisplay(i, "SoLuong") == "")
                    {
                        BaseMessages.ShowWarningMessage("Chưa nhập số lượng cho chi tiết tại dòng thứ " + i.ToString());
                        return false;
                    }
                    if (fgChiTiet.GetIntValue(i, "ID_Kho") == 0)
                    {
                        BaseMessages.ShowWarningMessage("Chưa chọn kho cho chi tiết tại dòng thứ " + i.ToString());
                        return false;
                    }
                }
            }
            return true;
        }
        private void SaveDataChiTiet(int ID_QuyetDinh)
        {
            //Save data chi tiet
            clsQD_NhapVatTu_ChiTiet clsChiTiet = new clsQD_NhapVatTu_ChiTiet();
            clsChiTiet.ID_QuyetDinh = Convert.ToInt32(ID_QuyetDinh);
            clsChiTiet.DeleteWID_QuyetDinhLogic();
            for (int i = fgChiTiet.Rows.Fixed; i < fgChiTiet.Rows.Count; i++)
            {
                if (fgChiTiet.GetBoolValue(i, "Chon"))
                {
                    clsChiTiet.ID_VatTu = fgChiTiet.GetIntValue(i, "ID_VatTu");
                    clsChiTiet.ID_Kho = fgChiTiet.GetIntValue(i, "ID_Kho");
                    clsChiTiet.SoLuong = fgChiTiet.GetIntValue(i, "SoLuong");
                    clsChiTiet.Insert();
                }
            }
        }
        #endregion ThemSuaXoaLuuHuy

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGhiTheKho_Click(object sender, EventArgs e)
        {
            if (fgQD.Row < 0)
            {
                BaseMessages.ShowInformationMessage("Chưa chọn quyết định.");
                return;
            }
            if (int.Parse(fgQD[fgQD.Row, "TrangThai"].ToString()) == 5)
            {
                clsTheKho cls = new clsTheKho();
                cls.ID_PhieuNhap = Convert.ToInt32(fgQD.GetDataDisplay(fgQD.Row, "ID_QuyetDinh"));
                cls.TonTai = true;
                for (int i = fgChiTiet.Rows.Fixed; i < fgChiTiet.Rows.Count; i++)
                {
                    if (fgChiTiet.GetBoolValue(i, "Chon"))
                    {
                        cls.ID_VatTu = fgChiTiet.GetIntValue(i, "ID_VatTu");
                        cls.ID_Kho = fgChiTiet.GetIntValue(i, "ID_Kho");
                        cls.SoLuong_BanDau = cls.SoLuong_HienTai = fgChiTiet.GetIntValue(i, "SoLuong");
                        cls.Insert();
                    }
                    
                }
                
                Duyet("Bạn có chắc chắn muốn ghi thẻ kho?", 6, "Ghi thành công!");
                //BaseMessages.ShowInformationMessage("Cập nhật thành công!");
                Loadfg();
            }
            else
            {
                BaseMessages.ShowWarningMessage("Phiếu chưa được phê duyệt");
                return;
            }
        }

        //private void ThemMoiOrUpdate()
        //{
        //    clsKho_VatTu clss = new clsKho_VatTu();
        //    DataTable dt = clss.SelectAll();
        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        for (int j = fgChiTiet.Rows.Fixed; j < fgChiTiet.Rows.Count; j++)
        //        {
        //            if (fgChiTiet.GetBoolValue(j, "Chon"))
        //            {
        //                if (fgChiTiet[j, "ID_Kho"] == dr["ID_Kho"] && fgChiTiet[j, "ID_Vattu"] == dr["ID_Vattu"])
        //                {
        //                    clss.Update();
        //                }
        //                else
        //                    clss.Insert();
        //            }
        //        }
        //    }
            
        //}

       
    }
}
