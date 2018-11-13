namespace QLKho
{
    partial class frmTonKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTonKho));
            this.cboKho = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grbVatTu = new DevExpress.XtraEditors.GroupControl();
            this.fgVatTu = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.lblKho = new System.Windows.Forms.Label();
            this.grbChiTiet = new DevExpress.XtraEditors.GroupControl();
            this.fgChiTiet = new C1.Win.C1FlexGrid.C1FlexGrid();
            ((System.ComponentModel.ISupportInitialize)(this.cboKho.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbVatTu)).BeginInit();
            this.grbVatTu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgVatTu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbChiTiet)).BeginInit();
            this.grbChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // cboKho
            // 
            this.cboKho.EditValue = "";
            this.cboKho.Location = new System.Drawing.Point(6, 31);
            this.cboKho.Name = "cboKho";
            this.cboKho.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboKho.Properties.DisplayMember = "Ten_Kho";
            this.cboKho.Properties.NullText = "[Tất cả]";
            this.cboKho.Properties.ValueMember = "ID_Kho";
            this.cboKho.Properties.View = this.searchLookUpEdit1View;
            this.cboKho.Size = new System.Drawing.Size(100, 20);
            this.cboKho.TabIndex = 0;
            this.cboKho.EditValueChanged += new System.EventHandler(this.cboKho_EditValueChanged);
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Ten_Kho";
            this.gridColumn1.FieldName = "Ten_Kho";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // grbVatTu
            // 
            this.grbVatTu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbVatTu.Controls.Add(this.fgVatTu);
            this.grbVatTu.Location = new System.Drawing.Point(0, 57);
            this.grbVatTu.Name = "grbVatTu";
            this.grbVatTu.Size = new System.Drawing.Size(626, 185);
            this.grbVatTu.TabIndex = 1;
            this.grbVatTu.Text = "Danh sách vật tư";
            // 
            // fgVatTu
            // 
            this.fgVatTu.AllowEditing = false;
            this.fgVatTu.ColumnInfo = resources.GetString("fgVatTu.ColumnInfo");
            this.fgVatTu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgVatTu.Location = new System.Drawing.Point(2, 21);
            this.fgVatTu.Name = "fgVatTu";
            this.fgVatTu.Rows.Count = 1;
            this.fgVatTu.Rows.DefaultSize = 17;
            this.fgVatTu.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgVatTu.Size = new System.Drawing.Size(622, 162);
            this.fgVatTu.StyleInfo = resources.GetString("fgVatTu.StyleInfo");
            this.fgVatTu.TabIndex = 0;
            this.fgVatTu.Click += new System.EventHandler(this.fgVatTu_Click);
            // 
            // lblKho
            // 
            this.lblKho.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblKho.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKho.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblKho.Location = new System.Drawing.Point(6, 5);
            this.lblKho.Name = "lblKho";
            this.lblKho.Size = new System.Drawing.Size(100, 23);
            this.lblKho.TabIndex = 2;
            this.lblKho.Text = "Kho";
            this.lblKho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChiTiet.Controls.Add(this.fgChiTiet);
            this.grbChiTiet.Location = new System.Drawing.Point(0, 248);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(626, 220);
            this.grbChiTiet.TabIndex = 3;
            this.grbChiTiet.Text = "Chi tiết nhập xuất";
            // 
            // fgChiTiet
            // 
            this.fgChiTiet.AllowEditing = false;
            this.fgChiTiet.ColumnInfo = resources.GetString("fgChiTiet.ColumnInfo");
            this.fgChiTiet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgChiTiet.Location = new System.Drawing.Point(2, 21);
            this.fgChiTiet.Name = "fgChiTiet";
            this.fgChiTiet.Rows.Count = 1;
            this.fgChiTiet.Rows.DefaultSize = 17;
            this.fgChiTiet.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.fgChiTiet.Size = new System.Drawing.Size(622, 197);
            this.fgChiTiet.StyleInfo = resources.GetString("fgChiTiet.StyleInfo");
            this.fgChiTiet.TabIndex = 1;
            // 
            // frmTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 480);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.lblKho);
            this.Controls.Add(this.grbVatTu);
            this.Controls.Add(this.cboKho);
            this.Name = "frmTonKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Số lượng trong kho";
            this.Load += new System.EventHandler(this.frmTonKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cboKho.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbVatTu)).EndInit();
            this.grbVatTu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgVatTu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grbChiTiet)).EndInit();
            this.grbChiTiet.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgChiTiet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SearchLookUpEdit cboKho;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraEditors.GroupControl grbVatTu;
        private System.Windows.Forms.Label lblKho;
        private C1.Win.C1FlexGrid.C1FlexGrid fgVatTu;
        private DevExpress.XtraEditors.GroupControl grbChiTiet;
        private C1.Win.C1FlexGrid.C1FlexGrid fgChiTiet;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}