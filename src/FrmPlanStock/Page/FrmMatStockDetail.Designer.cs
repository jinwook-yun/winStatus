namespace WinStatusBoard
{
    partial class FrmMatStockDetail
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
            this.itm_cd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spec6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.spec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.in_dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.heat_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stock = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.Grid.Size = new System.Drawing.Size(1495, 785);
            this.Grid.TabIndex = 5;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
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
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.itm_cd,
            this.spec6,
            this.spec,
            this.in_dt,
            this.heat_no,
            this.stock});
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
            this.gridView.OptionsView.AllowCellMerge = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.RowHeight = 80;
            this.gridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None;
            this.gridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.gridView_CustomDrawColumnHeader);
            this.gridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_RowCellStyle);
            this.gridView.CalcRowHeight += new DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(this.gridView_CalcRowHeight);
            // 
            // itm_cd
            // 
            this.itm_cd.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold);
            this.itm_cd.AppearanceCell.Options.UseFont = true;
            this.itm_cd.Caption = "품번";
            this.itm_cd.FieldName = "itm_cd";
            this.itm_cd.MinWidth = 30;
            this.itm_cd.Name = "itm_cd";
            this.itm_cd.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.itm_cd.Visible = true;
            this.itm_cd.VisibleIndex = 0;
            this.itm_cd.Width = 250;
            // 
            // spec6
            // 
            this.spec6.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold);
            this.spec6.AppearanceCell.Options.UseFont = true;
            this.spec6.Caption = "재질";
            this.spec6.ColumnEdit = this.repositoryItemMemoEdit1;
            this.spec6.FieldName = "spec6";
            this.spec6.MinWidth = 30;
            this.spec6.Name = "spec6";
            this.spec6.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.spec6.Visible = true;
            this.spec6.VisibleIndex = 1;
            this.spec6.Width = 291;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // spec
            // 
            this.spec.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold);
            this.spec.AppearanceCell.Options.UseFont = true;
            this.spec.AppearanceCell.Options.UseTextOptions = true;
            this.spec.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.spec.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.spec.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.spec.Caption = "규격";
            this.spec.ColumnEdit = this.repositoryItemMemoEdit2;
            this.spec.FieldName = "spec";
            this.spec.MinWidth = 30;
            this.spec.Name = "spec";
            this.spec.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.spec.Visible = true;
            this.spec.VisibleIndex = 2;
            this.spec.Width = 223;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // in_dt
            // 
            this.in_dt.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold);
            this.in_dt.AppearanceCell.Options.UseFont = true;
            this.in_dt.Caption = "입고일";
            this.in_dt.FieldName = "in_dt";
            this.in_dt.MinWidth = 30;
            this.in_dt.Name = "in_dt";
            this.in_dt.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.in_dt.Visible = true;
            this.in_dt.VisibleIndex = 3;
            this.in_dt.Width = 185;
            // 
            // heat_no
            // 
            this.heat_no.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold);
            this.heat_no.AppearanceCell.Options.UseFont = true;
            this.heat_no.Caption = "HEAT NO";
            this.heat_no.FieldName = "heat_no";
            this.heat_no.MinWidth = 30;
            this.heat_no.Name = "heat_no";
            this.heat_no.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.heat_no.Visible = true;
            this.heat_no.VisibleIndex = 4;
            this.heat_no.Width = 236;
            // 
            // stock
            // 
            this.stock.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 22F, System.Drawing.FontStyle.Bold);
            this.stock.AppearanceCell.Options.UseFont = true;
            this.stock.AppearanceCell.Options.UseTextOptions = true;
            this.stock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.stock.Caption = "재고";
            this.stock.FieldName = "stock";
            this.stock.MinWidth = 30;
            this.stock.Name = "stock";
            this.stock.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.stock.Visible = true;
            this.stock.VisibleIndex = 5;
            this.stock.Width = 149;
            // 
            // FrmMatStockDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grid);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMatStockDetail";
            this.Size = new System.Drawing.Size(1495, 785);
            this.Load += new System.EventHandler(this.FrmMatStockDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn itm_cd;
        private DevExpress.XtraGrid.Columns.GridColumn spec6;
        private DevExpress.XtraGrid.Columns.GridColumn spec;
        private DevExpress.XtraGrid.Columns.GridColumn in_dt;
        private DevExpress.XtraGrid.Columns.GridColumn heat_no;
        private DevExpress.XtraGrid.Columns.GridColumn stock;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
    }
}
