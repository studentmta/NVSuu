using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VSCM.Base.Utils;
using System.Collections.Specialized;

namespace QLKho
{
    public partial class frmKho_VatTu : Form
    {
        private bool m_bFlag = true;
        public frmKho_VatTu()
        {
            InitializeComponent();
        }

        private void frmKho_VatTu_Load(object sender, EventArgs e)
        {
            LockEdit(true);
            Load_cmbKho();
            Loadfg();
        }

        private void LockEdit(bool IsLock)
        {
            btnCapNhat.Visible = IsLock;
            btnXuatKho.Visible = IsLock;
            btnHuy.Visible = !IsLock;
            btnLuu.Visible = !IsLock;

            fg.AllowEditing = !IsLock;
            fg.Cols["Chon"].Visible = !IsLock;

            cmbKho.Enabled = IsLock;
        }

        private void Loadfg()
        {
            fg.Tag = 0;
            fg.BeginUpdate();
            clsKho_VatTu cls = new clsKho_VatTu();
            Byte loai = 0; //dang xem
            if (!btnCapNhat.Visible) loai = 1; //dang cap nhat
            DataTable dt = cls.SelectDS_VatTu(int.Parse(cmbKho.GetValue("ID_Kho")), loai);
            int iSTT = 1;
            int i = fg.Rows.Fixed;
            fg.Rows.Count = fg.Rows.Fixed;
            foreach (DataRow dr in dt.DefaultView.ToTable().Rows)
            {
                fg.Rows.Add();
                fg[i, "STT"] = iSTT;
                iSTT++;
                fg[i, "Chon"] = dr["Chon"];
                fg[i, "ID_Kho"] = dr["ID_Kho"];
                fg[i, "Ten_Kho"] = dr["Ten_Kho"];
                fg[i, "ID_VatTu"] = dr["ID_VatTu"];
                fg[i, "Ten_VatTu"] = dr["Ten_VatTu"];
                fg[i, "SoLuong"] = dr["SoLuong"];
                i++;
            }
            fg.Row = -1;
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
        }

        private void Load_cmbKho()
        {
            var cmb = cmbKho;
            cmb.Tag = 0;
            clsDM_Kho cls = new clsDM_Kho();
            DataTable dt = cls.SelectAll();
            if (dt.Rows.Count > 0)
            {
                dt.Rows.Add(0, "Tất cả", 1, 1);
            }
            dt.DefaultView.RowFilter = "TonTai = 1";
            dt.DefaultView.Sort = "ID_Kho ASC";
            cmb.Properties.DataSource = dt;
            cmb.Properties.DisplayMember = "Ten_Kho";
            cmb.Properties.ValueMember = "ID_Kho";
            cmb.EditValue = 0;
            cmb.Tag = 1;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (BaseMessages.ShowUndoQuestionMessage() == DialogResult.No) return;
            LockEdit(true);
            fg.Cols["SoLuongXuat"].Visible = false;
            fg.Cols["ID_KhoXuat"].Visible = false;
            Loadfg();
            cmbKho.EditValue = 0;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (int.Parse(cmbKho.EditValue.ToString()) == 0)
            {
                BaseMessages.ShowWarningMessage("Chọn kho để cập nhật");
                return;
            }
            m_bFlag = true;

            LockEdit(false);
            Loadfg();
        }

        private void cmbKho_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbKho.Properties.GetIndexByKeyValue(cmbKho.EditValue) < 0) return;
            Loadfg();
            if (cmbKho.EditValue + "" == "0")
            {
                fg.Filter("ID_Kho", "");
                fg.Cols["Ten_Kho"].Visible = true;
                return;
            }
            fg.Filter("ID_Kho", cmbKho.EditValue + "");
            fg.Cols["Ten_Kho"].Visible = false;
            fg.SetSTT();
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
            if (m_bFlag)
            {
                if (!IsValid()) return;

                clsKho_VatTu cls = new clsKho_VatTu();
                cls.ID_Kho = int.Parse("0" + cmbKho.EditValue);
                cls.DeleteWID_KhoLogic();

                for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
                {
                    if (fg.GetBoolValue(i, "Chon"))
                    {
                        cls.ID_VatTu = fg.GetIntValue(i, "ID_VatTu");
                        cls.SoLuong = fg.GetIntValue(i, "SoLuong");
                        cls.Insert();
                    }
                }
                BaseMessages.ShowInformationMessage("Cập nhật thành công!");
                LockEdit(true);
                Loadfg();
                fg.Filter("Ten_Kho", cmbKho.GetValue("Ten_Kho"));
                fg.SetSTT();
            }
            else
            {
                if (!IsValidXuatKho()) return;
                clsKho_VatTu cls = new clsKho_VatTu();
                for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
                {
                    if (fg.GetBoolValue(i, "Chon"))
                    {
                        //Xuat Kho
                        cls.Xuat_Kho(Convert.ToInt32(fg[i, "ID_Kho"]), Convert.ToInt32(fg[i, "ID_VatTu"]),
                        Convert.ToInt32(fg[i,"SoLuongXuat"]), Convert.ToInt32(fg[i,"ID_KhoXuat"]));
                    }
                }
                BaseMessages.ShowInformationMessage("Cập nhật thành công!");
                LockEdit(true);
                LockEditXuatKho(true);

                Loadfg();
                fg.Filter("Ten_Kho", cmbKho.GetValue("Ten_Kho"));
                fg.SetSTT();
            }
        }

        private void LockEditXuatKho(bool IsLock)
        {
            fg.Cols["SoLuong"].AllowEditing = IsLock;
            fg.Cols["SoLuongXuat"].Visible = !IsLock;
            fg.Cols["ID_KhoXuat"].Visible = !IsLock;
        }

        private bool IsValidXuatKho()
        {
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.GetBoolValue(i, "Chon"))
                {
                    if (fg.GetDataDisplay(i, "SoLuongXuat") == "")
                    {
                        BaseMessages.ShowWarningMessage("Chưa nhập số lượng xuất tại dòng thứ " + i.ToString());
                        return false;
                    }
                    if ((fg.GetDataDisplay(i, "SoLuongXuat") != "") && (Convert.ToInt32(fg[i,"SoLuongXuat"]) > Convert.ToInt32(fg[i,"SoLuong"])))
                    {
                        BaseMessages.ShowWarningMessage("Số lượng xuất tại dòng thứ " + i.ToString() + " không được lớn hơn " + fg[i, "SoLuong"].ToString());
                        return false;
                    }
                    if (fg.GetIntValue(i, "ID_KhoXuat") == 0)
                    {
                        BaseMessages.ShowWarningMessage("Chưa chọn kho xuất tại dòng thứ " + i.ToString());
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnXuatKho_Click(object sender, EventArgs e)
        {
            if (int.Parse(cmbKho.EditValue.ToString()) == 0)
            {
                BaseMessages.ShowWarningMessage("Chọn kho để xuất kho");
                return;
            }
            m_bFlag = false;

            LockEdit(false);
            LockEditXuatKho(false);

            //Loadfg
            fg.BeginUpdate();
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                fg.Rows[i]["Chon"] = false;
            }

            clsDM_Kho clsKho = new clsDM_Kho();
            DataTable dtKho = clsKho.SelectAll();
            dtKho.DefaultView.RowFilter = "ID_Kho <> " + cmbKho.EditValue.ToString() +" AND TonTai = 1";
            dtKho = dtKho.DefaultView.ToTable();
            ListDictionary datamap = new ListDictionary();
            for (int i = 0; i <= dtKho.Rows.Count - 1; i++)
            {
                datamap.Add(dtKho.Rows[i][0], dtKho.Rows[i][1]);
            }
            fg.Cols["ID_KhoXuat"].DataMap = datamap;

            fg.Row = -1;
            fg.AutoSizeRows();
            fg.EndUpdate();
        }
    }
}
