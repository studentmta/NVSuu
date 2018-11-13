namespace QLKho
{
    partial class frmPhieuXuat_ChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuXuat_ChiTiet));
            this.fgChiTietTheKho = new VSCM.Base.Controls.ucFlexGrid();
            this.fgChiTietXuat = new VSCM.Base.Controls.ucFlexGrid();
            this.cboKhoXuat = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Ten_Kho = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSoPhieuXuat = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new VSCM.Base.Controls.ucButton();
            this.btnHuy = new VSCM.Base.Controls.ucButton();
            this.dtpNgayXuatKho = new C1.Win.C1Input.C1DateEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayHachToan = new C1.Win.C1Input.C1DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChiTietXuatTheoTheKho = new DevExpress.XtraEditors.GroupControl();
            this.grbChitietXuat = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.fgChiTietTheKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgChiTietXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieuXuat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayXuatKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayHachToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbChiTietXuatTheoTheKho)).BeginInit();
            this.grbChiTietXuatTheoTheKho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grbChitietXuat)).BeginInit();
            this.grbChitietXuat.SuspendLayout();
            this.SuspendLayout();
            // 
            // fgChiTietTheKho
            // 
            this.fgChiTietTheKho.AllowMergingFixed = C1.Win.C1FlexGrid.AllowMergingEnum.FixedOnly;
            this.fgChiTietTheKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fgChiTietTheKho.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgChiTietTheKho.ColumnInfo = resources.GetString("fgChiTietTheKho.ColumnInfo");
            this.fgChiTietTheKho.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgChiTietTheKho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgChiTietTheKho.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgChiTietTheKho.Location = new System.Drawing.Point(4, 27);
            this.fgChiTietTheKho.Margin = new System.Windows.Forms.Padding(2);
            this.fgChiTietTheKho.Name = "fgChiTietTheKho";
            this.fgChiTietTheKho.Rows.Count = 1;
            this.fgChiTietTheKho.Rows.DefaultSize = 18;
            this.fgChiTietTheKho.Rows.MinSize = 21;
            this.fgChiTietTheKho.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgChiTietTheKho.Size = new System.Drawing.Size(857, 139);
            this.fgChiTietTheKho.StyleInfo = resources.GetString("fgChiTietTheKho.StyleInfo");
            this.fgChiTietTheKho.TabIndex = 2;
            this.fgChiTietTheKho.AfterEdit += new C1.Win.C1FlexGrid.RowColEventHandler(this.fgChiTietTheKho_AfterEdit);
            // 
            // fgChiTietXuat
            // 
            this.fgChiTietXuat.AllowEditing = false;
            this.fgChiTietXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fgChiTietXuat.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.FixedSingle;
            this.fgChiTietXuat.ColumnInfo = resources.GetString("fgChiTietXuat.ColumnInfo");
            this.fgChiTietXuat.FocusRect = C1.Win.C1FlexGrid.FocusRectEnum.Heavy;
            this.fgChiTietXuat.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fgChiTietXuat.KeyActionTab = C1.Win.C1FlexGrid.KeyActionEnum.MoveAcross;
            this.fgChiTietXuat.Location = new System.Drawing.Point(4, 22);
            this.fgChiTietXuat.Margin = new System.Windows.Forms.Padding(2);
            this.fgChiTietXuat.Name = "fgChiTietXuat";
            this.fgChiTietXuat.Rows.Count = 1;
            this.fgChiTietXuat.Rows.DefaultSize = 18;
            this.fgChiTietXuat.Rows.MinSize = 21;
            this.fgChiTietXuat.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgChiTietXuat.Size = new System.Drawing.Size(857, 190);
            this.fgChiTietXuat.StyleInfo = resources.GetString("fgChiTietXuat.StyleInfo");
            this.fgChiTietXuat.TabIndex = 3;
            this.fgChiTietXuat.Click += new System.EventHandler(this.fgChiTietXuat_Click);
            // 
            // cboKhoXuat
            // 
            this.cboKhoXuat.Location = new System.Drawing.Point(166, 36);
            this.cboKhoXuat.Name = "cboKhoXuat";
            this.cboKhoXuat.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKhoXuat.Properties.DisplayMember = "Ten_Kho";
            this.cboKhoXuat.Properties.NullText = "Tất cả";
            this.cboKhoXuat.Properties.ValueMember = "ID_Kho";
            this.cboKhoXuat.Properties.View = this.searchLookUpEdit1View;
            this.cboKhoXuat.Size = new System.Drawing.Size(153, 20);
            this.cboKhoXuat.TabIndex = 41;
            this.cboKhoXuat.EditValueChanged += new System.EventHandler(this.cboKhoXuat_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Ten_Kho});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // Ten_Kho
            // 
            this.Ten_Kho.Caption = "Tên kho";
            this.Ten_Kho.FieldName = "Ten_Kho";
            this.Ten_Kho.Name = "Ten_Kho";
            this.Ten_Kho.Visible = true;
            this.Ten_Kho.VisibleIndex = 0;
            // 
            // txtSoPhieuXuat
            // 
            this.txtSoPhieuXuat.Location = new System.Drawing.Point(8, 36);
            this.txtSoPhieuXuat.Name = "txtSoPhieuXuat";
            this.txtSoPhieuXuat.Size = new System.Drawing.Size(153, 20);
            this.txtSoPhieuXuat.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Blue;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(165, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Kho xuất";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Blue;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(8, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Sô phiếu xuất";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.Image = global::QLKho.Properties.Resources.ico_Save;
            this.btnLuu.Location = new System.Drawing.Point(9, 460);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(98, 29);
            this.btnLuu.TabIndex = 51;
            this.btnLuu.Tag = "0";
            this.btnLuu.Text = "&Lưu lại";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = global::QLKho.Properties.Resources.ico_Back;
            this.btnHuy.Location = new System.Drawing.Point(115, 460);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(98, 29);
            this.btnHuy.TabIndex = 50;
            this.btnHuy.Tag = "0";
            this.btnHuy.Text = "&Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.dtpNgayXuatKho.Location = new System.Drawing.Point(325, 36);
            this.dtpNgayXuatKho.Name = "dtpNgayXuatKho";
            this.dtpNgayXuatKho.Size = new System.Drawing.Size(117, 20);
            this.dtpNgayXuatKho.TabIndex = 53;
            this.dtpNgayXuatKho.Tag = null;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Blue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(325, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 52;
            this.label2.Text = "Ngày xuất kho";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpNgayHachToan
            // 
            // 
            // 
            // 
            this.dtpNgayHachToan.Calendar.DayNameLength = 1;
            this.dtpNgayHachToan.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHachToan.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHachToan.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtpNgayHachToan.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtpNgayHachToan.EditFormat.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayHachToan.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.dtpNgayHachToan.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.dtpNgayHachToan.Location = new System.Drawing.Point(448, 36);
            this.dtpNgayHachToan.Name = "dtpNgayHachToan";
            this.dtpNgayHachToan.Size = new System.Drawing.Size(117, 20);
            this.dtpNgayHachToan.TabIndex = 55;
            this.dtpNgayHachToan.Tag = null;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Blue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(448, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Ngày hạch toán";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbChiTietXuatTheoTheKho
            // 
            this.grbChiTietXuatTheoTheKho.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChiTietXuatTheoTheKho.Controls.Add(this.fgChiTietTheKho);
            this.grbChiTietXuatTheoTheKho.Location = new System.Drawing.Point(9, 284);
            this.grbChiTietXuatTheoTheKho.Name = "grbChiTietXuatTheoTheKho";
            this.grbChiTietXuatTheoTheKho.Size = new System.Drawing.Size(865, 170);
            this.grbChiTietXuatTheoTheKho.TabIndex = 56;
            this.grbChiTietXuatTheoTheKho.Text = "Chi tiết xuất theo thẻ kho";
            // 
            // grbChitietXuat
            // 
            this.grbChitietXuat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChitietXuat.Controls.Add(this.fgChiTietXuat);
            this.grbChitietXuat.Location = new System.Drawing.Point(9, 62);
            this.grbChitietXuat.Name = "grbChitietXuat";
            this.grbChitietXuat.Size = new System.Drawing.Size(865, 216);
            this.grbChitietXuat.TabIndex = 57;
            this.grbChitietXuat.Text = "Chi tiết xuất";
            // 
            // frmPhieuXuat_ChiTiet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(881, 495);
            this.Controls.Add(this.grbChitietXuat);
            this.Controls.Add(this.grbChiTietXuatTheoTheKho);
            this.Controls.Add(this.dtpNgayHachToan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgayXuatKho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboKhoXuat);
            this.Controls.Add(this.txtSoPhieuXuat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPhieuXuat_ChiTiet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm mới";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPhieuXuat_ChiTiet_FormClosed);
            this.Load += new System.EventHandler(this.frmPhieuXuat_ChiTiet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fgChiTietTheKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fgChiTietXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboKhoXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoPhieuXuat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayXuatKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayHachToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbChiTietXuatTheoTheKho)).EndInit();
            this.grbChiTietXuatTheoTheKho.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grbChitietXuat)).EndInit();
            this.grbChitietXuat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private VSCM.Base.Controls.ucFlexGrid fgChiTietTheKho;
        private VSCM.Base.Controls.ucFlexGrid fgChiTietXuat;
        private DevExpress.XtraEditors.SearchLookUpEdit cboKhoXuat;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.TextEdit txtSoPhieuXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private VSCM.Base.Controls.ucButton btnLuu;
        private VSCM.Base.Controls.ucButton btnHuy;
        private C1.Win.C1Input.C1DateEdit dtpNgayXuatKho;
        private System.Windows.Forms.Label label2;
        private C1.Win.C1Input.C1DateEdit dtpNgayHachToan;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl grbChiTietXuatTheoTheKho;
        private DevExpress.XtraEditors.GroupControl grbChitietXuat;
        private DevExpress.XtraGrid.Columns.GridColumn Ten_Kho;
    }
}