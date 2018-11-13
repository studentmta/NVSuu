namespace QLKho
{
    partial class frmQD_NhapVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQD_NhapVatTu));
            this.gbQD = new VSCM.Base.Controls.ucGroupBox();
            this.txtTimKiem = new VSCM.Base.Controls.ucTextBox();
            this.ucButton1 = new VSCM.Base.Controls.ucButton();
            this.fgQD = new VSCM.Base.Controls.ucFlexGrid();
            this.gbThongTinQD = new VSCM.Base.Controls.ucGroupBox();
            this.cmbNhaCungCap = new VSCM.Base.Controls.ucSearchLookupEdit();
            this.ucSearchLookupEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dtmNgayQD = new VSCM.Base.Controls.ucDateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSoQuyetDinh = new VSCM.Base.Controls.ucTextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new VSCM.Base.Controls.ucButton();
            this.btnLuu = new VSCM.Base.Controls.ucButton();
            this.btnTrinhDuyet = new VSCM.Base.Controls.ucButton();
            this.btnPheDuyet = new VSCM.Base.Controls.ucButton();
            this.btnThemMoi = new VSCM.Base.Controls.ucButton();
            this.btnHuyDuyet = new VSCM.Base.Controls.ucButton();
            this.btnXoa = new VSCM.Base.Controls.ucButton();
            this.btnSua = new VSCM.Base.Controls.ucButton();
            this.btnThoat = new VSCM.Base.Controls.ucButton();
            this.gbChiTietQD = new VSCM.Base.Controls.ucGroupBox();
            this.txtTimKiemChiTiet = new VSCM.Base.Controls.ucTextBox();
            this.btnTimKiemChiTiet = new VSCM.Base.Controls.ucButton();
            this.fgChiTiet = new VSCM.Base.Controls.ucFlexGrid();
            this.btnGhiTheKho = new VSCM.Base.Controls.ucButton();
            this.gbQD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgQD)).BeginInit();
            this.gbThongTinQD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhaCungCap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmNgayQD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoQuyetDinh.Properties)).BeginInit();
            this.gbChiTietQD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemChiTiet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // gbQD
            // 
            this.gbQD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbQD.Controls.Add(this.txtTimKiem);
            this.gbQD.Controls.Add(this.ucButton1);
            this.gbQD.Controls.Add(this.fgQD);
            this.gbQD.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbQD.Location = new System.Drawing.Point(8, 11);
            this.gbQD.Margin = new System.Windows.Forms.Padding(2);
            this.gbQD.Name = "gbQD";
            this.gbQD.Padding = new System.Windows.Forms.Padding(2);
            this.gbQD.Size = new System.Drawing.Size(705, 365);
            this.gbQD.TabIndex = 0;
            this.gbQD.TabStop = false;
            this.gbQD.Text = "Quyết định nhập vật tư";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.FieldGroup = "";
            this.txtTimKiem.FieldName = "";
            this.txtTimKiem.Location = new System.Drawing.Point(3, 15);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Properties.AutoHeight = false;
            this.txtTimKiem.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtTimKiem.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtTimKiem.Properties.Name = "fProperties";
            this.txtTimKiem.Properties.NullValuePrompt = "Nhập thông tin tìm kiếm";
            this.txtTimKiem.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTimKiem.Size = new System.Drawing.Size(221, 30);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.EditValueChanged += new System.EventHandler(this.txtTimKiem_EditValueChanged);
            // 
            // ucButton1
            // 
            this.ucButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucButton1.Appearance.Options.UseFont = true;
            this.ucButton1.Image = global::QLKho.Properties.Resources.ico_Search;
            this.ucButton1.Location = new System.Drawing.Point(227, 15);
            this.ucButton1.Name = "ucButton1";
            this.ucButton1.Size = new System.Drawing.Size(20, 19);
            this.ucButton1.TabIndex = 4;
            // 
            // fgQD
            // 
            this.fgQD.AllowEditing = false;
            this.fgQD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fgQD.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgQD.ColumnInfo = resources.GetString("fgQD.ColumnInfo");
            this.fgQD.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgQD.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgQD.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgQD.Location = new System.Drawing.Point(2, 43);
            this.fgQD.Margin = new System.Windows.Forms.Padding(2);
            this.fgQD.Name = "fgQD";
            this.fgQD.Rows.Count = 1;
            this.fgQD.Rows.DefaultSize = 18;
            this.fgQD.Rows.MinSize = 21;
            this.fgQD.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgQD.Size = new System.Drawing.Size(699, 322);
            this.fgQD.StyleInfo = resources.GetString("fgQD.StyleInfo");
            this.fgQD.TabIndex = 0;
            this.fgQD.AfterRowChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.fg_AfterRowChange);
            // 
            // gbThongTinQD
            // 
            this.gbThongTinQD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbThongTinQD.Controls.Add(this.cmbNhaCungCap);
            this.gbThongTinQD.Controls.Add(this.dtmNgayQD);
            this.gbThongTinQD.Controls.Add(this.labelControl3);
            this.gbThongTinQD.Controls.Add(this.labelControl2);
            this.gbThongTinQD.Controls.Add(this.txtSoQuyetDinh);
            this.gbThongTinQD.Controls.Add(this.labelControl1);
            this.gbThongTinQD.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbThongTinQD.Location = new System.Drawing.Point(10, 380);
            this.gbThongTinQD.Margin = new System.Windows.Forms.Padding(2);
            this.gbThongTinQD.Name = "gbThongTinQD";
            this.gbThongTinQD.Padding = new System.Windows.Forms.Padding(2);
            this.gbThongTinQD.Size = new System.Drawing.Size(703, 104);
            this.gbThongTinQD.TabIndex = 1;
            this.gbThongTinQD.TabStop = false;
            this.gbThongTinQD.Text = "Thông tin quyết định";
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.FieldGroup = "";
            this.cmbNhaCungCap.FieldName = "";
            this.cmbNhaCungCap.Location = new System.Drawing.Point(405, 23);
            this.cmbNhaCungCap.Margin = new System.Windows.Forms.Padding(2);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Properties.AutoHeight = false;
            this.cmbNhaCungCap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbNhaCungCap.Properties.DisplayMember = "Ten_NhaCungCap";
            this.cmbNhaCungCap.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.cmbNhaCungCap.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.cmbNhaCungCap.Properties.NullText = "";
            this.cmbNhaCungCap.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cmbNhaCungCap.Properties.ValueMember = "ID_NhaCungCap";
            this.cmbNhaCungCap.Properties.View = this.ucSearchLookupEdit1View;
            this.cmbNhaCungCap.Size = new System.Drawing.Size(197, 30);
            this.cmbNhaCungCap.TabIndex = 2;
            this.cmbNhaCungCap.EditValueChanged += new System.EventHandler(this.cmbNhaCungCap_EditValueChanged);
            // 
            // ucSearchLookupEdit1View
            // 
            this.ucSearchLookupEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.ucSearchLookupEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ucSearchLookupEdit1View.Name = "ucSearchLookupEdit1View";
            this.ucSearchLookupEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ucSearchLookupEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID_NhaCungCap";
            this.gridColumn1.FieldName = "ID_NhaCungCap";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Nhà cung cấp";
            this.gridColumn2.FieldName = "Ten_NhaCungCap";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // dtmNgayQD
            // 
            this.dtmNgayQD.AutoSize = false;
            this.dtmNgayQD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            // 
            // 
            // 
            this.dtmNgayQD.Calendar.BackColor = System.Drawing.SystemColors.Window;
            this.dtmNgayQD.Calendar.DayNameLength = 1;
            this.dtmNgayQD.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayQD.DisplayFormat.EmptyAsNull = true;
            this.dtmNgayQD.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtmNgayQD.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtmNgayQD.EditFormat.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayQD.EditFormat.EmptyAsNull = true;
            this.dtmNgayQD.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtmNgayQD.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtmNgayQD.FieldGroup = "";
            this.dtmNgayQD.FieldName = "";
            this.dtmNgayQD.Location = new System.Drawing.Point(113, 53);
            this.dtmNgayQD.Margin = new System.Windows.Forms.Padding(2);
            this.dtmNgayQD.Name = "dtmNgayQD";
            this.dtmNgayQD.Size = new System.Drawing.Size(197, 19);
            this.dtmNgayQD.TabIndex = 3;
            this.dtmNgayQD.Tag = null;
            this.dtmNgayQD.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(27, 55);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Ngày quyết định:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(337, 26);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Nhà cung cấp";
            // 
            // txtSoQuyetDinh
            // 
            this.txtSoQuyetDinh.FieldGroup = "";
            this.txtSoQuyetDinh.FieldName = "";
            this.txtSoQuyetDinh.Location = new System.Drawing.Point(113, 23);
            this.txtSoQuyetDinh.Margin = new System.Windows.Forms.Padding(2);
            this.txtSoQuyetDinh.Name = "txtSoQuyetDinh";
            this.txtSoQuyetDinh.Properties.AutoHeight = false;
            this.txtSoQuyetDinh.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtSoQuyetDinh.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtSoQuyetDinh.Properties.Mask.EditMask = "n0";
            this.txtSoQuyetDinh.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoQuyetDinh.Properties.Name = "fProperties";
            this.txtSoQuyetDinh.Size = new System.Drawing.Size(197, 30);
            this.txtSoQuyetDinh.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 26);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Số quyết định: ";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::QLKho.Properties.Resources.ico_Back;
            this.btnHuy.Location = new System.Drawing.Point(117, 489);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 29);
            this.btnHuy.TabIndex = 0;
            this.btnHuy.Tag = "0";
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.Visible = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::QLKho.Properties.Resources.ico_Save;
            this.btnLuu.Location = new System.Drawing.Point(14, 489);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 29);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Tag = "0";
            this.btnLuu.Text = "&Lưu lại";
            this.btnLuu.Visible = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnTrinhDuyet
            // 
            this.btnTrinhDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrinhDuyet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrinhDuyet.Appearance.Options.UseFont = true;
            this.btnTrinhDuyet.Image = global::QLKho.Properties.Resources.ico_Forward;
            this.btnTrinhDuyet.Location = new System.Drawing.Point(327, 489);
            this.btnTrinhDuyet.Name = "btnTrinhDuyet";
            this.btnTrinhDuyet.Size = new System.Drawing.Size(98, 29);
            this.btnTrinhDuyet.TabIndex = 5;
            this.btnTrinhDuyet.Tag = "0";
            this.btnTrinhDuyet.Text = "Trình &Duyệt";
            this.btnTrinhDuyet.Click += new System.EventHandler(this.btnTrinhDuyet_Click);
            // 
            // btnPheDuyet
            // 
            this.btnPheDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPheDuyet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPheDuyet.Appearance.Options.UseFont = true;
            this.btnPheDuyet.Image = global::QLKho.Properties.Resources.ico_Check;
            this.btnPheDuyet.Location = new System.Drawing.Point(433, 489);
            this.btnPheDuyet.Name = "btnPheDuyet";
            this.btnPheDuyet.Size = new System.Drawing.Size(98, 29);
            this.btnPheDuyet.TabIndex = 6;
            this.btnPheDuyet.Tag = "0";
            this.btnPheDuyet.Text = "&Phê Duyệt";
            this.btnPheDuyet.Click += new System.EventHandler(this.btnPheDuyet_Click);
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThemMoi.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.Appearance.Options.UseFont = true;
            this.btnThemMoi.Image = global::QLKho.Properties.Resources.ico_Add;
            this.btnThemMoi.Location = new System.Drawing.Point(14, 489);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(98, 29);
            this.btnThemMoi.TabIndex = 2;
            this.btnThemMoi.Tag = "0";
            this.btnThemMoi.Text = "&Thêm mới";
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // btnHuyDuyet
            // 
            this.btnHuyDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuyDuyet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDuyet.Appearance.Options.UseFont = true;
            this.btnHuyDuyet.Image = global::QLKho.Properties.Resources.ico_Abort;
            this.btnHuyDuyet.Location = new System.Drawing.Point(539, 489);
            this.btnHuyDuyet.Name = "btnHuyDuyet";
            this.btnHuyDuyet.Size = new System.Drawing.Size(98, 29);
            this.btnHuyDuyet.TabIndex = 7;
            this.btnHuyDuyet.Tag = "0";
            this.btnHuyDuyet.Text = "Hủ&y Duyệt";
            this.btnHuyDuyet.Click += new System.EventHandler(this.btnHuyDuyet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = global::QLKho.Properties.Resources.ico_Delete;
            this.btnXoa.Location = new System.Drawing.Point(221, 489);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 29);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Tag = "0";
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = global::QLKho.Properties.Resources.ico_Edit;
            this.btnSua.Location = new System.Drawing.Point(117, 489);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 29);
            this.btnSua.TabIndex = 3;
            this.btnSua.Tag = "0";
            this.btnSua.Text = "&Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThoat.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Appearance.Options.UseFont = true;
            this.btnThoat.Image = global::QLKho.Properties.Resources.ico_Exit;
            this.btnThoat.Location = new System.Drawing.Point(996, 489);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 26);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Tag = "0";
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // gbChiTietQD
            // 
            this.gbChiTietQD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbChiTietQD.Controls.Add(this.txtTimKiemChiTiet);
            this.gbChiTietQD.Controls.Add(this.btnTimKiemChiTiet);
            this.gbChiTietQD.Controls.Add(this.fgChiTiet);
            this.gbChiTietQD.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbChiTietQD.Location = new System.Drawing.Point(719, 11);
            this.gbChiTietQD.Margin = new System.Windows.Forms.Padding(2);
            this.gbChiTietQD.Name = "gbChiTietQD";
            this.gbChiTietQD.Padding = new System.Windows.Forms.Padding(2);
            this.gbChiTietQD.Size = new System.Drawing.Size(379, 386);
            this.gbChiTietQD.TabIndex = 8;
            this.gbChiTietQD.TabStop = false;
            this.gbChiTietQD.Text = "Chi tiết quyết định";
            // 
            // txtTimKiemChiTiet
            // 
            this.txtTimKiemChiTiet.FieldGroup = "";
            this.txtTimKiemChiTiet.FieldName = "";
            this.txtTimKiemChiTiet.Location = new System.Drawing.Point(5, 18);
            this.txtTimKiemChiTiet.Name = "txtTimKiemChiTiet";
            this.txtTimKiemChiTiet.Properties.AutoHeight = false;
            this.txtTimKiemChiTiet.Properties.LookAndFeel.SkinName = "Office 2010 Silver";
            this.txtTimKiemChiTiet.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.txtTimKiemChiTiet.Properties.Name = "fProperties";
            this.txtTimKiemChiTiet.Properties.NullValuePrompt = "Nhập thông tin tìm kiếm";
            this.txtTimKiemChiTiet.Properties.NullValuePromptShowForEmptyValue = true;
            this.txtTimKiemChiTiet.Size = new System.Drawing.Size(221, 30);
            this.txtTimKiemChiTiet.TabIndex = 1;
            this.txtTimKiemChiTiet.EditValueChanged += new System.EventHandler(this.txtTimKiemChiTiet_EditValueChanged);
            // 
            // btnTimKiemChiTiet
            // 
            this.btnTimKiemChiTiet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemChiTiet.Appearance.Options.UseFont = true;
            this.btnTimKiemChiTiet.Image = global::QLKho.Properties.Resources.ico_Search;
            this.btnTimKiemChiTiet.Location = new System.Drawing.Point(232, 18);
            this.btnTimKiemChiTiet.Name = "btnTimKiemChiTiet";
            this.btnTimKiemChiTiet.Size = new System.Drawing.Size(20, 19);
            this.btnTimKiemChiTiet.TabIndex = 2;
            // 
            // fgChiTiet
            // 
            this.fgChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fgChiTiet.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgChiTiet.ColumnInfo = resources.GetString("fgChiTiet.ColumnInfo");
            this.fgChiTiet.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgChiTiet.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgChiTiet.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgChiTiet.Location = new System.Drawing.Point(4, 43);
            this.fgChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.fgChiTiet.Name = "fgChiTiet";
            this.fgChiTiet.Rows.Count = 1;
            this.fgChiTiet.Rows.DefaultSize = 18;
            this.fgChiTiet.Rows.MinSize = 21;
            this.fgChiTiet.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgChiTiet.Size = new System.Drawing.Size(372, 340);
            this.fgChiTiet.StyleInfo = resources.GetString("fgChiTiet.StyleInfo");
            this.fgChiTiet.TabIndex = 0;
            // 
            // btnGhiTheKho
            // 
            this.btnGhiTheKho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGhiTheKho.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiTheKho.Appearance.Options.UseFont = true;
            this.btnGhiTheKho.Image = global::QLKho.Properties.Resources.ico_Save;
            this.btnGhiTheKho.Location = new System.Drawing.Point(643, 489);
            this.btnGhiTheKho.Name = "btnGhiTheKho";
            this.btnGhiTheKho.Size = new System.Drawing.Size(98, 29);
            this.btnGhiTheKho.TabIndex = 10;
            this.btnGhiTheKho.Tag = "0";
            this.btnGhiTheKho.Text = "&Ghi Thẻ Kho";
            this.btnGhiTheKho.Click += new System.EventHandler(this.btnGhiTheKho_Click);
            // 
            // frmQD_NhapVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 523);
            this.Controls.Add(this.gbChiTietQD);
            this.Controls.Add(this.btnGhiTheKho);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.gbThongTinQD);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTrinhDuyet);
            this.Controls.Add(this.btnPheDuyet);
            this.Controls.Add(this.btnThemMoi);
            this.Controls.Add(this.btnHuyDuyet);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.gbQD);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQD_NhapVatTu";
            this.Text = "Quyết định nhập vật tư";
            this.Load += new System.EventHandler(this.frmQD_NhapVatTu_Load);
            this.gbQD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgQD)).EndInit();
            this.gbThongTinQD.ResumeLayout(false);
            this.gbThongTinQD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbNhaCungCap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucSearchLookupEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtmNgayQD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoQuyetDinh.Properties)).EndInit();
            this.gbChiTietQD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTimKiemChiTiet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucGroupBox gbQD;
        private VSCM.Base.Controls.ucFlexGrid fgQD;
        private VSCM.Base.Controls.ucButton btnHuy;
        private VSCM.Base.Controls.ucButton btnLuu;
        private VSCM.Base.Controls.ucButton btnTrinhDuyet;
        private VSCM.Base.Controls.ucButton btnPheDuyet;
        private VSCM.Base.Controls.ucButton btnThemMoi;
        private VSCM.Base.Controls.ucButton btnHuyDuyet;
        private VSCM.Base.Controls.ucButton btnXoa;
        private VSCM.Base.Controls.ucButton btnSua;
        private VSCM.Base.Controls.ucGroupBox gbThongTinQD;
        private VSCM.Base.Controls.ucDateEdit dtmNgayQD;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private VSCM.Base.Controls.ucTextBox txtSoQuyetDinh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private VSCM.Base.Controls.ucSearchLookupEdit cmbNhaCungCap;
        private DevExpress.XtraGrid.Views.Grid.GridView ucSearchLookupEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private VSCM.Base.Controls.ucButton btnThoat;
        private VSCM.Base.Controls.ucGroupBox gbChiTietQD;
        private VSCM.Base.Controls.ucTextBox txtTimKiemChiTiet;
        private VSCM.Base.Controls.ucButton btnTimKiemChiTiet;
        private VSCM.Base.Controls.ucFlexGrid fgChiTiet;
        private VSCM.Base.Controls.ucButton btnGhiTheKho;
        private VSCM.Base.Controls.ucTextBox txtTimKiem;
        private VSCM.Base.Controls.ucButton ucButton1;
    }
}