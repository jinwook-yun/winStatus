namespace WinStatusBoard.Page
{
    partial class FrmOutDetail
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Grid = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cust_cd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cust_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.so_amt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.out_amt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.amt_rate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.MainView = this.gridView;
            this.Grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grid.Name = "Grid";
            this.Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.Grid.Size = new System.Drawing.Size(1495, 785);
            this.Grid.TabIndex = 5;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            //this.Grid.Click += new System.EventHandler(this.Grid_Click);
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.Appearance.Row.Options.UseTextOptions = true;
            this.gridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cust_cd,
            this.cust_nm,
            this.so_amt,
            this.out_amt,
            this.amt_rate});
            this.gridView.DetailHeight = 486;
            this.gridView.FixedLineWidth = 3;
            this.gridView.GridControl = this.Grid;
            this.gridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView.Name = "gridView";
            this.gridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsBehavior.Editable = false;
            this.gridView.OptionsBehavior.ReadOnly = true;
            this.gridView.OptionsCustomization.AllowSort = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridView.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.RowHeight = 130;
            this.gridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None;
            this.gridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_RowCellClick);
            this.gridView.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.gridView_CustomDrawColumnHeader);
            this.gridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_RowCellStyle);
            this.gridView.CalcRowHeight += new DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(this.gridView_CalcRowHeight);
            // 
            // cust_cd
            // 
            this.cust_cd.Caption = "수주처코드";
            this.cust_cd.FieldName = "cust_cd";
            this.cust_cd.MinWidth = 30;
            this.cust_cd.Name = "cust_cd";
            this.cust_cd.Width = 112;
            // 
            // cust_nm
            // 
            this.cust_nm.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cust_nm.AppearanceCell.Options.UseFont = true;
            this.cust_nm.AppearanceCell.Options.UseTextOptions = true;
            this.cust_nm.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cust_nm.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cust_nm.Caption = "수주처";
            this.cust_nm.ColumnEdit = this.repositoryItemMemoEdit1;
            this.cust_nm.FieldName = "cust_nm";
            this.cust_nm.Name = "cust_nm";
            this.cust_nm.OptionsColumn.AllowEdit = false;
            this.cust_nm.OptionsColumn.AllowFocus = false;
            this.cust_nm.OptionsColumn.FixedWidth = true;
            this.cust_nm.Visible = true;
            this.cust_nm.VisibleIndex = 0;
            this.cust_nm.Width = 568;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // so_amt
            // 
            this.so_amt.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.so_amt.AppearanceCell.Options.UseFont = true;
            this.so_amt.AppearanceCell.Options.UseTextOptions = true;
            this.so_amt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.so_amt.Caption = "수주금액";
            this.so_amt.FieldName = "so_amt";
            this.so_amt.Name = "so_amt";
            this.so_amt.OptionsColumn.AllowEdit = false;
            this.so_amt.OptionsColumn.AllowFocus = false;
            this.so_amt.Visible = true;
            this.so_amt.VisibleIndex = 1;
            this.so_amt.Width = 374;
            // 
            // out_amt
            // 
            this.out_amt.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold);
            this.out_amt.AppearanceCell.Options.UseFont = true;
            this.out_amt.AppearanceCell.Options.UseTextOptions = true;
            this.out_amt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.out_amt.Caption = "출하금액";
            this.out_amt.FieldName = "out_amt";
            this.out_amt.Name = "out_amt";
            this.out_amt.OptionsColumn.AllowEdit = false;
            this.out_amt.OptionsColumn.AllowFocus = false;
            this.out_amt.Visible = true;
            this.out_amt.VisibleIndex = 2;
            this.out_amt.Width = 335;
            // 
            // amt_rate
            // 
            this.amt_rate.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold);
            this.amt_rate.AppearanceCell.Options.UseFont = true;
            this.amt_rate.AppearanceCell.Options.UseTextOptions = true;
            this.amt_rate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.amt_rate.Caption = "진도율";
            this.amt_rate.FieldName = "amt_rate";
            this.amt_rate.Name = "amt_rate";
            this.amt_rate.OptionsColumn.AllowEdit = false;
            this.amt_rate.OptionsColumn.AllowFocus = false;
            this.amt_rate.Visible = true;
            this.amt_rate.VisibleIndex = 3;
            this.amt_rate.Width = 216;
            // 
            // FrmOutDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grid);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOutDetail";
            this.Size = new System.Drawing.Size(1495, 785);
            this.Load += new System.EventHandler(this.FrmOutDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn cust_cd;
        private DevExpress.XtraGrid.Columns.GridColumn cust_nm;
        private DevExpress.XtraGrid.Columns.GridColumn so_amt;
        private DevExpress.XtraGrid.Columns.GridColumn out_amt;
        private DevExpress.XtraGrid.Columns.GridColumn amt_rate;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    }
}
