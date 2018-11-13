using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using C1.Win.C1FlexGrid;
using System.Collections.Specialized;
using VSCM.Base.Utils;

namespace QLKho
{
    public partial class frmDM_VatTu : Form
    {
        public frmDM_VatTu()
        {
            InitializeComponent();
        }

        private void frmDM_VatTu_Load(object sender, EventArgs e)
        {
            LockEdit(true);
            Loadfg();
        }
        private void Loadfg()
        {
            fg.Tag = 0;
            fg.BeginUpdate();
            clsDM_VatTu cls = new clsDM_VatTu();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai = 1";
            dt.DefaultView.Sort = "ID_NhaCungCap ASC";
            int iSTT = 1;
            fg.Rows.Count = fg.Rows.Fixed;
            foreach (DataRow dr in dt.DefaultView.ToTable().Rows)
            {
                Row fgRow = fg.Rows.Add();
                fgRow["STT"] = iSTT;
                iSTT++;
                fgRow["ID_VatTu"] = dr["ID_VatTu"];
                fgRow["Ten_VatTu"] = dr["Ten_VatTu"];
                fgRow["ID_NhaCungCap"] = dr["ID_NhaCungCap"];
                fgRow["SuDung"] = dr["SuDung"];
                fgRow["TonTai"] = dr["TonTai"];
            }

            clsDM_NhaCungCap clsNCC = new clsDM_NhaCungCap();
            dt = clsNCC.SelectAll();
            dt.DefaultView.RowFilter = "TonTai = 1";
            ListDictionary dataMap = new ListDictionary();
            for (int i = 0; i < dt.DefaultView.ToTable().Rows.Count; i++)
            {
                dataMap.Add(dt.Rows[i][0], dt.Rows[i][1]);
            }
            fg.Cols["ID_NhaCungCap"].DataMap = dataMap;

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


        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (BaseMessages.ShowUndoQuestionMessage() == DialogResult.No) return;
            LockEdit(true);
            Loadfg();
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
                        BaseMessages.ShowInformationMessage("Chưa chọn vật tư.");
                        return;
                    }
                    if (fg.GetDataDisplay(fg.Row, "ID_VatTu") == "")
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

        private void fg_AfterEdit(object sender, RowColEventArgs e)
        {
            fg[e.Row, "IsEdit"] = "1";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            LockEdit(false);
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
                if (!fg.Rows[i].Visible) continue; //Tontai = 0
                String Ten_VatTu = fg.GetDataDisplay(i, "Ten_VatTu").ToLower().Trim();
                if (Ten_VatTu == "")
                {
                    BaseMessages.ShowErrorMessage("Chưa nhập tên vật tư dòng thứ " + i.ToString() + ".");
                    return false;
                }

                if (fg.GetIntValue(i, "ID_NhaCungCap") == 0)
                {
                    BaseMessages.ShowErrorMessage("Chưa chọn nhà cung cấp dòng thứ " + i.ToString() + ".");
                    return false;
                }

                for (int j = i + 1; j < fg.Rows.Count; j++)
                {
                    if (!fg.Rows[j].Visible) continue;
                    if (fg.GetDataDisplay(j, "Ten_VatTu").ToLower().Trim() != Ten_VatTu) continue;
                    BaseMessages.ShowErrorMessage("Tên vật tư dòng thứ " + i.ToString() + " và dòng thứ " + j.ToString() + " trùng nhau!");
                    return false;
                }
            }
            return true;
        }

        private void SaveData()
        {
            clsDM_VatTu cls = new clsDM_VatTu();
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if (fg.GetDataDisplay(i, "IsEdit").ToLower() == "") continue;
                cls.Ten_VatTu = fg.GetDataDisplay(i, "Ten_VatTu");
                cls.ID_NhaCungCap = fg.GetIntValue(i, "ID_NhaCungCap");
                cls.SuDung = fg.GetBoolValue(i, "SuDung");
                //delete
                if (fg.GetDataDisplay(i, "IsEdit") == "0")
                {
                    cls.ID_VatTu = int.Parse(fg.GetDataDisplay(i, "ID_VatTu"));
                    cls.TonTai = false;
                    cls.Update();
                }
                else if (fg.GetDataDisplay(i, "IsEdit") == "1")
                {
                    cls.TonTai = true;
                    if (fg.GetDataDisplay(i, "ID_VatTu") == "")
                    {
                        cls.Insert();
                    }
                    else
                    {
                        cls.ID_VatTu = int.Parse(fg.GetDataDisplay(i, "ID_VatTu"));
                        cls.Update();
                    }
                }
            }
            BaseMessages.ShowInformationMessage("Cập nhật thành công!");
        }

        private void txtTimKiem_EditValueChanged(object sender, EventArgs e)
        {
            var searchString = txtTimKiem.Text.Trim().ToLower();
            for (int i = fg.Rows.Fixed; i < fg.Rows.Count; i++)
            {
                if ((fg.GetDataDisplay(i, "IsEdit") != "") || (fg.GetDataDisplay(i, "Ten_VatTu").Trim().ToLower().Contains(searchString)))
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
