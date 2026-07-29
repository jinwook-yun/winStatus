namespace WinStatusBoard.Page
{
    partial class FrmOutCustomDetail
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
            this.gridView = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand10 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand11 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridItemBand = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.cust_cd = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cust_nm = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.itm_nm = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.itm_cd = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridSoBand = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.so_qty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.so_amt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridOutBand = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.out_qty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.out_amt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridRateBand = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.qty_rate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.amt_rate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
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
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoEdit2});
            this.Grid.Size = new System.Drawing.Size(1918, 645);
            this.Grid.TabIndex = 5;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.BandPanel.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.BandPanel.Options.UseFont = true;
            this.gridView.Appearance.BandPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.Appearance.Row.Options.UseTextOptions = true;
            this.gridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand3,
            this.gridBand4,
            this.gridBand5,
            this.gridBand10,
            this.gridBand11,
            this.gridItemBand,
            this.gridSoBand,
            this.gridOutBand,
            this.gridRateBand});
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.cust_cd,
            this.cust_nm,
            this.itm_nm,
            this.itm_cd,
            this.so_qty,
            this.so_amt,
            this.out_qty,
            this.out_amt,
            this.qty_rate,
            this.amt_rate});
            this.gridView.DetailHeight = 486;
            this.gridView.FixedLineWidth = 1;
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
            this.gridView.OptionsView.AllowCellMerge = true;
            this.gridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.RowHeight = 90;
            this.gridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None;
            this.gridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "gridBand3";
            this.gridBand3.MinWidth = 47;
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Visible = false;
            this.gridBand3.VisibleIndex = -1;
            this.gridBand3.Width = 5958;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "gridBand4";
            this.gridBand4.MinWidth = 47;
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Visible = false;
            this.gridBand4.VisibleIndex = -1;
            this.gridBand4.Width = 1380;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "gridBand5";
            this.gridBand5.MinWidth = 47;
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Visible = false;
            this.gridBand5.VisibleIndex = -1;
            this.gridBand5.Width = 1380;
            // 
            // gridBand10
            // 
            this.gridBand10.Caption = "gridBand10";
            this.gridBand10.MinWidth = 47;
            this.gridBand10.Name = "gridBand10";
            this.gridBand10.Visible = false;
            this.gridBand10.VisibleIndex = -1;
            this.gridBand10.Width = 1380;
            // 
            // gridBand11
            // 
            this.gridBand11.Caption = "gridBand11";
            this.gridBand11.MinWidth = 47;
            this.gridBand11.Name = "gridBand11";
            this.gridBand11.Visible = false;
            this.gridBand11.VisibleIndex = -1;
            this.gridBand11.Width = 103;
            // 
            // gridItemBand
            // 
            this.gridItemBand.Caption = "품목정보";
            this.gridItemBand.Columns.Add(this.cust_cd);
            this.gridItemBand.Columns.Add(this.cust_nm);
            this.gridItemBand.Columns.Add(this.itm_nm);
            this.gridItemBand.Columns.Add(this.itm_cd);
            this.gridItemBand.MinWidth = 28;
            this.gridItemBand.Name = "gridItemBand";
            this.gridItemBand.VisibleIndex = 0;
            this.gridItemBand.Width = 884;
            // 
            // cust_cd
            // 
            this.cust_cd.Caption = "수주처코드";
            this.cust_cd.FieldName = "cust_cd";
            this.cust_cd.MinWidth = 83;
            this.cust_cd.Name = "cust_cd";
            this.cust_cd.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.cust_cd.Width = 468;
            // 
            // cust_nm
            // 
            this.cust_nm.Caption = "수주처";
            this.cust_nm.ColumnEdit = this.repositoryItemMemoEdit1;
            this.cust_nm.FieldName = "cust_nm";
            this.cust_nm.MinWidth = 100;
            this.cust_nm.Name = "cust_nm";
            this.cust_nm.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.cust_nm.OptionsColumn.FixedWidth = true;
            this.cust_nm.Visible = true;
            this.cust_nm.Width = 233;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // itm_nm
            // 
            this.itm_nm.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.itm_nm.AppearanceCell.Options.UseFont = true;
            this.itm_nm.AppearanceCell.Options.UseTextOptions = true;
            this.itm_nm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.itm_nm.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.itm_nm.Caption = "품명";
            this.itm_nm.ColumnEdit = this.repositoryItemMemoEdit2;
            this.itm_nm.FieldName = "itm_nm";
            this.itm_nm.MinWidth = 150;
            this.itm_nm.Name = "itm_nm";
            this.itm_nm.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.itm_nm.OptionsColumn.FixedWidth = true;
            this.itm_nm.Visible = true;
            this.itm_nm.Width = 306;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // itm_cd
            // 
            this.itm_cd.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold);
            this.itm_cd.AppearanceCell.Options.UseFont = true;
            this.itm_cd.Caption = "품번";
            this.itm_cd.FieldName = "itm_cd";
            this.itm_cd.MinWidth = 83;
            this.itm_cd.Name = "itm_cd";
            this.itm_cd.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.itm_cd.Visible = true;
            this.itm_cd.Width = 345;
            // 
            // gridSoBand
            // 
            this.gridSoBand.Caption = "수주";
            this.gridSoBand.Columns.Add(this.so_qty);
            this.gridSoBand.Columns.Add(this.so_amt);
            this.gridSoBand.MinWidth = 28;
            this.gridSoBand.Name = "gridSoBand";
            this.gridSoBand.VisibleIndex = 1;
            this.gridSoBand.Width = 356;
            // 
            // so_qty
            // 
            this.so_qty.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.so_qty.AppearanceCell.Options.UseFont = true;
            this.so_qty.AppearanceCell.Options.UseTextOptions = true;
            this.so_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.so_qty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.so_qty.Caption = "수량";
            this.so_qty.FieldName = "so_qty";
            this.so_qty.MinWidth = 83;
            this.so_qty.Name = "so_qty";
            this.so_qty.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.so_qty.Visible = true;
            this.so_qty.Width = 168;
            // 
            // so_amt
            // 
            this.so_amt.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.so_amt.AppearanceCell.Options.UseFont = true;
            this.so_amt.AppearanceCell.Options.UseTextOptions = true;
            this.so_amt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.so_amt.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.so_amt.Caption = "금액";
            this.so_amt.FieldName = "so_amt";
            this.so_amt.MinWidth = 83;
            this.so_amt.Name = "so_amt";
            this.so_amt.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.so_amt.Visible = true;
            this.so_amt.Width = 188;
            // 
            // gridOutBand
            // 
            this.gridOutBand.Caption = "출하";
            this.gridOutBand.Columns.Add(this.out_qty);
            this.gridOutBand.Columns.Add(this.out_amt);
            this.gridOutBand.MinWidth = 28;
            this.gridOutBand.Name = "gridOutBand";
            this.gridOutBand.VisibleIndex = 2;
            this.gridOutBand.Width = 381;
            // 
            // out_qty
            // 
            this.out_qty.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.out_qty.AppearanceCell.Options.UseFont = true;
            this.out_qty.AppearanceCell.Options.UseTextOptions = true;
            this.out_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.out_qty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.out_qty.Caption = "수량";
            this.out_qty.FieldName = "out_qty";
            this.out_qty.MinWidth = 83;
            this.out_qty.Name = "out_qty";
            this.out_qty.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.out_qty.Visible = true;
            this.out_qty.Width = 180;
            // 
            // out_amt
            // 
            this.out_amt.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.out_amt.AppearanceCell.Options.UseFont = true;
            this.out_amt.AppearanceCell.Options.UseTextOptions = true;
            this.out_amt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.out_amt.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.out_amt.Caption = "금액";
            this.out_amt.FieldName = "out_amt";
            this.out_amt.MinWidth = 83;
            this.out_amt.Name = "out_amt";
            this.out_amt.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.out_amt.Visible = true;
            this.out_amt.Width = 201;
            // 
            // gridRateBand
            // 
            this.gridRateBand.Caption = "진행율";
            this.gridRateBand.Columns.Add(this.qty_rate);
            this.gridRateBand.Columns.Add(this.amt_rate);
            this.gridRateBand.MinWidth = 28;
            this.gridRateBand.Name = "gridRateBand";
            this.gridRateBand.VisibleIndex = 3;
            this.gridRateBand.Width = 256;
            // 
            // qty_rate
            // 
            this.qty_rate.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.qty_rate.AppearanceCell.Options.UseFont = true;
            this.qty_rate.AppearanceCell.Options.UseTextOptions = true;
            this.qty_rate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.qty_rate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.qty_rate.Caption = "수량";
            this.qty_rate.FieldName = "qty_rate";
            this.qty_rate.MinWidth = 83;
            this.qty_rate.Name = "qty_rate";
            this.qty_rate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.qty_rate.Visible = true;
            this.qty_rate.Width = 128;
            // 
            // amt_rate
            // 
            this.amt_rate.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.amt_rate.AppearanceCell.Options.UseFont = true;
            this.amt_rate.AppearanceCell.Options.UseTextOptions = true;
            this.amt_rate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.amt_rate.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.amt_rate.Caption = "금액";
            this.amt_rate.FieldName = "amt_rate";
            this.amt_rate.MinWidth = 83;
            this.amt_rate.Name = "amt_rate";
            this.amt_rate.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.amt_rate.Visible = true;
            this.amt_rate.Width = 128;
            // 
            // FrmOutCustomDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grid);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOutCustomDetail";
            this.Size = new System.Drawing.Size(1918, 645);
            this.Load += new System.EventHandler(this.FrmOutCustomDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView gridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand10;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand11;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridItemBand;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn cust_cd;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn qty_rate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn amt_rate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn cust_nm;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridSoBand;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn itm_nm;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn itm_cd;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridOutBand;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn so_qty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn so_amt;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridRateBand;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn out_qty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn out_amt;
    }
}
