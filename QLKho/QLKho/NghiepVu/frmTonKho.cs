using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VSCM.Base;
using VSCM.Base.Utils;
using C1.Win.C1FlexGrid;

namespace QLKho
{
    public partial class frmTonKho : Form
    {
        #region Variables

        private CellStyle cs;

        #endregion

        #region Constructor

        public frmTonKho()
        {
            InitializeComponent();
            InitCellStyles();
        }
        private void InitCellStyles()
        {
            cs = fgVatTu.Styles.Add("Tổng");
            cs = fgChiTiet.Styles.Add("Tổng");
            cs.BackColor = Color.Orange;
        }

        #endregion

        #region Func/Sub

        private void LoadKho()
        {
            clsDM_Kho cls = new clsDM_Kho();
            DataTable dt = cls.SelectAll();
            dt.DefaultView.RowFilter = "TonTai = 1";
            dt.DefaultView.Sort = "ID_Kho ASC";
            cboKho.Properties.DataSource = dt;
            cboKho.Properties.DisplayMember = "Ten_Kho";
            cboKho.Properties.ValueMember = "ID_Kho";
        }

        #endregion

        #region Events

        private void frmTonKho_Load(object sender, EventArgs e)
        {
            LoadKho();
        }
        private void DeleteRowFgChiTiet()
        {
            for (int i = fgChiTiet.Rows.Fixed; i < fgChiTiet.Rows.Count; i++)
            {
                fgChiTiet.Rows[i].Clear(ClearFlags.All);
            }
            fgChiTiet.Rows.Count = fgChiTiet.Rows.Fixed;
        }
        private void cboKho_EditValueChanged(object sender, EventArgs e)
        {
            fgVatTu.Tag = 0;
            fgVatTu.BeginUpdate();
            clsKho_VatTu cls = new clsKho_VatTu();
            DataTable dt = cls.TonKho_WT_CboTonKho((int)cboKho.EditValue);
            fgVatTu.Rows.Count = fgVatTu.Rows.Fixed + 1;
            fgVatTu[fgVatTu.Rows.Count - 1, "Ten_VatTu"] = "Tổng";
            fgVatTu.Rows[fgVatTu.Rows.Count - 1].Style = cs;

            int iSTT = 0;
            int sumN = 0;
            int sumX = 0;
            int sumT = 0;
            foreach (DataRow dr in dt.DefaultView.ToTable().Rows)
            {
                Row fgRow = fgVatTu.Rows.Add();
                iSTT++;
                fgRow["STT"] = iSTT;
                fgRow["ID_VatTu"] = dr["ID_VatTu"];
                fgRow["Ten_VatTu"] = dr["Ten_VatTu"];
                fgRow["SoLuongNhap"] = dr["SoLuongNhap"];
                fgRow["SoLuongXuat"] = dr["SoLuongXuat"];
                fgRow["SoLuongTon"] = (int)fgRow["SoLuongNhap"] - (int)fgRow["SoLuongXuat"];
                sumN += int.Parse(fgRow["SoLuongNhap"].ToString());
                sumX += int.Parse(fgRow["SoLuongXuat"].ToString());
                sumT += int.Parse(fgRow["SoLuongTon"].ToString());
            }
            fgVatTu[fgVatTu.Rows.Fixed, "SoLuongNhap"] = sumN;
            fgVatTu[fgVatTu.Rows.Fixed, "SoLuongXuat"] = sumX;
            fgVatTu[fgVatTu.Rows.Fixed, "SoLuongTon"] = sumT;
            fgVatTu.Row = -1;
            fgVatTu.AutoSizeRows();
            DeleteRowFgChiTiet();
            fgVatTu.EndUpdate();
            fgVatTu.Tag = 1;
        }
        private void fgVatTu_Click(object sender, EventArgs e)
        {
            if (fgVatTu.Tag + "" == "0" || fgVatTu.Row <= 1)
            {
                return;
            }

            fgChiTiet.Tag = 0;
            fgChiTiet.BeginUpdate();
            clsKho_VatTu cls = new clsKho_VatTu();
            DataTable dt = cls.Select_TheKho_WT_VatTu_PN((int)cboKho.EditValue, int.Parse(fgVatTu[fgVatTu.Row, "ID_VatTu"].ToString()));
            int iSTT = 0;
            int sumPN = 0;
            int sumPX = 0;
            fgChiTiet.Rows.Count = fgChiTiet.Rows.Fixed + 1;
            fgChiTiet[fgChiTiet.Rows.Count - 1, "SoPhieu"] = "Tổng";
            fgChiTiet.Rows[fgChiTiet.Rows.Count - 1].Style = cs;
            foreach (DataRow dr in dt.DefaultView.ToTable().Rows)
            {
                Row fgRow = fgChiTiet.Rows.Add();
                iSTT++;
                fgRow["STT"] = iSTT;
                //fgRow["icon"] = Image.FromFile(@"D:\TTH\Project QLVatTu Mau\QLKho\QLKho\Resources\ico_forward.png");
                fgChiTiet.SetCellImage(int.Parse(fgChiTiet.Rows.Count.ToString()) - 1, 2, Image.FromFile(@"D:\Ki7\T4-TKGD&CNLTTH\Project QLVatTu Mau\QLKho\QLKho\Resources\ico_forward.png"));
                fgRow["SoPhieu"] = dr["So_QuyetDinh"];
                fgRow["SoLuongNhap"] = dr["SoLuong"];
                sumPN += int.Parse(fgRow["SoLuongNhap"].ToString());
            }
            fgChiTiet[fgChiTiet.Rows.Fixed, "SoLuongNhap"] = sumPN;
            DataTable dtt = cls.Select_TheKho_WT_VatTu_PX((int)cboKho.EditValue, int.Parse(fgVatTu[fgVatTu.Row, "ID_VatTu"].ToString()));


            foreach (DataRow dr in dtt.DefaultView.ToTable().Rows)
            {
                Row fgRow = fgChiTiet.Rows.Add();
                iSTT++;
                fgChiTiet.SetCellImage(int.Parse(fgChiTiet.Rows.Count.ToString()) - 1, 2, Image.FromFile(@"D:\Ki7\T4-TKGD&CNLTTH\Project QLVatTu Mau\QLKho\QLKho\Resources\ico_Back.png"));
                fgRow["STT"] = iSTT;
                fgRow["SoPhieu"] = dr["So_PhieuXuat"];
                fgRow["SoLuongXuat"] = dr["SoLuong"];
                sumPX += int.Parse(fgRow["SoLuongXuat"].ToString());

            }
            fgChiTiet[fgChiTiet.Rows.Fixed, "SoLuongXuat"] = sumPX;
            fgChiTiet.Row = -1;
            fgVatTu.AutoSizeRows();
            fgChiTiet.EndUpdate();
            fgChiTiet.Tag = 1;
        }

        #endregion
        
    }
}
