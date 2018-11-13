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
using System.Collections.Specialized;

namespace QLKho
{
    public partial class frmQD_NhapVatTu_ChiTiet : Form
    {
        private int m_iID_QuyetDinh, m_iID_NhaCungCap;
        private byte m_byTrangthai;
        public frmQD_NhapVatTu_ChiTiet(int ID_QuyetDinh, int ID_NhaCungCap, byte trangthai)
        {
            InitializeComponent();
            this.m_iID_QuyetDinh = ID_QuyetDinh;
            this.m_iID_NhaCungCap = ID_NhaCungCap;
            this.m_byTrangthai = trangthai;
        }

        private void frmQD_NhapVatTu_ChiTiet_Load(object sender, EventArgs e)
        {
            LockEdit(true);
            Loadfg();
        }

        private void Loadfg()
        {
            fg.Tag = 0;
            fg.BeginUpdate();
            clsQD_NhapVatTu_ChiTiet cls = new clsQD_NhapVatTu_ChiTiet();
            Byte loai = 0; //dang xem
            if (!btnCapNhat.Visible) loai = 1; //dang cap nhat
            if (m_byTrangthai == 1 || m_byTrangthai == 5) loai = 0;
            int iSTT = 1;
            fg.Rows.Count = fg.Rows.Fixed;
            DataTable dt = cls.Select_DS_VatTu(m_iID_QuyetDinh, m_iID_NhaCungCap, loai);
            foreach (DataRow dr in dt.DefaultView.ToTable().Rows)
            {
                Row fgRow = fg.Rows.Add();
                fgRow["STT"] = iSTT;
                iSTT++;
                fgRow["ID_QuyetDinh"] = dr["ID_QuyetDinh"];
                fgRow["Chon"] = dr["Chon"];
                fgRow["ID_VatTu"] = dr["ID_VatTu"];
                fgRow["Ten_VatTu"] = dr["Ten_VatTu"];
                fgRow["ID_Kho"] = dr["ID_Kho"];
                fgRow["SoLuong"] = dr["SoLuong"];
            }

            clsDM_Kho clsKho = new clsDM_Kho();
            DataTable dtKho = clsKho.SelectAll();
            dtKho.DefaultView.RowFilter = "TonTai = 1";
            ListDictionary datamap = new ListDictionary();
            for (int i = 0; i <= dtKho.DefaultView.ToTable().Rows.Count - 1; i++)
            {
                datamap.Add(dtKho.Rows[i][0], dtKho.Rows[i][1]);
            }
            fg.Cols["ID_Kho"].DataMap = datamap;

            fg.Row = -1;
            fg.AutoSizeRows();
            fg.AutoSizeCols();
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void LockEdit(bool p)
        {
            if (m_byTrangthai == 0 || m_byTrangthai == 3)
            {
                btnCapNhat.Visible = p;
                btnHuy.Visible = !p;
                btnLuu.Visible = !p;

                fg.AllowEditing = !p;
                fg.Cols["Chon"].Visible = !p;
            }
            else
            {
                btnCapNhat.Visible = false;
                btnHuy.Visible = false;
                btnLuu.Visible = false;

                fg.AllowEditing = false;
                fg.Cols["Chon"].Visible = false;
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LockEdit(false);
            Loadfg();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (BaseMessages.ShowUndoQuestionMessage() == DialogResult.No) return;
            LockEdit(true);
            Loadfg();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsValid()
        {
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.GetBoolValue(i, "Chon"))
                {
                    if (fg.GetDataDisplay(i, "SoLuong") == "")
                    {
                        BaseMessages.ShowWarningMessage("Chưa nhập số lượng tại dòng thứ " + i.ToString());
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            clsQD_NhapVatTu_ChiTiet cls = new clsQD_NhapVatTu_ChiTiet();
            cls.ID_QuyetDinh = m_iID_QuyetDinh;
            cls.DeleteWID_QuyetDinhLogic();
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.GetBoolValue(i, "Chon"))
                {
                    cls.ID_VatTu = fg.GetIntValue(i, "ID_VatTu");
                    cls.ID_Kho = fg.GetIntValue(i, "ID_Kho");
                    cls.SoLuong = fg.GetIntValue(i, "SoLuong");
                    cls.Insert();
                }
            }
            BaseMessages.ShowInformationMessage("Cập nhật thành công!");
            LockEdit(true);
            Loadfg();
        }


    }
}
