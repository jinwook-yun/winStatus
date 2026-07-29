namespace WinStatusBoard
{
    partial class FrmProd
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
            this.mc_cd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itm_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.itm_cd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plan_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.plan_week = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prod_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.weekout_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prod_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.raw_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mold_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.menuHF = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuFP = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuLocal = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuExport = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.menuMaterial = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.MainView = this.gridView;
            this.Grid.Margin = new System.Windows.Forms.Padding(0);
            this.Grid.Name = "Grid";
            this.Grid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemMemoEdit2});
            this.Grid.Size = new System.Drawing.Size(1786, 905);
            this.Grid.TabIndex = 6;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("맑은 고딕", 17F, System.Drawing.FontStyle.Bold);
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
            this.mc_cd,
            this.no,
            this.itm_nm,
            this.itm_cd,
            this.plan_qty,
            this.plan_week,
            this.prod_qty,
            this.weekout_qty,
            this.prod_stock,
            this.raw_qty,
            this.mold_stock});
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
            this.gridView.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.OptionsView.ShowGroupPanel = false;
            this.gridView.OptionsView.ShowIndicator = false;
            this.gridView.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.gridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.gridView.RowHeight = 100;
            this.gridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None;
            this.gridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_RowCellStyle);
            this.gridView.CalcRowHeight += new DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(this.gridView_CalcRowHeight);
            // 
            // mc_cd
            // 
            this.mc_cd.Caption = "설비코드";
            this.mc_cd.FieldName = "cust_cd";
            this.mc_cd.MinWidth = 1000;
            this.mc_cd.Name = "mc_cd";
            this.mc_cd.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.True;
            this.mc_cd.Width = 3575;
            // 
            // no
            // 
            this.no.Caption = "No";
            this.no.FieldName = "no";
            this.no.MinWidth = 70;
            this.no.Name = "no";
            this.no.OptionsColumn.FixedWidth = true;
            this.no.Visible = true;
            this.no.VisibleIndex = 0;
            this.no.Width = 70;
            // 
            // itm_nm
            // 
            this.itm_nm.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.itm_nm.AppearanceCell.Options.UseFont = true;
            this.itm_nm.AppearanceCell.Options.UseTextOptions = true;
            this.itm_nm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.itm_nm.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.itm_nm.Caption = "품명";
            this.itm_nm.ColumnEdit = this.repositoryItemMemoEdit2;
            this.itm_nm.FieldName = "itm_nm";
            this.itm_nm.MinWidth = 150;
            this.itm_nm.Name = "itm_nm";
            this.itm_nm.Visible = true;
            this.itm_nm.VisibleIndex = 1;
            this.itm_nm.Width = 291;
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
            this.itm_cd.MinWidth = 150;
            this.itm_cd.Name = "itm_cd";
            this.itm_cd.Visible = true;
            this.itm_cd.VisibleIndex = 2;
            this.itm_cd.Width = 319;
            // 
            // plan_qty
            // 
            this.plan_qty.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.plan_qty.AppearanceCell.Options.UseFont = true;
            this.plan_qty.AppearanceCell.Options.UseTextOptions = true;
            this.plan_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.plan_qty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.plan_qty.Caption = "월간계획수량";
            this.plan_qty.FieldName = "mon_plan_qty";
            this.plan_qty.MinWidth = 150;
            this.plan_qty.Name = "plan_qty";
            this.plan_qty.Visible = true;
            this.plan_qty.VisibleIndex = 3;
            this.plan_qty.Width = 256;
            // 
            // plan_week
            // 
            this.plan_week.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.plan_week.AppearanceCell.Options.UseFont = true;
            this.plan_week.AppearanceCell.Options.UseTextOptions = true;
            this.plan_week.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.plan_week.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.plan_week.Caption = "주간계획수량";
            this.plan_week.FieldName = "week_plan_qty";
            this.plan_week.MinWidth = 150;
            this.plan_week.Name = "plan_week";
            this.plan_week.Visible = true;
            this.plan_week.VisibleIndex = 4;
            this.plan_week.Width = 275;
            // 
            // prod_qty
            // 
            this.prod_qty.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.prod_qty.AppearanceCell.Options.UseFont = true;
            this.prod_qty.AppearanceCell.Options.UseTextOptions = true;
            this.prod_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.prod_qty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.prod_qty.Caption = "주간생산실적";
            this.prod_qty.FieldName = "prod_qty";
            this.prod_qty.MinWidth = 150;
            this.prod_qty.Name = "prod_qty";
            this.prod_qty.Visible = true;
            this.prod_qty.VisibleIndex = 5;
            this.prod_qty.Width = 256;
            // 
            // weekout_qty
            // 
            this.weekout_qty.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.weekout_qty.AppearanceCell.Options.UseFont = true;
            this.weekout_qty.AppearanceCell.Options.UseTextOptions = true;
            this.weekout_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.weekout_qty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.weekout_qty.Caption = "주간출하계획수량";
            this.weekout_qty.FieldName = "out_plan_qty";
            this.weekout_qty.MinWidth = 150;
            this.weekout_qty.Name = "weekout_qty";
            this.weekout_qty.Width = 166;
            // 
            // prod_stock
            // 
            this.prod_stock.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.prod_stock.AppearanceCell.Options.UseFont = true;
            this.prod_stock.AppearanceCell.Options.UseTextOptions = true;
            this.prod_stock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.prod_stock.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.prod_stock.Caption = "총 재고";
            this.prod_stock.FieldName = "tot_stock";
            this.prod_stock.MinWidth = 150;
            this.prod_stock.Name = "prod_stock";
            this.prod_stock.Visible = true;
            this.prod_stock.VisibleIndex = 6;
            this.prod_stock.Width = 224;
            // 
            // raw_qty
            // 
            this.raw_qty.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.raw_qty.AppearanceCell.Options.UseFont = true;
            this.raw_qty.AppearanceCell.Options.UseTextOptions = true;
            this.raw_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.raw_qty.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.raw_qty.Caption = "원자재 재고";
            this.raw_qty.FieldName = "mat_stock";
            this.raw_qty.MinWidth = 150;
            this.raw_qty.Name = "raw_qty";
            this.raw_qty.Visible = true;
            this.raw_qty.VisibleIndex = 8;
            this.raw_qty.Width = 231;
            // 
            // mold_stock
            // 
            this.mold_stock.AppearanceCell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Bold);
            this.mold_stock.AppearanceCell.Options.UseFont = true;
            this.mold_stock.AppearanceCell.Options.UseTextOptions = true;
            this.mold_stock.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.mold_stock.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.mold_stock.Caption = "금형재고";
            this.mold_stock.FieldName = "mold_stock";
            this.mold_stock.MinWidth = 30;
            this.mold_stock.Name = "mold_stock";
            this.mold_stock.Visible = true;
            this.mold_stock.VisibleIndex = 7;
            this.mold_stock.Width = 179;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.accordionControl1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Grid);
            this.splitContainer2.Size = new System.Drawing.Size(2035, 905);
            this.splitContainer2.SplitterDistance = 248;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 1;
            // 
            // accordionControl1
            // 
            this.accordionControl1.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Simple;
            this.accordionControl1.Appearance.AccordionControl.Font = new System.Drawing.Font("맑은 고딕", 15F);
            this.accordionControl1.Appearance.AccordionControl.Options.UseFont = true;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.menuHF,
            this.menuFP,
            this.menuLocal,
            this.menuExport,
            this.menuMaterial});
            this.accordionControl1.GroupHeight = 60;
            this.accordionControl1.ItemHeight = 50;
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Margin = new System.Windows.Forms.Padding(0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Hidden;
            this.accordionControl1.Size = new System.Drawing.Size(248, 905);
            this.accordionControl1.TabIndex = 9;
            this.accordionControl1.Text = "accordionControl1";
            this.accordionControl1.ElementClick += new DevExpress.XtraBars.Navigation.ElementClickEventHandler(this.accordionControl1_ElementClick);
            this.accordionControl1.CustomDrawElement += new DevExpress.XtraBars.Navigation.CustomDrawElementEventHandler(this.accordionControl1_CustomDrawElement);
            // 
            // menuHF
            // 
            this.menuHF.Appearance.Hovered.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuHF.Appearance.Hovered.Options.UseFont = true;
            this.menuHF.Appearance.Normal.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.menuHF.Appearance.Normal.Options.UseFont = true;
            this.menuHF.Appearance.Pressed.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.menuHF.Appearance.Pressed.Options.UseFont = true;
            this.menuHF.Expanded = true;
            this.menuHF.Name = "menuHF";
            this.menuHF.Text = "H/F";
            // 
            // menuFP
            // 
            this.menuFP.Appearance.Hovered.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuFP.Appearance.Hovered.Options.UseFont = true;
            this.menuFP.Appearance.Normal.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.menuFP.Appearance.Normal.Options.UseFont = true;
            this.menuFP.Appearance.Pressed.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.menuFP.Appearance.Pressed.Options.UseFont = true;
            this.menuFP.Expanded = true;
            this.menuFP.Name = "menuFP";
            this.menuFP.Text = "F/P";
            // 
            // menuLocal
            // 
            this.menuLocal.Appearance.Hovered.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuLocal.Appearance.Hovered.Options.UseFont = true;
            this.menuLocal.Appearance.Normal.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.menuLocal.Appearance.Normal.Options.UseFont = true;
            this.menuLocal.Appearance.Pressed.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.menuLocal.Appearance.Pressed.Options.UseFont = true;
            this.menuLocal.ControlFooterAlignment = DevExpress.XtraBars.Navigation.AccordionItemFooterAlignment.Far;
            this.menuLocal.Name = "menuLocal";
            this.menuLocal.Text = "내수제품재고";
            this.menuLocal.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuExport
            // 
            this.menuExport.Appearance.Hovered.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuExport.Appearance.Hovered.Options.UseFont = true;
            this.menuExport.Appearance.Normal.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.menuExport.Appearance.Normal.Options.UseFont = true;
            this.menuExport.Appearance.Pressed.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.menuExport.Appearance.Pressed.Options.UseFont = true;
            this.menuExport.Name = "menuExport";
            this.menuExport.Text = "수출제품재고";
            this.menuExport.Click += new System.EventHandler(this.menu_Click);
            // 
            // menuMaterial
            // 
            this.menuMaterial.Appearance.Hovered.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuMaterial.Appearance.Hovered.Options.UseFont = true;
            this.menuMaterial.Appearance.Normal.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.menuMaterial.Appearance.Normal.Options.UseFont = true;
            this.menuMaterial.Appearance.Pressed.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.menuMaterial.Appearance.Pressed.Options.UseFont = true;
            this.menuMaterial.Expanded = true;
            this.menuMaterial.Name = "menuMaterial";
            this.menuMaterial.Text = "원자재재고";
            this.menuMaterial.Click += new System.EventHandler(this.menu_Click);
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "Element3";
            // 
            // accordionControlElement4
            // 
            this.accordionControlElement4.Name = "accordionControlElement4";
            this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement4.Text = "Element4";
            // 
            // FrmProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer2);
            this.Name = "FrmProd";
            this.Size = new System.Drawing.Size(2035, 905);
            this.Load += new System.EventHandler(this.FrmProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn mc_cd;
        private DevExpress.XtraGrid.Columns.GridColumn no;
        private DevExpress.XtraGrid.Columns.GridColumn itm_nm;
        private DevExpress.XtraGrid.Columns.GridColumn itm_cd;
        private DevExpress.XtraGrid.Columns.GridColumn plan_qty;
        private DevExpress.XtraGrid.Columns.GridColumn plan_week;
        private DevExpress.XtraGrid.Columns.GridColumn prod_qty;
        private DevExpress.XtraGrid.Columns.GridColumn weekout_qty;
        private DevExpress.XtraGrid.Columns.GridColumn prod_stock;
        private DevExpress.XtraGrid.Columns.GridColumn raw_qty;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuHF;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuFP;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuLocal;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuExport;
        private DevExpress.XtraBars.Navigation.AccordionControlElement menuMaterial;
        private DevExpress.XtraGrid.Columns.GridColumn mold_stock;
    }
}
