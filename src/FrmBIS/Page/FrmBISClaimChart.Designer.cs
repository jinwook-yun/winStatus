namespace WinStatusBoard.Page
{
    partial class FrmBISClaimChart
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.filedPVGrpBc = new DevExpress.XtraPivotGrid.PivotGridField();
            this.filedPVDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPVQTY = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pivotGridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1277, 738);
            this.splitContainer1.SplitterDistance = 418;
            this.splitContainer1.TabIndex = 1;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Appearance.Cell.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.pivotGridControl1.Appearance.Cell.Options.UseFont = true;
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("맑은 고딕", 18F);
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Options.UseTextOptions = true;
            this.pivotGridControl1.Appearance.ColumnHeaderArea.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.pivotGridControl1.Appearance.CustomTotalCell.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.pivotGridControl1.Appearance.CustomTotalCell.Options.UseFont = true;
            this.pivotGridControl1.Appearance.DataHeaderArea.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.pivotGridControl1.Appearance.DataHeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.FieldValue.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.pivotGridControl1.Appearance.FieldValue.Options.UseFont = true;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.filedPVGrpBc,
            this.filedPVDate,
            this.fieldPVQTY});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsDataField.ColumnValueLineCount = 2;
            this.pivotGridControl1.OptionsOLAP.SortByCustomFieldValueDisplayText = true;
            this.pivotGridControl1.OptionsView.AllowHtmlDrawFieldValues = true;
            this.pivotGridControl1.OptionsView.AllowHtmlDrawHeaders = true;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowRowHeaders = false;
            this.pivotGridControl1.OptionsView.ShowRowTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(1277, 316);
            this.pivotGridControl1.TabIndex = 1;
            this.pivotGridControl1.CustomServerModeSort += new System.EventHandler<DevExpress.XtraPivotGrid.CustomServerModeSortEventArgs>(this.pivotGridControl1_CustomServerModeSort);
            // 
            // filedPVGrpBc
            // 
            this.filedPVGrpBc.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.filedPVGrpBc.AreaIndex = 0;
            this.filedPVGrpBc.FieldName = "grp_bc";
            this.filedPVGrpBc.Name = "filedPVGrpBc";
            this.filedPVGrpBc.SortByAttribute = "";
            this.filedPVGrpBc.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom;
            this.filedPVGrpBc.Width = 250;
            // 
            // filedPVDate
            // 
            this.filedPVDate.Appearance.Header.Font = new System.Drawing.Font("Tahoma", 7.2F);
            this.filedPVDate.Appearance.Header.Options.UseFont = true;
            this.filedPVDate.Appearance.Header.Options.UseTextOptions = true;
            this.filedPVDate.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.filedPVDate.Appearance.Header.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.filedPVDate.Appearance.Value.Options.UseTextOptions = true;
            this.filedPVDate.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.filedPVDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.filedPVDate.AreaIndex = 0;
            this.filedPVDate.ColumnValueLineCount = 2;
            this.filedPVDate.FieldName = "mon";
            this.filedPVDate.Name = "filedPVDate";
            this.filedPVDate.RowValueLineCount = 2;
            this.filedPVDate.SortByAttribute = "";
            this.filedPVDate.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom;
            this.filedPVDate.Width = 226;
            // 
            // fieldPVQTY
            // 
            this.fieldPVQTY.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPVQTY.AreaIndex = 0;
            this.fieldPVQTY.CellFormat.FormatString = "N0";
            this.fieldPVQTY.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPVQTY.ColumnValueLineCount = 2;
            this.fieldPVQTY.FieldName = "qty";
            this.fieldPVQTY.Name = "fieldPVQTY";
            this.fieldPVQTY.SortByAttribute = "";
            this.fieldPVQTY.SortMode = DevExpress.XtraPivotGrid.PivotSortMode.Custom;
            // 
            // FrmBISClaimChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmBISClaimChart";
            this.Size = new System.Drawing.Size(1277, 738);
            this.Load += new System.EventHandler(this.FrmClaimChart_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField filedPVGrpBc;
        private DevExpress.XtraPivotGrid.PivotGridField filedPVDate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPVQTY;
    }
}
