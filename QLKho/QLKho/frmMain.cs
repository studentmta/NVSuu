using QLKho;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLKho
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
        }
        private Form IsActive(Type type)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == type)
                    return f;
            }
            return null;
        }
        private void navQuyetDinh_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = IsActive(typeof(frmQD_NhapVatTu));
            if (frm == null)
            {
                frmQD_NhapVatTu f = new frmQD_NhapVatTu();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
            else
                frm.Activate();
        }

        private void navKhoVatTu_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = IsActive(typeof(frmKho_VatTu));
            if (frm == null)
            {
                frmKho_VatTu f = new frmKho_VatTu();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
            else
                frm.Activate();
        
        }

        private void vatTuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_VatTu frm = new frmDM_VatTu();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void khoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_Kho frm = new frmDM_Kho();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void nhaCungCapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDM_NhaCungCap frm = new frmDM_NhaCungCap();
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();
        }

        private void navQuyetDinhXuat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = IsActive(typeof(frmQD_XuatVatTu));
            if (frm == null)
            {
                frmQD_XuatVatTu f = new frmQD_XuatVatTu();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
            else
                frm.Activate();
        }

        private void navTonKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            Form frm = IsActive(typeof(frmTonKho));
            if (frm == null)
            {
                frmTonKho f = new frmTonKho();
                f.MdiParent = this;
                f.WindowState = FormWindowState.Maximized;
                f.Show();
            }
            else
                frm.Activate();
        }

    }
}
