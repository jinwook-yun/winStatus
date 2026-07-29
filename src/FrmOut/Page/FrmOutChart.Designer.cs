namespace WinStatusBoard.Page
{
    partial class FrmOutChart
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
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GridMonth = new DevExpress.XtraGrid.GridControl();
            this.bgGrid = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.de_nm = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.so_amt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.out_amt = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.amt_rate = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.de_bc = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.chart = new DevExpress.XtraCharts.ChartControl();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.GridMonth, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chart, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.69141F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.30859F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1298, 862);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // GridMonth
            // 
            this.GridMonth.AllowRestoreSelectionAndFocusedRow = DevExpress.Utils.DefaultBoolean.False;
            this.GridMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridMonth.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GridMonth.Location = new System.Drawing.Point(0, 0);
            this.GridMonth.MainView = this.bgGrid;
            this.GridMonth.Margin = new System.Windows.Forms.Padding(0);
            this.GridMonth.Name = "GridMonth";
            this.GridMonth.Size = new System.Drawing.Size(1298, 367);
            this.GridMonth.TabIndex = 3;
            this.GridMonth.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.bgGrid});
            // 
            // bgGrid
            // 
            this.bgGrid.Appearance.BandPanel.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bgGrid.Appearance.BandPanel.Options.UseFont = true;
            this.bgGrid.Appearance.BandPanel.Options.UseTextOptions = true;
            this.bgGrid.Appearance.BandPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgGrid.Appearance.HeaderPanel.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bgGrid.Appearance.HeaderPanel.Options.UseFont = true;
            this.bgGrid.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.bgGrid.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgGrid.Appearance.Row.Font = new System.Drawing.Font("맑은 고딕", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bgGrid.Appearance.Row.Options.UseFont = true;
            this.bgGrid.Appearance.Row.Options.UseTextOptions = true;
            this.bgGrid.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.bgGrid.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.bgGrid.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand3,
            this.gridBand4,
            this.gridBand2});
            this.bgGrid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.bgGrid.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.de_bc,
            this.de_nm,
            this.so_amt,
            this.out_amt,
            this.amt_rate});
            this.bgGrid.DetailHeight = 500;
            this.bgGrid.FixedLineWidth = 3;
            this.bgGrid.GridControl = this.GridMonth;
            this.bgGrid.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.bgGrid.Name = "bgGrid";
            this.bgGrid.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.bgGrid.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.bgGrid.OptionsBehavior.Editable = false;
            this.bgGrid.OptionsBehavior.ReadOnly = true;
            this.bgGrid.OptionsCustomization.AllowSort = false;
            this.bgGrid.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.bgGrid.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.bgGrid.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.bgGrid.OptionsView.ShowGroupPanel = false;
            this.bgGrid.OptionsView.ShowIndicator = false;
            this.bgGrid.OptionsView.ShowPreviewRowLines = DevExpress.Utils.DefaultBoolean.False;
            this.bgGrid.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.bgGrid.ScrollStyle = DevExpress.XtraGrid.Views.Grid.ScrollStyleFlags.None;
            this.bgGrid.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.bgGrid.CustomDrawBandHeader += new DevExpress.XtraGrid.Views.BandedGrid.BandHeaderCustomDrawEventHandler(this.bgGrid_CustomDrawBandHeader);
            this.bgGrid.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.bgGrid_RowCellClick);
            this.bgGrid.CustomDrawColumnHeader += new DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventHandler(this.bgGrid_CustomDrawColumnHeader);
            this.bgGrid.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.bgGrid_RowCellStyle);
            this.bgGrid.CalcRowHeight += new DevExpress.XtraGrid.Views.Grid.RowHeightEventHandler(this.bgGrid_CalcRowHeight);
            // 
            // gridBand1
            // 
            this.gridBand1.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand1.Caption = "구분";
            this.gridBand1.Columns.Add(this.de_nm);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = 0;
            this.gridBand1.Width = 240;
            // 
            // de_nm
            // 
            this.de_nm.Caption = "구분";
            this.de_nm.FieldName = "de_nm";
            this.de_nm.Name = "de_nm";
            this.de_nm.OptionsColumn.AllowEdit = false;
            this.de_nm.OptionsColumn.AllowFocus = false;
            this.de_nm.Visible = true;
            this.de_nm.Width = 240;
            // 
            // gridBand3
            // 
            this.gridBand3.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand3.Caption = "생산실적";
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Visible = false;
            this.gridBand3.VisibleIndex = -1;
            this.gridBand3.Width = 115;
            // 
            // gridBand4
            // 
            this.gridBand4.AppearanceHeader.Options.UseTextOptions = true;
            this.gridBand4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridBand4.Caption = "목표달성율";
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Visible = false;
            this.gridBand4.VisibleIndex = -1;
            this.gridBand4.Width = 116;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "2019년 11월 판매계획";
            this.gridBand2.Columns.Add(this.so_amt);
            this.gridBand2.Columns.Add(this.out_amt);
            this.gridBand2.Columns.Add(this.amt_rate);
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.VisibleIndex = 1;
            this.gridBand2.Width = 835;
            // 
            // so_amt
            // 
            this.so_amt.AppearanceCell.Options.UseTextOptions = true;
            this.so_amt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.so_amt.Caption = "11월 판매계획";
            this.so_amt.FieldName = "so_amt";
            this.so_amt.Name = "so_amt";
            this.so_amt.OptionsColumn.AllowEdit = false;
            this.so_amt.OptionsColumn.AllowFocus = false;
            this.so_amt.Visible = true;
            this.so_amt.Width = 343;
            // 
            // out_amt
            // 
            this.out_amt.AppearanceCell.Options.UseTextOptions = true;
            this.out_amt.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.out_amt.Caption = "출하실적누계";
            this.out_amt.FieldName = "out_amt";
            this.out_amt.Name = "out_amt";
            this.out_amt.OptionsColumn.AllowEdit = false;
            this.out_amt.OptionsColumn.AllowFocus = false;
            this.out_amt.Visible = true;
            this.out_amt.Width = 309;
            // 
            // amt_rate
            // 
            this.amt_rate.AppearanceCell.Options.UseTextOptions = true;
            this.amt_rate.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.amt_rate.Caption = "진도율";
            this.amt_rate.FieldName = "amt_rate";
            this.amt_rate.Name = "amt_rate";
            this.amt_rate.OptionsColumn.AllowEdit = false;
            this.amt_rate.OptionsColumn.AllowFocus = false;
            this.amt_rate.Visible = true;
            this.amt_rate.Width = 183;
            // 
            // de_bc
            // 
            this.de_bc.Caption = "구분코드";
            this.de_bc.FieldName = "de_bc";
            this.de_bc.Name = "de_bc";
            // 
            // chart
            // 
            this.chart.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.Center;
            this.chart.Legend.MarkerSize = new System.Drawing.Size(20, 30);
            this.chart.Legend.Name = "Default Legend";
            this.chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chart.Location = new System.Drawing.Point(0, 367);
            this.chart.Margin = new System.Windows.Forms.Padding(0);
            this.chart.Name = "chart";
            this.chart.Padding.Bottom = 10;
            this.chart.Padding.Left = 25;
            this.chart.Padding.Right = 25;
            this.chart.Padding.Top = 10;
            this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chart.Size = new System.Drawing.Size(1298, 495);
            this.chart.TabIndex = 2;
            chartTitle1.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            chartTitle1.Text = "월간 진도현황";
            this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // FrmOutChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "FrmOutChart";
            this.Size = new System.Drawing.Size(1298, 862);
            this.Load += new System.EventHandler(this.FrmOut_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bgGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl GridMonth;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bgGrid;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn de_nm;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn so_amt;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn out_amt;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn amt_rate;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn de_bc;
        private DevExpress.XtraCharts.ChartControl chart;
    }
}
