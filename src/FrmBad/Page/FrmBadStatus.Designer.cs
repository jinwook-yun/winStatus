namespace WinStatusBoard.Page
{
    partial class FrmBadStatus
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
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.grp_bc = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.mc_nm = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.std = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.prev_qty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.mon_qty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.year_qty = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.per = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.MainView = this.bandedGridView1;
            this.Grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grid.Name = "Grid";
            this.Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.Grid.Size = new System.Drawing.Size(1277, 738);
            this.Grid.TabIndex = 6;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bandedGridView1});
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Appearance.BandPanel.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bandedGridView1.Appearance.BandPanel.Options.UseFont = true;
            this.bandedGridView1.Appearance.BandPanel.Options.UseTextOptions = true;
            this.bandedGridView1.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridView1.Appearance.BandPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridView1.Appearance.HeaderPanel.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseFont = true;
            this.bandedGridView1.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.bandedGridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridView1.Appearance.Row.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bandedGridView1.Appearance.Row.Options.UseFont = true;
            this.bandedGridView1.Appearance.Row.Options.UseTextOptions = true;
            this.bandedGridView1.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bandedGridView1.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2});
            this.bandedGridView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.grp_bc,
            this.mc_nm,
            this.std,
            this.prev_qty,
            this.mon_qty,
            this.year_qty,
            this.per});
            this.bandedGridView1.DetailHeight = 100;
            this.bandedGridView1.FixedLineWidth = 3;
            this.bandedGridView1.GridControl = this.Grid;
            this.bandedGridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.bandedGridView1.Name = "bandedGridView1";
            this.bandedGridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.bandedGridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.bandedGridView1.OptionsBehavior.Editable = false;
            this.bandedGridView1.OptionsBehavior.ReadOnly = true;
            this.bandedGridView1.OptionsCustomization.AllowSort = false;
            this.bandedGridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bandedGridView1.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.bandedGridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.bandedGridView1.OptionsView.AllowCellMerge = true;
            this.bandedGridView1.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full;
            this.bandedGridView1.OptionsView.ShowGroupPanel = false;
            this.bandedGridView1.OptionsView.ShowIndicator = false;
            this.bandedGridView1.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.bandedGridView1.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.bandedGridView1.RowHeight = 45;
            this.bandedGridView1.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None;
            this.bandedGridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "구분";
            this.gridBand1.Columns.Add(this.grp_bc);
            this.gridBand1.Columns.Add(this.mc_nm);
            this.gridBand1.Columns.Add(this.std);
            this.gridBand1.MinWidth = 17;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 1038;
            // 
            // grp_bc
            // 
            this.grp_bc.AppearanceCell.Options.UseTextOptions = true;
            this.grp_bc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grp_bc.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.grp_bc.Caption = "구분";
            this.grp_bc.FieldName = "grp_bc";
            this.grp_bc.MinWidth = 33;
            this.grp_bc.Name = "grp_bc";
            this.grp_bc.OptionsColumn.AllowEdit = false;
            this.grp_bc.OptionsColumn.AllowFocus = false;
            this.grp_bc.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.grp_bc.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.grp_bc.Visible = true;
            this.grp_bc.Width = 248;
            // 
            // mc_nm
            // 
            this.mc_nm.AppearanceCell.Options.UseTextOptions = true;
            this.mc_nm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.mc_nm.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.mc_nm.Caption = "설비";
            this.mc_nm.FieldName = "mc_nm";
            this.mc_nm.MinWidth = 50;
            this.mc_nm.Name = "mc_nm";
            this.mc_nm.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.mc_nm.Visible = true;
            this.mc_nm.Width = 545;
            // 
            // std
            // 
            this.std.AppearanceCell.Options.UseTextOptions = true;
            this.std.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.std.Caption = "목표수준";
            this.std.FieldName = "std";
            this.std.MinWidth = 50;
            this.std.Name = "std";
            this.std.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.std.Visible = true;
            this.std.Width = 245;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "발생현황";
            this.gridBand2.Columns.Add(this.prev_qty);
            this.gridBand2.Columns.Add(this.mon_qty);
            this.gridBand2.Columns.Add(this.year_qty);
            this.gridBand2.Columns.Add(this.per);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 1088;
            // 
            // prev_qty
            // 
            this.prev_qty.AppearanceCell.Options.UseTextOptions = true;
            this.prev_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.prev_qty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.prev_qty.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.prev_qty.Caption = "전월";
            this.prev_qty.ColumnEdit = this.repositoryItemMemoEdit1;
            this.prev_qty.FieldName = "prev_qty";
            this.prev_qty.MinWidth = 33;
            this.prev_qty.Name = "prev_qty";
            this.prev_qty.OptionsColumn.AllowEdit = false;
            this.prev_qty.OptionsColumn.AllowFocus = false;
            this.prev_qty.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.prev_qty.OptionsColumn.FixedWidth = true;
            this.prev_qty.Visible = true;
            this.prev_qty.Width = 292;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // mon_qty
            // 
            this.mon_qty.AppearanceCell.Options.UseTextOptions = true;
            this.mon_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.mon_qty.Caption = "당월";
            this.mon_qty.FieldName = "mon_qty";
            this.mon_qty.MinWidth = 50;
            this.mon_qty.Name = "mon_qty";
            this.mon_qty.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.mon_qty.Visible = true;
            this.mon_qty.Width = 267;
            // 
            // year_qty
            // 
            this.year_qty.AppearanceCell.Options.UseTextOptions = true;
            this.year_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.year_qty.Caption = "누적";
            this.year_qty.FieldName = "year_qty";
            this.year_qty.MinWidth = 50;
            this.year_qty.Name = "year_qty";
            this.year_qty.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.year_qty.Visible = true;
            this.year_qty.Width = 262;
            // 
            // per
            // 
            this.per.AppearanceCell.Options.UseTextOptions = true;
            this.per.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.per.Caption = "달성율";
            this.per.FieldName = "per";
            this.per.MinWidth = 50;
            this.per.Name = "per";
            this.per.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.per.Visible = true;
            this.per.Width = 267;
            // 
            // FrmBadStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grid);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBadStatus";
            this.Size = new System.Drawing.Size(1277, 738);
            this.Load += new System.EventHandler(this.FrmBadStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn grp_bc;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn mc_nm;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn std;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn prev_qty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn mon_qty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn year_qty;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn per;
    }
}
