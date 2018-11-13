namespace QLKho
{
    partial class frmQD_XuatVatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQD_XuatVatTu));
            this.gbQD = new VSCM.Base.Controls.ucGroupBox();
            this.fgQDX = new VSCM.Base.Controls.ucFlexGrid();
            this.gbChiTietQD = new VSCM.Base.Controls.ucGroupBox();
            this.fgChiTietXuat = new VSCM.Base.Controls.ucFlexGrid();
            this.cboNguoiLap = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboKhoXuat = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSoPhieuXuat = new DevExpress.XtraEditors.TextEdit();
            this.dtpNgayXuatKho = new C1.Win.C1Input.C1DateEdit();
            this.dtpNgayHachToanTo = new C1.Win.C1Input.C1DateEdit();
            this.dtpNgayHachToanFrom = new C1.Win.C1Input.C1DateEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGhiTheKho = new VSCM.Base.Controls.ucButton();
            this.btnHuyDuyet = new VSCM.Base.Controls.ucButton();
            this.btnPheDuyet = new VSCM.Base.Controls.ucButton();
            this.btnTrinhDuyet = new VSCM.Base.Controls.ucButton();
            this.btnXoa = new VSCM.Base.Controls.ucButton();
            this.btnThem = new VSCM.Base.Controls.ucButton();
            this.btnSua = new VSCM.Base.Controls.ucButton();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.cboTheKho = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gbQD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgQDX)).BeginInit();
            this.gbChiTietQD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgChiTietXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguoiLap.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieuXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayXuatKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayHachToanTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayHachToanFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTheKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // gbQD
            // 
            this.gbQD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbQD.Controls.Add(this.fgQDX);
            this.gbQD.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbQD.Location = new System.Drawing.Point(10, 57);
            this.gbQD.Margin = new System.Windows.Forms.Padding(2);
            this.gbQD.Name = "gbQD";
            this.gbQD.Padding = new System.Windows.Forms.Padding(2);
            this.gbQD.Size = new System.Drawing.Size(1125, 283);
            this.gbQD.TabIndex = 1;
            this.gbQD.TabStop = false;
            this.gbQD.Text = "Phiếu xuất";
            // 
            // fgQDX
            // 
            this.fgQDX.AllowEditing = false;
            this.fgQDX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fgQDX.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgQDX.ColumnInfo = resources.GetString("fgQDX.ColumnInfo");
            this.fgQDX.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgQDX.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgQDX.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgQDX.Location = new System.Drawing.Point(4, 17);
            this.fgQDX.Margin = new System.Windows.Forms.Padding(2);
            this.fgQDX.Name = "fgQDX";
            this.fgQDX.Rows.Count = 1;
            this.fgQDX.Rows.DefaultSize = 18;
            this.fgQDX.Rows.MinSize = 21;
            this.fgQDX.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgQDX.Size = new System.Drawing.Size(1115, 258);
            this.fgQDX.StyleInfo = resources.GetString("fgQDX.StyleInfo");
            this.fgQDX.TabIndex = 0;
            this.fgQDX.AfterRowChange += new C1.Win.C1FlexGrid.RangeEventHandler(this.fgQDX_AfterRowChange);
            this.fgQDX.DoubleClick += new System.EventHandler(this.fgQDX_DoubleClick);
            // 
            // gbChiTietQD
            // 
            this.gbChiTietQD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbChiTietQD.Controls.Add(this.fgChiTietXuat);
            this.gbChiTietQD.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gbChiTietQD.Location = new System.Drawing.Point(13, 344);
            this.gbChiTietQD.Margin = new System.Windows.Forms.Padding(2);
            this.gbChiTietQD.Name = "gbChiTietQD";
            this.gbChiTietQD.Padding = new System.Windows.Forms.Padding(2);
            this.gbChiTietQD.Size = new System.Drawing.Size(1119, 167);
            this.gbChiTietQD.TabIndex = 9;
            this.gbChiTietQD.TabStop = false;
            this.gbChiTietQD.Text = "Chi tiết phiếu xuất";
            // 
            // fgChiTietXuat
            // 
            this.fgChiTietXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fgChiTietXuat.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgChiTietXuat.ColumnInfo = resources.GetString("fgChiTietXuat.ColumnInfo");
            this.fgChiTietXuat.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgChiTietXuat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgChiTietXuat.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgChiTietXuat.Location = new System.Drawing.Point(7, 17);
            this.fgChiTietXuat.Margin = new System.Windows.Forms.Padding(2);
            this.fgChiTietXuat.Name = "fgChiTietXuat";
            this.fgChiTietXuat.Rows.Count = 1;
            this.fgChiTietXuat.Rows.DefaultSize = 18;
            this.fgChiTietXuat.Rows.MinSize = 21;
            this.fgChiTietXuat.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgChiTietXuat.Size = new System.Drawing.Size(1112, 146);
            this.fgChiTietXuat.StyleInfo = resources.GetString("fgChiTietXuat.StyleInfo");
            this.fgChiTietXuat.TabIndex = 0;
            // 
            // cboNguoiLap
            // 
            this.cboNguoiLap.Location = new System.Drawing.Point(690, 30);
            this.cboNguoiLap.Name = "cboNguoiLap";
            this.cboNguoiLap.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboNguoiLap.Properties.NullText = "Tất cả";
            this.cboNguoiLap.Properties.View = this.gridView1;
            this.cboNguoiLap.Size = new System.Drawing.Size(133, 20);
            this.cboNguoiLap.TabIndex = 39;
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // cboKhoXuat
            // 
            this.cboKhoXuat.EditValue = "Tất cả";
            this.cboKhoXuat.Location = new System.Drawing.Point(488, 30);
            this.cboKhoXuat.Name = "cboKhoXuat";
            this.cboKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoXuat.Properties.DisplayMember = "Ten_Kho";
            this.cboKhoXuat.Properties.NullText = "Tất cả";
            this.cboKhoXuat.Properties.NullValuePrompt = "Tất cả";
            this.cboKhoXuat.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboKhoXuat.Properties.ValueMember = "ID_Kho";
            this.cboKhoXuat.Properties.View = this.searchLookUpEdit1View;
            this.cboKhoXuat.Size = new System.Drawing.Size(94, 20);
            this.cboKhoXuat.TabIndex = 37;
            this.cboKhoXuat.EditValueChanged += new System.EventHandler(this.cboKhoXuat_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.searchLookUpEdit1View.DetailHeight = 380;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "Tất cả", this.gridColumn1, "")});
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Tên kho";
            this.gridColumn1.FieldName = "Ten_Kho";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(),
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.None, "Tất cả", "")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 30;
            // 
            // txtSoPhieuXuat
            // 
            this.txtSoPhieuXuat.Location = new System.Drawing.Point(362, 30);
            this.txtSoPhieuXuat.Name = "txtSoPhieuXuat";
            this.txtSoPhieuXuat.Size = new System.Drawing.Size(119, 20);
            this.txtSoPhieuXuat.TabIndex = 36;
            this.txtSoPhieuXuat.EditValueChanged += new System.EventHandler(this.txtSoPhieuXuat_EditValueChanged);
            // 
            // dtpNgayXuatKho
            // 
            // 
            // 
            // 
            this.dtpNgayXuatKho.Calendar.DayNameLength = 1;
            this.dtpNgayXuatKho.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayXuatKho.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayXuatKho.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtpNgayXuatKho.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtpNgayXuatKho.EditFormat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayXuatKho.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtpNgayXuatKho.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtpNgayXuatKho.Location = new System.Drawing.Point(244, 30);
            this.dtpNgayXuatKho.Name = "dtpNgayXuatKho";
            this.dtpNgayXuatKho.Size = new System.Drawing.Size(113, 20);
            this.dtpNgayXuatKho.TabIndex = 35;
            this.dtpNgayXuatKho.Tag = null;
            // 
            // dtpNgayHachToanTo
            // 
            // 
            // 
            // 
            this.dtpNgayHachToanTo.Calendar.DayNameLength = 1;
            this.dtpNgayHachToanTo.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHachToanTo.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHachToanTo.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtpNgayHachToanTo.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtpNgayHachToanTo.EditFormat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHachToanTo.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtpNgayHachToanTo.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtpNgayHachToanTo.Location = new System.Drawing.Point(125, 30);
            this.dtpNgayHachToanTo.Name = "dtpNgayHachToanTo";
            this.dtpNgayHachToanTo.Size = new System.Drawing.Size(113, 20);
            this.dtpNgayHachToanTo.TabIndex = 34;
            this.dtpNgayHachToanTo.Tag = null;
            this.dtpNgayHachToanTo.TextChanged += new System.EventHandler(this.dtpNgayHachToanTo_TextChanged);
            // 
            // dtpNgayHachToanFrom
            // 
            // 
            // 
            // 
            this.dtpNgayHachToanFrom.Calendar.DayNameLength = 1;
            this.dtpNgayHachToanFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHachToanFrom.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHachToanFrom.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtpNgayHachToanFrom.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtpNgayHachToanFrom.EditFormat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHachToanFrom.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtpNgayHachToanFrom.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtpNgayHachToanFrom.Location = new System.Drawing.Point(10, 30);
            this.dtpNgayHachToanFrom.Name = "dtpNgayHachToanFrom";
            this.dtpNgayHachToanFrom.Size = new System.Drawing.Size(116, 20);
            this.dtpNgayHachToanFrom.TabIndex = 33;
            this.dtpNgayHachToanFrom.Tag = null;
            this.dtpNgayHachToanFrom.TextChanged += new System.EventHandler(this.dtpNgayHachToanFrom_TextChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Blue;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(829, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Trạng thái";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Blue;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(690, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 31;
            this.label6.Text = "Người lập";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Blue;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(588, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 30;
            this.label5.Text = "Thẻ kho";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(487, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 29;
            this.label4.Text = "Kho xuất";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(362, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Sô phiếu xuất";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(244, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ngày xuất kho";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(10, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Ngày hạch toán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGhiTheKho
            // 
            this.btnGhiTheKho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGhiTheKho.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiTheKho.Appearance.Options.UseFont = true;
            this.btnGhiTheKho.Image = global::QLKho.Properties.Resources.ico_Copy;
            this.btnGhiTheKho.Location = new System.Drawing.Point(639, 516);
            this.btnGhiTheKho.Name = "btnGhiTheKho";
            this.btnGhiTheKho.Size = new System.Drawing.Size(98, 29);
            this.btnGhiTheKho.TabIndex = 48;
            this.btnGhiTheKho.Tag = "0";
            this.btnGhiTheKho.Text = "&Ghi thẻ kho";
            this.btnGhiTheKho.Visible = false;
            this.btnGhiTheKho.Click += new System.EventHandler(this.btnGhiTheKho_Click);
            // 
            // btnHuyDuyet
            // 
            this.btnHuyDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuyDuyet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDuyet.Appearance.Options.UseFont = true;
            this.btnHuyDuyet.Image = global::QLKho.Properties.Resources.ico_Abort;
            this.btnHuyDuyet.Location = new System.Drawing.Point(535, 516);
            this.btnHuyDuyet.Name = "btnHuyDuyet";
            this.btnHuyDuyet.Size = new System.Drawing.Size(98, 29);
            this.btnHuyDuyet.TabIndex = 47;
            this.btnHuyDuyet.Tag = "0";
            this.btnHuyDuyet.Text = "&Hủy duyệt";
            this.btnHuyDuyet.Visible = false;
            this.btnHuyDuyet.Click += new System.EventHandler(this.btnHuyDuyet_Click);
            // 
            // btnPheDuyet
            // 
            this.btnPheDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPheDuyet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPheDuyet.Appearance.Options.UseFont = true;
            this.btnPheDuyet.Image = global::QLKho.Properties.Resources.ico_Check;
            this.btnPheDuyet.Location = new System.Drawing.Point(431, 516);
            this.btnPheDuyet.Name = "btnPheDuyet";
            this.btnPheDuyet.Size = new System.Drawing.Size(98, 29);
            this.btnPheDuyet.TabIndex = 46;
            this.btnPheDuyet.Tag = "0";
            this.btnPheDuyet.Text = "&Phê duyệt";
            this.btnPheDuyet.Visible = false;
            this.btnPheDuyet.Click += new System.EventHandler(this.btnPheDuyet_Click);
            // 
            // btnTrinhDuyet
            // 
            this.btnTrinhDuyet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTrinhDuyet.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrinhDuyet.Appearance.Options.UseFont = true;
            this.btnTrinhDuyet.Image = global::QLKho.Properties.Resources.ico_Upload;
            this.btnTrinhDuyet.Location = new System.Drawing.Point(327, 516);
            this.btnTrinhDuyet.Name = "btnTrinhDuyet";
            this.btnTrinhDuyet.Size = new System.Drawing.Size(98, 29);
            this.btnTrinhDuyet.TabIndex = 45;
            this.btnTrinhDuyet.Tag = "0";
            this.btnTrinhDuyet.Text = "Trình &Duyệt";
            this.btnTrinhDuyet.Visible = false;
            this.btnTrinhDuyet.Click += new System.EventHandler(this.btnTrinhDuyet_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = global::QLKho.Properties.Resources.ico_Delete;
            this.btnXoa.Location = new System.Drawing.Point(223, 516);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 29);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Tag = "0";
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.Visible = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = global::QLKho.Properties.Resources.ico_Add;
            this.btnThem.Location = new System.Drawing.Point(15, 516);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 29);
            this.btnThem.TabIndex = 43;
            this.btnThem.Tag = "0";
            this.btnThem.Text = "&Thêm";
            this.btnThem.Visible = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = global::QLKho.Properties.Resources.ico_Edit;
            this.btnSua.Location = new System.Drawing.Point(117, 516);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 29);
            this.btnSua.TabIndex = 50;
            this.btnSua.Tag = "0";
            this.btnSua.Text = "&Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboTrangThai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.ItemHeight = 13;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Tất cả",
            "Đang lập",
            "Trình duyệt",
            "Phê duyệt",
            "Hủy duyệt",
            "Ghi thẻ kho"});
            this.cboTrangThai.Location = new System.Drawing.Point(830, 29);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(123, 21);
            this.cboTrangThai.TabIndex = 51;
            this.cboTrangThai.SelectedIndexChanged += new System.EventHandler(this.cboTrangThai_SelectedIndexChanged);
            // 
            // cboTheKho
            // 
            this.cboTheKho.EditValue = "Tất cả";
            this.cboTheKho.Location = new System.Drawing.Point(588, 31);
            this.cboTheKho.Name = "cboTheKho";
            this.cboTheKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboTheKho.Properties.DisplayMember = "ID_TheKho";
            this.cboTheKho.Properties.NullText = "Tất cả";
            this.cboTheKho.Properties.NullValuePrompt = "Tất cả";
            this.cboTheKho.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboTheKho.Properties.ValueMember = "ID_TheKho";
            this.cboTheKho.Properties.View = this.gridView2;
            this.cboTheKho.Size = new System.Drawing.Size(96, 20);
            this.cboTheKho.TabIndex = 52;
            this.cboTheKho.EditValueChanged += new System.EventHandler(this.cboTheKho_EditValueChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2});
            this.gridView2.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView2.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "Tất cả", this.gridColumn2, "")});
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Thẻ kho";
            this.gridColumn2.FieldName = "ID_TheKho";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(),
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.None, "Tất cả", "")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // frmQD_XuatVatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 549);
            this.Controls.Add(this.cboTheKho);
            this.Controls.Add(this.cboTrangThai);
            this.Controls.Add(this.btnGhiTheKho);
            this.Controls.Add(this.btnHuyDuyet);
            this.Controls.Add(this.btnPheDuyet);
            this.Controls.Add(this.btnTrinhDuyet);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.gbChiTietQD);
            this.Controls.Add(this.cboNguoiLap);
            this.Controls.Add(this.cboKhoXuat);
            this.Controls.Add(this.txtSoPhieuXuat);
            this.Controls.Add(this.dtpNgayXuatKho);
            this.Controls.Add(this.dtpNgayHachToanTo);
            this.Controls.Add(this.dtpNgayHachToanFrom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gbQD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Name = "frmQD_XuatVatTu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu xuất kho";
            this.Load += new System.EventHandler(this.frmQD_XuatVatTu_Load);
            this.gbQD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgQDX)).EndInit();
            this.gbChiTietQD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgChiTietXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboNguoiLap.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieuXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayXuatKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayHachToanTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayHachToanFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboTheKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucGroupBox gbQD;
        private VSCM.Base.Controls.ucFlexGrid fgQDX;
        private VSCM.Base.Controls.ucGroupBox gbChiTietQD;
        private VSCM.Base.Controls.ucFlexGrid fgChiTietXuat;
        private DevExpress.XtraEditors.SearchLookUpEdit cboNguoiLap;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SearchLookUpEdit cboKhoXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtSoPhieuXuat;
        private C1.Win.C1Input.C1DateEdit dtpNgayXuatKho;
        private C1.Win.C1Input.C1DateEdit dtpNgayHachToanTo;
        private C1.Win.C1Input.C1DateEdit dtpNgayHachToanFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private VSCM.Base.Controls.ucButton btnThem;
        private VSCM.Base.Controls.ucButton btnXoa;
        private VSCM.Base.Controls.ucButton btnTrinhDuyet;
        private VSCM.Base.Controls.ucButton btnPheDuyet;
        private VSCM.Base.Controls.ucButton btnHuyDuyet;
        private VSCM.Base.Controls.ucButton btnGhiTheKho;
        private VSCM.Base.Controls.ucButton btnSua;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private DevExpress.XtraEditors.SearchLookUpEdit cboTheKho;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}