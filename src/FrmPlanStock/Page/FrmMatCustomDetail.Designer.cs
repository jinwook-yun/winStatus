namespace WinStatusBoard
{
    partial class FrmMatCustomDetail
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
            this.draw_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itm_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.spec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.plan_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.itm_id = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).BeginInit();
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
            this.repositoryItemMemoEdit2,
            this.repositoryItemMemoEdit3});
            this.Grid.Size = new System.Drawing.Size(1277, 738);
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
            this.cust_cd,
            this.draw_no,
            this.itm_nm,
            this.spec,
            this.plan_qty,
            this.itm_id});
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
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.RowHeight = 80;
            this.gridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None;
            this.gridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_RowCellClick);
            this.gridView.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.gridView_CustomDrawColumnHeader);
            this.gridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_RowCellStyle);
            this.gridView.CalcRowHeight += new DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(this.gridView_CalcRowHeight);
            // 
            // cust_cd
            // 
            this.cust_cd.Caption = "cust_cd";
            this.cust_cd.FieldName = "cust_cd";
            this.cust_cd.MinWidth = 30;
            this.cust_cd.Name = "cust_cd";
            this.cust_cd.Width = 112;
            // 
            // draw_no
            // 
            this.draw_no.Caption = "관리번호";
            this.draw_no.FieldName = "draw_no";
            this.draw_no.MinWidth = 30;
            this.draw_no.Name = "draw_no";
            this.draw_no.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.draw_no.Visible = true;
            this.draw_no.VisibleIndex = 0;
            this.draw_no.Width = 196;
            // 
            // itm_nm
            // 
            this.itm_nm.AppearanceCell.Options.UseTextOptions = true;
            this.itm_nm.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.itm_nm.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.itm_nm.Caption = "품명";
            this.itm_nm.ColumnEdit = this.repositoryItemMemoEdit1;
            this.itm_nm.FieldName = "itm_nm";
            this.itm_nm.MinWidth = 30;
            this.itm_nm.Name = "itm_nm";
            this.itm_nm.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.itm_nm.Visible = true;
            this.itm_nm.VisibleIndex = 1;
            this.itm_nm.Width = 323;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // spec
            // 
            this.spec.AppearanceCell.Options.UseTextOptions = true;
            this.spec.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.spec.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.spec.Caption = "규격";
            this.spec.ColumnEdit = this.repositoryItemMemoEdit3;
            this.spec.FieldName = "spec";
            this.spec.MinWidth = 30;
            this.spec.Name = "spec";
            this.spec.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.spec.Visible = true;
            this.spec.VisibleIndex = 2;
            this.spec.Width = 315;
            // 
            // repositoryItemMemoEdit3
            // 
            this.repositoryItemMemoEdit3.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemMemoEdit3.Name = "repositoryItemMemoEdit3";
            // 
            // plan_qty
            // 
            this.plan_qty.AppearanceCell.Options.UseTextOptions = true;
            this.plan_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.plan_qty.Caption = "생산계획";
            this.plan_qty.FieldName = "plan_qty";
            this.plan_qty.MinWidth = 30;
            this.plan_qty.Name = "plan_qty";
            this.plan_qty.Visible = true;
            this.plan_qty.VisibleIndex = 3;
            this.plan_qty.Width = 200;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // itm_id
            // 
            this.itm_id.Caption = "품목ID";
            this.itm_id.FieldName = "itm_id";
            this.itm_id.MinWidth = 30;
            this.itm_id.Name = "itm_id";
            this.itm_id.Width = 112;
            // 
            // FrmMatCustomDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grid);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMatCustomDetail";
            this.Size = new System.Drawing.Size(1277, 738);
            this.Load += new System.EventHandler(this.FrmMatCustomDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn itm_nm;
        private DevExpress.XtraGrid.Columns.GridColumn spec;
        private DevExpress.XtraGrid.Columns.GridColumn plan_qty;
        private DevExpress.XtraGrid.Columns.GridColumn draw_no;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit3;
        private DevExpress.XtraGrid.Columns.GridColumn cust_cd;
        private DevExpress.XtraGrid.Columns.GridColumn itm_id;
    }
}
