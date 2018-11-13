namespace QLKho
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.vatTuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaCungCapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTuyChon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navNghiepVu = new DevExpress.XtraNavBar.NavBarGroup();
            this.navDSVatTu = new DevExpress.XtraNavBar.NavBarItem();
            this.navKhoVatTu = new DevExpress.XtraNavBar.NavBarItem();
            this.navQuyetDinh = new DevExpress.XtraNavBar.NavBarItem();
            this.navQuyetDinhXuat = new DevExpress.XtraNavBar.NavBarItem();
            this.navTonKho = new DevExpress.XtraNavBar.NavBarItem();
            this.navBaoCaoDSHocSinh = new DevExpress.XtraNavBar.NavBarGroup();
            this.quảnLýNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtNgườiDùngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHeThong,
            this.mnuDanhMuc,
            this.mnuTuyChon,
            this.mnuHuongDan});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            this.mnuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýNgườiDùngToolStripMenuItem,
            this.toolStripSeparator1,
            this.chiTiếtNgườiDùngToolStripMenuItem,
            this.toolStripSeparator2,
            this.đổiMậtKhẩuToolStripMenuItem,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.đăngXuấtToolStripMenuItem,
            this.toolStripSeparator5,
            this.thoátToolStripMenuItem});
            this.mnuHeThong.Name = "mnuHeThong";
            this.mnuHeThong.Size = new System.Drawing.Size(69, 20);
            this.mnuHeThong.Text = "&Hệ thống";
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vatTuToolStripMenuItem,
            this.khoToolStripMenuItem,
            this.nhaCungCapToolStripMenuItem});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.Size = new System.Drawing.Size(77, 20);
            this.mnuDanhMuc.Text = "&Danh mục ";
            // 
            // vatTuToolStripMenuItem
            // 
            this.vatTuToolStripMenuItem.Name = "vatTuToolStripMenuItem";
            this.vatTuToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.vatTuToolStripMenuItem.Text = "Vật tư";
            this.vatTuToolStripMenuItem.Click += new System.EventHandler(this.vatTuToolStripMenuItem_Click);
            // 
            // khoToolStripMenuItem
            // 
            this.khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            this.khoToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.khoToolStripMenuItem.Text = "Kho";
            this.khoToolStripMenuItem.Click += new System.EventHandler(this.khoToolStripMenuItem_Click);
            // 
            // nhaCungCapToolStripMenuItem
            // 
            this.nhaCungCapToolStripMenuItem.Name = "nhaCungCapToolStripMenuItem";
            this.nhaCungCapToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.nhaCungCapToolStripMenuItem.Text = "Nhà cung cấp";
            this.nhaCungCapToolStripMenuItem.Click += new System.EventHandler(this.nhaCungCapToolStripMenuItem_Click);
            // 
            // mnuTuyChon
            // 
            this.mnuTuyChon.Name = "mnuTuyChon";
            this.mnuTuyChon.Size = new System.Drawing.Size(71, 20);
            this.mnuTuyChon.Text = "&Tùy Chọn";
            // 
            // mnuHuongDan
            // 
            this.mnuHuongDan.Name = "mnuHuongDan";
            this.mnuHuongDan.Size = new System.Drawing.Size(79, 20);
            this.mnuHuongDan.Text = "&Hướng dẫn";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navNghiepVu;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navNghiepVu,
            this.navBaoCaoDSHocSinh});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navDSVatTu,
            this.navKhoVatTu,
            this.navQuyetDinh,
            this.navQuyetDinhXuat,
            this.navTonKho});
            this.navBarControl1.Location = new System.Drawing.Point(0, 24);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 177;
            this.navBarControl1.Size = new System.Drawing.Size(177, 350);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navNghiepVu
            // 
            this.navNghiepVu.Caption = "Nghiệp vụ";
            this.navNghiepVu.Expanded = true;
            this.navNghiepVu.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navDSVatTu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navKhoVatTu),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navQuyetDinh),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navQuyetDinhXuat),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navTonKho)});
            this.navNghiepVu.Name = "navNghiepVu";
            // 
            // navDSVatTu
            // 
            this.navDSVatTu.Caption = "Danh sách vật tư";
            this.navDSVatTu.Name = "navDSVatTu";
            // 
            // navKhoVatTu
            // 
            this.navKhoVatTu.Caption = "Kho vật tư";
            this.navKhoVatTu.Name = "navKhoVatTu";
            this.navKhoVatTu.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navKhoVatTu_LinkClicked);
            // 
            // navQuyetDinh
            // 
            this.navQuyetDinh.Caption = "Phiếu nhập";
            this.navQuyetDinh.Name = "navQuyetDinh";
            this.navQuyetDinh.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navQuyetDinh_LinkClicked);
            // 
            // navQuyetDinhXuat
            // 
            this.navQuyetDinhXuat.Caption = "Phiếu xuất";
            this.navQuyetDinhXuat.Name = "navQuyetDinhXuat";
            this.navQuyetDinhXuat.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navQuyetDinhXuat_LinkClicked);
            // 
            // navTonKho
            // 
            this.navTonKho.Caption = "Số lượng trong kho";
            this.navTonKho.Name = "navTonKho";
            this.navTonKho.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navTonKho_LinkClicked);
            // 
            // navBaoCaoDSHocSinh
            // 
            this.navBaoCaoDSHocSinh.Caption = "Báo Cáo";
            this.navBaoCaoDSHocSinh.Expanded = true;
            this.navBaoCaoDSHocSinh.Name = "navBaoCaoDSHocSinh";
            // 
            // quảnLýNgườiDùngToolStripMenuItem
            // 
            this.quảnLýNgườiDùngToolStripMenuItem.Name = "quảnLýNgườiDùngToolStripMenuItem";
            this.quảnLýNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quảnLýNgườiDùngToolStripMenuItem.Text = "Quản lý người dùng";
            // 
            // chiTiếtNgườiDùngToolStripMenuItem
            // 
            this.chiTiếtNgườiDùngToolStripMenuItem.Name = "chiTiếtNgườiDùngToolStripMenuItem";
            this.chiTiếtNgườiDùngToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.chiTiếtNgườiDùngToolStripMenuItem.Text = "Chi tiết người dùng";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 374);
            this.Controls.Add(this.navBarControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHeThong;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuTuyChon;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDan;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navNghiepVu;
        private DevExpress.XtraNavBar.NavBarGroup navBaoCaoDSHocSinh;
        private DevExpress.XtraNavBar.NavBarItem navDSVatTu;
        private DevExpress.XtraNavBar.NavBarItem navKhoVatTu;
        private DevExpress.XtraNavBar.NavBarItem navQuyetDinh;
        private System.Windows.Forms.ToolStripMenuItem vatTuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhaCungCapToolStripMenuItem;
        private DevExpress.XtraNavBar.NavBarItem navQuyetDinhXuat;
        private DevExpress.XtraNavBar.NavBarItem navTonKho;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtNgườiDùngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

