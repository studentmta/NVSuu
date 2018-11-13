using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using QLKho;
using VSCM.Base.Utils;

namespace QLKho
{
    public partial class frmDM_NhaCungCap : Form
    {
        public frmDM_NhaCungCap()
        {
            InitializeComponent();
        }
        private void FrmDM_NhaCungCap_Load(object sender, EventArgs e)
        {
            LockEdit(true);
            Loadfg();
        }
        private void Loadfg()
        {
            fg.Tag = 0;
            fg.BeginUpdate();
            clsDM_NhaCungCap cls = new clsDM_NhaCungCap();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai = 1";
            int iSTT = 1;
            int i = fg.Rows.Fixed;
            fg.Rows.Count = fg.Rows.Fixed;
            foreach (DataRow dr in dt.DefaultView.ToTable().Rows)
            {
                fg.Rows.Add();
                fg[i, "STT"] = iSTT;
                iSTT++;
                fg[i, "ID_NhaCungCap"] = dr["ID_NhaCungCap"];
                fg[i, "Ten_NhaCungCap"] = dr["Ten_NhaCungCap"];
                fg[i, "DiaChi"] = dr["DiaChi"];
                fg[i, "Email"] = dr["Email"];
                fg[i, "SoDienThoai"] = dr["SoDienThoai"];
                fg[i, "SuDung"] = dr["SuDung"];
                fg[i, "TonTai"] = dr["TonTai"];
                i++;
            }

            fg.Row = -1;
            fg.AutoSizeRows();
            fg.EndUpdate();
            fg.Tag = 1;
        }
        private void LockEdit(bool p)
        {
            btnCapNhat.Visible = p;
            btnHuy.Visible = !p;
            btnLuu.Visible = !p;

            lblHuongDan.Visible = !p;
            fg.AllowEditing = !p;
        }

        private void fg_KeyUp(object sender, KeyEventArgs e)
        {
            if (btnCapNhat.Visible) return;
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    fg.Rows.Add();
                    fg.Rows[fg.Rows.Count - 1]["IsEdit"] = "1";
                    fg.SetSTT();
                    break;
                case Keys.Delete:
                    if (fg.Row < fg.Rows.Fixed)
                    {
                        BaseMessages.ShowInformationMessage("Chưa chọn nhà cung cấp.");
                        return;
                    }
                    if (fg.GetDataDisplay(fg.Row, "ID_NhaCungCap") == "")
                        fg.Rows.Remove(fg.Row);
                    else
                    {
                        fg.Rows[fg.Row]["IsEdit"] = "0";
                        fg.Rows[fg.Row].Visible = false;
                    }
                    fg.SetSTT();
                    break;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (BaseMessages.ShowUndoQuestionMessage() == DialogResult.No) return;
            LockEdit(true);
            Loadfg();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!IsValid()) return;
            SaveData();
            LockEdit(true);
            Loadfg();
        }

        private bool IsValid()
        {
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (!fg.Rows[i].Visible) continue; //TonTai = false
                String Ten_NhaCungCap = fg.GetDataDisplay(i, "Ten_NhaCungCap").ToLower().Trim();
                if (Ten_NhaCungCap == "")
                {
                    BaseMessages.ShowErrorMessage("Chưa nhập tên nhà cung cấp dòng thứ " + i.ToString() + ".");
                    return false;
                }
                for (int j = i + 1; j < fg.Rows.Count; j++)
                {
                    if (!fg.Rows[j].Visible) continue;
                    if (fg.GetDataDisplay(j, "Ten_NhaCungCap").ToLower().Trim() != Ten_NhaCungCap) continue;
                    BaseMessages.ShowErrorMessage("Tên nhà cung cấp dòng thứ " + i.ToString() + " và dòng thứ " + j.ToString() + " trùng nhau!");
                    return false;
                }
            }
            return true;
        }

        private void SaveData()
        {
            clsDM_NhaCungCap cls = new clsDM_NhaCungCap();
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.GetDataDisplay(i, "IsEdit").ToLower() == "") continue;
                cls.Ten_NhaCungCap = fg.GetDataDisplay(i, "Ten_NhaCungCap");
                cls.DiaChi = fg.GetDataDisplay(i, "DiaChi");
                cls.Email = fg.GetDataDisplay(i, "Email");
                cls.SoDienThoai = fg.GetDataDisplay(i, "SoDienThoai");
                cls.SuDung = fg.GetBoolValue(i, "SuDung");
                //delete
                if (fg.GetDataDisplay(i, "IsEdit") == "0")
                {
                    cls.ID_NhaCungCap = int.Parse(fg.GetDataDisplay(i, "ID_NhaCungCap"));
                    cls.TonTai = false;
                    cls.Update();
                }
                else if (fg.GetDataDisplay(i, "IsEdit") == "1")
                {
                    cls.TonTai = true;
                    if (fg.GetDataDisplay(i, "ID_NhaCungCap") == "")
                    {
                        cls.Insert();
                    }
                    else
                    {
                        cls.ID_NhaCungCap = int.Parse(fg.GetDataDisplay(i, "ID_NhaCungCap"));
                        cls.Update();
                    }
                }
            }
            BaseMessages.ShowInformationMessage("Cập nhật thành công!");
        }

        private void fg_AfterEdit(object sender, C1.Win.C1FlexGrid.RowColEventArgs e)
        {
            fg[e.Row, "IsEdit"] = "1";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LockEdit(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            var searchString = txtTimKiem.Text.Trim().ToLower();
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if ((fg.GetDataDisplay(i, "IsEdit") != "") || (fg.GetDataDisplay(i, "Ten_NhaCungCap").Trim().ToLower().Contains(searchString)))
                {
                    fg.Rows[i].Visible = true;
                }
                else
                {
                    fg.Rows[i].Visible = false;
                }
            }
        }
    }
}
