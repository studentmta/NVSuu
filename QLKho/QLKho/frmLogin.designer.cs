namespace Garco10.Login
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.chkInternet = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMC_MatKhau = new System.Windows.Forms.TextBox();
            this.txtMC_TenServer = new System.Windows.Forms.TextBox();
            this.txtMC_TenDangNhap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PicPassword = new System.Windows.Forms.PictureBox();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdThuNho = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.txtND_MatKhau = new System.Windows.Forms.TextBox();
            this.txtND_TenDangNhap = new System.Windows.Forms.TextBox();
            this.cmdMoRong = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtNgayLV = new System.Windows.Forms.TextBox();
            this.cmdHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 33);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "TỔNG CÔNG TY MAY 10";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(165, 78);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(55, 13);
            this.Label3.TabIndex = 42;
            this.Label3.Text = "Mật khẩu:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.Color.Transparent;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(123, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(97, 13);
            this.Label2.TabIndex = 41;
            this.Label2.Text = "Tên người dùng:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GroupBox1.Controls.Add(this.chkInternet);
            this.GroupBox1.Controls.Add(this.label8);
            this.GroupBox1.Controls.Add(this.txtMC_MatKhau);
            this.GroupBox1.Controls.Add(this.txtMC_TenServer);
            this.GroupBox1.Controls.Add(this.txtMC_TenDangNhap);
            this.GroupBox1.Controls.Add(this.label5);
            this.GroupBox1.Controls.Add(this.label6);
            this.GroupBox1.Controls.Add(this.label7);
            this.GroupBox1.Controls.Add(this.PicPassword);
            this.GroupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(4, 185);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(415, 130);
            this.GroupBox1.TabIndex = 47;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Thông tin đăng nhập máy chủ dữ liệu";
            // 
            // chkInternet
            // 
            this.chkInternet.AutoSize = true;
            this.chkInternet.Location = new System.Drawing.Point(219, 110);
            this.chkInternet.Name = "chkInternet";
            this.chkInternet.Size = new System.Drawing.Size(15, 14);
            this.chkInternet.TabIndex = 58;
            this.chkInternet.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(234, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 13);
            this.label8.TabIndex = 57;
            this.label8.Text = "Đăng nhập qua Internet";
            // 
            // txtMC_MatKhau
            // 
            this.txtMC_MatKhau.BackColor = System.Drawing.Color.White;
            this.txtMC_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMC_MatKhau.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMC_MatKhau.Location = new System.Drawing.Point(219, 80);
            this.txtMC_MatKhau.Name = "txtMC_MatKhau";
            this.txtMC_MatKhau.PasswordChar = '*';
            this.txtMC_MatKhau.Size = new System.Drawing.Size(185, 21);
            this.txtMC_MatKhau.TabIndex = 9;
            this.txtMC_MatKhau.TabStop = false;
            // 
            // txtMC_TenServer
            // 
            this.txtMC_TenServer.BackColor = System.Drawing.Color.White;
            this.txtMC_TenServer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMC_TenServer.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMC_TenServer.Location = new System.Drawing.Point(219, 20);
            this.txtMC_TenServer.Name = "txtMC_TenServer";
            this.txtMC_TenServer.Size = new System.Drawing.Size(185, 21);
            this.txtMC_TenServer.TabIndex = 7;
            this.txtMC_TenServer.TabStop = false;
            // 
            // txtMC_TenDangNhap
            // 
            this.txtMC_TenDangNhap.BackColor = System.Drawing.Color.White;
            this.txtMC_TenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMC_TenDangNhap.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMC_TenDangNhap.Location = new System.Drawing.Point(219, 50);
            this.txtMC_TenDangNhap.Name = "txtMC_TenDangNhap";
            this.txtMC_TenDangNhap.Size = new System.Drawing.Size(185, 21);
            this.txtMC_TenDangNhap.TabIndex = 8;
            this.txtMC_TenDangNhap.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Tên đăng nhập:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Tên máy chủ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "Mật khẩu:";
            // 
            // PicPassword
            // 
            this.PicPassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PicPassword.BackgroundImage")));
            this.PicPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PicPassword.Location = new System.Drawing.Point(6, 24);
            this.PicPassword.Name = "PicPassword";
            this.PicPassword.Size = new System.Drawing.Size(109, 75);
            this.PicPassword.TabIndex = 39;
            this.PicPassword.TabStop = false;
            this.PicPassword.Click += new System.EventHandler(this.PicPassword_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExit.Image = ((System.Drawing.Image)(resources.GetObject("cmdExit.Image")));
            this.cmdExit.Location = new System.Drawing.Point(322, 141);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(90, 29);
            this.cmdExit.TabIndex = 6;
            this.cmdExit.TabStop = false;
            this.cmdExit.Text = "   Thoát";
            this.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdThuNho
            // 
            this.cmdThuNho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdThuNho.Image = ((System.Drawing.Image)(resources.GetObject("cmdThuNho.Image")));
            this.cmdThuNho.Location = new System.Drawing.Point(231, 141);
            this.cmdThuNho.Name = "cmdThuNho";
            this.cmdThuNho.Size = new System.Drawing.Size(90, 29);
            this.cmdThuNho.TabIndex = 5;
            this.cmdThuNho.TabStop = false;
            this.cmdThuNho.Text = "   Thu gọn";
            this.cmdThuNho.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdThuNho.UseVisualStyleBackColor = true;
            this.cmdThuNho.Click += new System.EventHandler(this.cmdThuNho_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOK.Image = ((System.Drawing.Image)(resources.GetObject("cmdOK.Image")));
            this.cmdOK.Location = new System.Drawing.Point(140, 141);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(90, 29);
            this.cmdOK.TabIndex = 4;
            this.cmdOK.TabStop = false;
            this.cmdOK.Text = " Đăng nhập";
            this.cmdOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // txtND_MatKhau
            // 
            this.txtND_MatKhau.BackColor = System.Drawing.Color.White;
            this.txtND_MatKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtND_MatKhau.Location = new System.Drawing.Point(225, 75);
            this.txtND_MatKhau.Name = "txtND_MatKhau";
            this.txtND_MatKhau.PasswordChar = '*';
            this.txtND_MatKhau.Size = new System.Drawing.Size(185, 21);
            this.txtND_MatKhau.TabIndex = 1;
            // 
            // txtND_TenDangNhap
            // 
            this.txtND_TenDangNhap.BackColor = System.Drawing.Color.White;
            this.txtND_TenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtND_TenDangNhap.Location = new System.Drawing.Point(225, 45);
            this.txtND_TenDangNhap.Name = "txtND_TenDangNhap";
            this.txtND_TenDangNhap.Size = new System.Drawing.Size(185, 21);
            this.txtND_TenDangNhap.TabIndex = 0;
            // 
            // cmdMoRong
            // 
            this.cmdMoRong.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdMoRong.Image = ((System.Drawing.Image)(resources.GetObject("cmdMoRong.Image")));
            this.cmdMoRong.Location = new System.Drawing.Point(231, 141);
            this.cmdMoRong.Name = "cmdMoRong";
            this.cmdMoRong.Size = new System.Drawing.Size(90, 29);
            this.cmdMoRong.TabIndex = 7;
            this.cmdMoRong.TabStop = false;
            this.cmdMoRong.Text = "   Mở rộng";
            this.cmdMoRong.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdMoRong.UseVisualStyleBackColor = true;
            this.cmdMoRong.Click += new System.EventHandler(this.cmdMoRong_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.Color.Transparent;
            this.Label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(143, 108);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(77, 13);
            this.Label4.TabIndex = 43;
            this.Label4.Text = "Ngày làm việc:";
            // 
            // txtNgayLV
            // 
            this.txtNgayLV.BackColor = System.Drawing.Color.White;
            this.txtNgayLV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNgayLV.Location = new System.Drawing.Point(225, 105);
            this.txtNgayLV.Name = "txtNgayLV";
            this.txtNgayLV.ReadOnly = true;
            this.txtNgayLV.Size = new System.Drawing.Size(185, 21);
            this.txtNgayLV.TabIndex = 3;
            this.txtNgayLV.TabStop = false;
            // 
            // cmdHelp
            // 
            this.cmdHelp.BackColor = System.Drawing.SystemColors.Window;
            this.cmdHelp.FlatAppearance.BorderSize = 0;
            this.cmdHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdHelp.Image = ((System.Drawing.Image)(resources.GetObject("cmdHelp.Image")));
            this.cmdHelp.Location = new System.Drawing.Point(35, 142);
            this.cmdHelp.Name = "cmdHelp";
            this.cmdHelp.Size = new System.Drawing.Size(55, 28);
            this.cmdHelp.TabIndex = 56;
            this.cmdHelp.TabStop = false;
            this.cmdHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdHelp.UseVisualStyleBackColor = false;
            this.cmdHelp.Click += new System.EventHandler(this.cmdHelp_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.cmdOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 319);
            this.Controls.Add(this.cmdHelp);
            this.Controls.Add(this.txtNgayLV);
            this.Controls.Add(this.txtND_TenDangNhap);
            this.Controls.Add(this.txtND_MatKhau);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmdThuNho);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdMoRong);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.PictureBox PicPassword;
        internal System.Windows.Forms.Button cmdExit;
        internal System.Windows.Forms.Button cmdThuNho;
        internal System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.TextBox txtND_MatKhau;
        private System.Windows.Forms.TextBox txtND_TenDangNhap;
        private System.Windows.Forms.TextBox txtMC_MatKhau;
        private System.Windows.Forms.TextBox txtMC_TenServer;
        private System.Windows.Forms.TextBox txtMC_TenDangNhap;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button cmdMoRong;
        internal System.Windows.Forms.Label Label4;
        private System.Windows.Forms.TextBox txtNgayLV;
        internal System.Windows.Forms.Button cmdHelp;
        private System.Windows.Forms.CheckBox chkInternet;
        private System.Windows.Forms.Label label8;
    }
}

