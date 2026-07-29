namespace WinStatusBoard.Page
{
    partial class FrmClaimMonth
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
            this.no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rep_dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clm_dt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cust_cd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cust_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.itm_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.itm_cd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clm_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.iss_amt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clm_dsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chk_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mc_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.rmks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).BeginInit();
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
            this.Grid.TabIndex = 6;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.Appearance.Row.Options.UseTextOptions = true;
            this.gridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.no,
            this.rep_dt,
            this.clm_dt,
            this.cust_cd,
            this.cust_nm,
            this.itm_nm,
            this.itm_cd,
            this.clm_type,
            this.qty,
            this.iss_amt,
            this.clm_dsc,
            this.chk_nm,
            this.mc_nm,
            this.rmks});
            this.gridView.DetailHeight = 486;
            this.gridView.FixedLineWidth = 3;
            this.gridView.GridControl = this.Grid;
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
            this.gridView.OptionsView.ColumnAutoWidth = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.RowHeight = 80;
            this.gridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None;
            // 
            // no
            // 
            this.no.AppearanceCell.Options.UseTextOptions = true;
            this.no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.no.Caption = "No";
            this.no.FieldName = "no";
            this.no.Name = "no";
            this.no.OptionsColumn.AllowEdit = false;
            this.no.OptionsColumn.AllowFocus = false;
            this.no.Width = 97;
            // 
            // rep_dt
            // 
            this.rep_dt.AppearanceCell.Options.UseTextOptions = true;
            this.rep_dt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.rep_dt.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.rep_dt.Caption = "처리일자";
            this.rep_dt.FieldName = "rep_dt";
            this.rep_dt.Name = "rep_dt";
            this.rep_dt.OptionsColumn.AllowEdit = false;
            this.rep_dt.OptionsColumn.AllowFocus = false;
            this.rep_dt.Visible = true;
            this.rep_dt.VisibleIndex = 0;
            this.rep_dt.Width = 191;
            // 
            // clm_dt
            // 
            this.clm_dt.AppearanceCell.Options.UseTextOptions = true;
            this.clm_dt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.clm_dt.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.clm_dt.Caption = "접수일자";
            this.clm_dt.FieldName = "clm_dt";
            this.clm_dt.MinWidth = 30;
            this.clm_dt.Name = "clm_dt";
            this.clm_dt.Visible = true;
            this.clm_dt.VisibleIndex = 1;
            this.clm_dt.Width = 216;
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
            this.cust_nm.AppearanceCell.Options.UseTextOptions = true;
            this.cust_nm.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cust_nm.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cust_nm.Caption = "수주업체";
            this.cust_nm.ColumnEdit = this.repositoryItemMemoEdit1;
            this.cust_nm.FieldName = "cust_nm";
            this.cust_nm.Name = "cust_nm";
            this.cust_nm.OptionsColumn.AllowEdit = false;
            this.cust_nm.OptionsColumn.AllowFocus = false;
            this.cust_nm.OptionsColumn.FixedWidth = true;
            this.cust_nm.Visible = true;
            this.cust_nm.VisibleIndex = 2;
            this.cust_nm.Width = 262;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemMemoEdit1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // itm_nm
            // 
            this.itm_nm.Caption = "품명";
            this.itm_nm.ColumnEdit = this.repositoryItemMemoEdit2;
            this.itm_nm.FieldName = "itm_nm";
            this.itm_nm.MinWidth = 30;
            this.itm_nm.Name = "itm_nm";
            this.itm_nm.Visible = true;
            this.itm_nm.VisibleIndex = 3;
            this.itm_nm.Width = 356;
            // 
            // repositoryItemMemoEdit2
            // 
            this.repositoryItemMemoEdit2.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit2.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemMemoEdit2.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit2.Name = "repositoryItemMemoEdit2";
            // 
            // itm_cd
            // 
            this.itm_cd.Caption = "품번";
            this.itm_cd.FieldName = "itm_cd";
            this.itm_cd.MinWidth = 30;
            this.itm_cd.Name = "itm_cd";
            this.itm_cd.Visible = true;
            this.itm_cd.VisibleIndex = 4;
            this.itm_cd.Width = 230;
            // 
            // clm_type
            // 
            this.clm_type.Caption = "클레임 내역";
            this.clm_type.FieldName = "clm_type";
            this.clm_type.MinWidth = 30;
            this.clm_type.Name = "clm_type";
            this.clm_type.Visible = true;
            this.clm_type.VisibleIndex = 5;
            this.clm_type.Width = 257;
            // 
            // qty
            // 
            this.qty.AppearanceCell.Options.UseTextOptions = true;
            this.qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.qty.Caption = "불량수량";
            this.qty.FieldName = "qty";
            this.qty.MinWidth = 30;
            this.qty.Name = "qty";
            this.qty.Visible = true;
            this.qty.VisibleIndex = 6;
            this.qty.Width = 167;
            // 
            // iss_amt
            // 
            this.iss_amt.AppearanceCell.Options.UseTextOptions = true;
            this.iss_amt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.iss_amt.Caption = "손실금액";
            this.iss_amt.FieldName = "iss_amt";
            this.iss_amt.MinWidth = 30;
            this.iss_amt.Name = "iss_amt";
            this.iss_amt.Visible = true;
            this.iss_amt.VisibleIndex = 7;
            this.iss_amt.Width = 160;
            // 
            // clm_dsc
            // 
            this.clm_dsc.Caption = "처리내역";
            this.clm_dsc.FieldName = "clm_dsc";
            this.clm_dsc.MinWidth = 30;
            this.clm_dsc.Name = "clm_dsc";
            this.clm_dsc.Visible = true;
            this.clm_dsc.VisibleIndex = 8;
            this.clm_dsc.Width = 233;
            // 
            // chk_nm
            // 
            this.chk_nm.Caption = "확인자";
            this.chk_nm.FieldName = "chk_nm";
            this.chk_nm.MinWidth = 30;
            this.chk_nm.Name = "chk_nm";
            this.chk_nm.Width = 191;
            // 
            // mc_nm
            // 
            this.mc_nm.Caption = "설비구분";
            this.mc_nm.FieldName = "mc_nm";
            this.mc_nm.MinWidth = 30;
            this.mc_nm.Name = "mc_nm";
            this.mc_nm.Visible = true;
            this.mc_nm.VisibleIndex = 9;
            this.mc_nm.Width = 221;
            // 
            // rmks
            // 
            this.rmks.AppearanceCell.Options.UseTextOptions = true;
            this.rmks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.rmks.Caption = "비고";
            this.rmks.ColumnEdit = this.repositoryItemMemoEdit3;
            this.rmks.FieldName = "rmks";
            this.rmks.Name = "rmks";
            this.rmks.OptionsColumn.AllowEdit = false;
            this.rmks.OptionsColumn.AllowFocus = false;
            this.rmks.Visible = true;
            this.rmks.VisibleIndex = 10;
            this.rmks.Width = 365;
            // 
            // repositoryItemMemoEdit3
            // 
            this.repositoryItemMemoEdit3.Appearance.Options.UseTextOptions = true;
            this.repositoryItemMemoEdit3.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.repositoryItemMemoEdit3.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.repositoryItemMemoEdit3.Name = "repositoryItemMemoEdit3";
            // 
            // FrmClaimMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grid);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmClaimMonth";
            this.Size = new System.Drawing.Size(1277, 738);
            this.Load += new System.EventHandler(this.FrmMonthClaim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn cust_cd;
        private DevExpress.XtraGrid.Columns.GridColumn cust_nm;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn no;
        private DevExpress.XtraGrid.Columns.GridColumn rep_dt;
        private DevExpress.XtraGrid.Columns.GridColumn rmks;
        private DevExpress.XtraGrid.Columns.GridColumn clm_dt;
        private DevExpress.XtraGrid.Columns.GridColumn itm_nm;
        private DevExpress.XtraGrid.Columns.GridColumn itm_cd;
        private DevExpress.XtraGrid.Columns.GridColumn clm_type;
        private DevExpress.XtraGrid.Columns.GridColumn qty;
        private DevExpress.XtraGrid.Columns.GridColumn iss_amt;
        private DevExpress.XtraGrid.Columns.GridColumn clm_dsc;
        private DevExpress.XtraGrid.Columns.GridColumn chk_nm;
        private DevExpress.XtraGrid.Columns.GridColumn mc_nm;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit3;
    }
}
