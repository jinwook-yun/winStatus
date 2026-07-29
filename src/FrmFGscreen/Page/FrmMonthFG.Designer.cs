namespace WinStatusBoard.Page
{
    partial class FrmMonthFG
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
            this.mc_gu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mc_cd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mc_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.planQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prodQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.progressRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.totTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.realTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.stopTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.operateRate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid
            // 
            this.Grid.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(0, 0);
            this.Grid.MainView = this.gridView;
            this.Grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(1257, 959);
            this.Grid.TabIndex = 0;
            this.Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridView.Appearance.HeaderPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.gridView.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridView.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridView.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gridView.Appearance.Row.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridView.Appearance.Row.Options.UseBackColor = true;
            this.gridView.Appearance.Row.Options.UseFont = true;
            this.gridView.Appearance.Row.Options.UseTextOptions = true;
            this.gridView.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridView.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridView.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.mc_gu,
            this.mc_cd,
            this.mc_nm,
            this.planQty,
            this.prodQty,
            this.progressRate,
            this.totTime,
            this.realTime,
            this.stopTime,
            this.operateRate});
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
            this.gridView.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None;
            this.gridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView_RowCellClick);
            this.gridView.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView_RowCellStyle);
            this.gridView.CalcRowHeight += new DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(this.gridView_CalcRowHeight);
            // 
            // mc_gu
            // 
            this.mc_gu.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.mc_gu.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray;
            this.mc_gu.AppearanceHeader.Options.UseBackColor = true;
            this.mc_gu.Caption = "설비구분";
            this.mc_gu.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.Value;
            this.mc_gu.Name = "mc_gu";
            this.mc_gu.Width = 20;
            // 
            // mc_cd
            // 
            this.mc_cd.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.mc_cd.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray;
            this.mc_cd.AppearanceHeader.Options.UseBackColor = true;
            this.mc_cd.Caption = "설비코드";
            this.mc_cd.FieldName = "mc_cd";
            this.mc_cd.MinWidth = 30;
            this.mc_cd.Name = "mc_cd";
            this.mc_cd.Width = 80;
            // 
            // mc_nm
            // 
            this.mc_nm.AppearanceCell.Options.UseTextOptions = true;
            this.mc_nm.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.mc_nm.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.mc_nm.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray;
            this.mc_nm.AppearanceHeader.Options.UseBackColor = true;
            this.mc_nm.Caption = "설비";
            this.mc_nm.FieldName = "mc_nm";
            this.mc_nm.Name = "mc_nm";
            this.mc_nm.Visible = true;
            this.mc_nm.VisibleIndex = 0;
            this.mc_nm.Width = 214;
            // 
            // planQty
            // 
            this.planQty.AppearanceCell.Options.UseTextOptions = true;
            this.planQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.planQty.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.planQty.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray;
            this.planQty.AppearanceHeader.Options.UseBackColor = true;
            this.planQty.Caption = "월간계획수량";
            this.planQty.DisplayFormat.FormatString = "#,##0";
            this.planQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.planQty.FieldName = "planQty";
            this.planQty.Name = "planQty";
            this.planQty.Visible = true;
            this.planQty.VisibleIndex = 1;
            this.planQty.Width = 223;
            // 
            // prodQty
            // 
            this.prodQty.AppearanceCell.Options.UseTextOptions = true;
            this.prodQty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.prodQty.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.prodQty.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray;
            this.prodQty.AppearanceHeader.Options.UseBackColor = true;
            this.prodQty.Caption = "월간실적수량";
            this.prodQty.DisplayFormat.FormatString = "#,##0";
            this.prodQty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.prodQty.FieldName = "prodQty";
            this.prodQty.Name = "prodQty";
            this.prodQty.Visible = true;
            this.prodQty.VisibleIndex = 2;
            this.prodQty.Width = 223;
            // 
            // progressRate
            // 
            this.progressRate.AppearanceCell.Options.UseTextOptions = true;
            this.progressRate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.progressRate.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.progressRate.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray;
            this.progressRate.AppearanceHeader.Options.UseBackColor = true;
            this.progressRate.Caption = "진도율";
            this.progressRate.DisplayFormat.FormatString = "P0";
            this.progressRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.progressRate.FieldName = "progressRate";
            this.progressRate.Name = "progressRate";
            this.progressRate.Visible = true;
            this.progressRate.VisibleIndex = 3;
            this.progressRate.Width = 135;
            // 
            // totTime
            // 
            this.totTime.AppearanceCell.Options.UseTextOptions = true;
            this.totTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.totTime.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.totTime.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray;
            this.totTime.AppearanceHeader.Options.UseBackColor = true;
            this.totTime.Caption = "부하시간";
            this.totTime.DisplayFormat.FormatString = "#,##0";
            this.totTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.totTime.FieldName = "totTime";
            this.totTime.Name = "totTime";
            // 
            // realTime
            // 
            this.realTime.AppearanceCell.Options.UseTextOptions = true;
            this.realTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.realTime.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.realTime.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray;
            this.realTime.AppearanceHeader.Options.UseBackColor = true;
            this.realTime.Caption = "가동시간";
            this.realTime.DisplayFormat.FormatString = "#,##0";
            this.realTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.realTime.FieldName = "realTime";
            this.realTime.Name = "realTime";
            this.realTime.Visible = true;
            this.realTime.VisibleIndex = 4;
            this.realTime.Width = 157;
            // 
            // stopTime
            // 
            this.stopTime.AppearanceCell.Options.UseTextOptions = true;
            this.stopTime.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.stopTime.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.stopTime.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray;
            this.stopTime.AppearanceHeader.Options.UseBackColor = true;
            this.stopTime.Caption = "비가동시간";
            this.stopTime.DisplayFormat.FormatString = "#,##0";
            this.stopTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.stopTime.FieldName = "stopTime";
            this.stopTime.Name = "stopTime";
            this.stopTime.Visible = true;
            this.stopTime.VisibleIndex = 5;
            this.stopTime.Width = 174;
            // 
            // operateRate
            // 
            this.operateRate.AppearanceCell.Options.UseTextOptions = true;
            this.operateRate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.operateRate.AppearanceHeader.BackColor = System.Drawing.Color.Gray;
            this.operateRate.AppearanceHeader.BackColor2 = System.Drawing.Color.Gray;
            this.operateRate.AppearanceHeader.Options.UseBackColor = true;
            this.operateRate.Caption = "가동률";
            this.operateRate.DisplayFormat.FormatString = "P0";
            this.operateRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.operateRate.FieldName = "operateRate";
            this.operateRate.Name = "operateRate";
            this.operateRate.Visible = true;
            this.operateRate.VisibleIndex = 6;
            this.operateRate.Width = 129;
            // 
            // FrmMonthFG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Grid);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FrmMonthFG";
            this.Size = new System.Drawing.Size(1257, 959);
            this.Load += new System.EventHandler(this.FrmMonthFG_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn mc_cd;
        private DevExpress.XtraGrid.Columns.GridColumn mc_gu;
        private DevExpress.XtraGrid.Columns.GridColumn mc_nm;
        private DevExpress.XtraGrid.Columns.GridColumn planQty;
        private DevExpress.XtraGrid.Columns.GridColumn prodQty;
        private DevExpress.XtraGrid.Columns.GridColumn progressRate;
        private DevExpress.XtraGrid.Columns.GridColumn realTime;
        private DevExpress.XtraGrid.Columns.GridColumn stopTime;
        private DevExpress.XtraGrid.Columns.GridColumn operateRate;
        private DevExpress.XtraGrid.Columns.GridColumn totTime;
    }
}
