namespace WinStatusBoard.Page
{
    partial class FrmClaimAmt
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
            this.rmks = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mc_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.chk_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.act_dsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.amt = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clm_dsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itm_cd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.itm_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cust_nm = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pivotGridControl1 = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.filedPVCustNM = new DevExpress.XtraPivotGrid.PivotGridField();
            this.filedPVDate = new DevExpress.XtraPivotGrid.PivotGridField();
            this.fieldPVAMT = new DevExpress.XtraPivotGrid.PivotGridField();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // rmks
            // 
            this.rmks.AppearanceCell.Options.UseTextOptions = true;
            this.rmks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.rmks.Caption = "비고";
            this.rmks.FieldName = "rmks";
            this.rmks.Name = "rmks";
            this.rmks.OptionsColumn.AllowEdit = false;
            this.rmks.OptionsColumn.AllowFocus = false;
            this.rmks.Width = 271;
            // 
            // mc_nm
            // 
            this.mc_nm.Caption = "설비구분";
            this.mc_nm.FieldName = "mc_nm";
            this.mc_nm.MinWidth = 30;
            this.mc_nm.Name = "mc_nm";
            this.mc_nm.Width = 139;
            // 
            // chk_nm
            // 
            this.chk_nm.Caption = "확인자";
            this.chk_nm.FieldName = "chk_nm";
            this.chk_nm.MinWidth = 30;
            this.chk_nm.Name = "chk_nm";
            this.chk_nm.Width = 191;
            // 
            // act_dsc
            // 
            this.act_dsc.Caption = "처리내역";
            this.act_dsc.FieldName = "act_dsc";
            this.act_dsc.MinWidth = 30;
            this.act_dsc.Name = "act_dsc";
            this.act_dsc.Width = 139;
            // 
            // amt
            // 
            this.amt.Caption = "손실금액";
            this.amt.FieldName = "amt";
            this.amt.MinWidth = 30;
            this.amt.Name = "amt";
            this.amt.Width = 139;
            // 
            // qty
            // 
            this.qty.Caption = "불량수량";
            this.qty.FieldName = "qty";
            this.qty.MinWidth = 30;
            this.qty.Name = "qty";
            this.qty.Width = 139;
            // 
            // clm_dsc
            // 
            this.clm_dsc.Caption = "클레임 내역";
            this.clm_dsc.FieldName = "clm_dsc";
            this.clm_dsc.MinWidth = 30;
            this.clm_dsc.Name = "clm_dsc";
            this.clm_dsc.Width = 139;
            // 
            // itm_cd
            // 
            this.itm_cd.Caption = "품번";
            this.itm_cd.FieldName = "itm_cd";
            this.itm_cd.MinWidth = 30;
            this.itm_cd.Name = "itm_cd";
            this.itm_cd.Width = 139;
            // 
            // itm_nm
            // 
            this.itm_nm.Caption = "품명";
            this.itm_nm.FieldName = "itm_nm";
            this.itm_nm.MinWidth = 30;
            this.itm_nm.Name = "itm_nm";
            this.itm_nm.Width = 139;
            // 
            // cust_nm
            // 
            this.cust_nm.AppearanceCell.Options.UseTextOptions = true;
            this.cust_nm.AppearanceCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.cust_nm.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.cust_nm.Caption = "수주업체";
            this.cust_nm.FieldName = "cust_nm";
            this.cust_nm.Name = "cust_nm";
            this.cust_nm.OptionsColumn.AllowEdit = false;
            this.cust_nm.OptionsColumn.AllowFocus = false;
            this.cust_nm.OptionsColumn.FixedWidth = true;
            this.cust_nm.Width = 262;
            // 
            // pivotGridControl1
            // 
            this.pivotGridControl1.Appearance.Cell.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pivotGridControl1.Appearance.Cell.Options.UseFont = true;
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.pivotGridControl1.Appearance.ColumnHeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.CustomTotalCell.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.pivotGridControl1.Appearance.CustomTotalCell.Options.UseFont = true;
            this.pivotGridControl1.Appearance.DataHeaderArea.Font = new System.Drawing.Font("맑은 고딕", 20F);
            this.pivotGridControl1.Appearance.DataHeaderArea.Options.UseFont = true;
            this.pivotGridControl1.Appearance.FieldValue.Font = new System.Drawing.Font("맑은 고딕", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pivotGridControl1.Appearance.FieldValue.Options.UseFont = true;
            this.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pivotGridControl1.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] {
            this.filedPVCustNM,
            this.filedPVDate,
            this.fieldPVAMT});
            this.pivotGridControl1.Location = new System.Drawing.Point(0, 0);
            this.pivotGridControl1.Name = "pivotGridControl1";
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotalHeader = false;
            this.pivotGridControl1.OptionsView.ShowColumnGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowColumnHeaders = false;
            this.pivotGridControl1.OptionsView.ShowColumnTotals = false;
            this.pivotGridControl1.OptionsView.ShowDataHeaders = false;
            this.pivotGridControl1.OptionsView.ShowFilterHeaders = false;
            this.pivotGridControl1.OptionsView.ShowRowGrandTotals = false;
            this.pivotGridControl1.OptionsView.ShowRowHeaders = false;
            this.pivotGridControl1.OptionsView.ShowRowTotals = false;
            this.pivotGridControl1.Size = new System.Drawing.Size(1277, 738);
            this.pivotGridControl1.TabIndex = 2;
            // 
            // filedPVCustNM
            // 
            this.filedPVCustNM.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.filedPVCustNM.AreaIndex = 0;
            this.filedPVCustNM.FieldName = "cust_nm";
            this.filedPVCustNM.Name = "filedPVCustNM";
            this.filedPVCustNM.Width = 250;
            // 
            // filedPVDate
            // 
            this.filedPVDate.Appearance.Header.Options.UseTextOptions = true;
            this.filedPVDate.Appearance.Header.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.filedPVDate.Appearance.Value.Options.UseTextOptions = true;
            this.filedPVDate.Appearance.Value.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.filedPVDate.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.filedPVDate.AreaIndex = 0;
            this.filedPVDate.FieldName = "mon";
            this.filedPVDate.Name = "filedPVDate";
            this.filedPVDate.Width = 171;
            // 
            // fieldPVAMT
            // 
            this.fieldPVAMT.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldPVAMT.AreaIndex = 0;
            this.fieldPVAMT.CellFormat.FormatString = "N0";
            this.fieldPVAMT.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fieldPVAMT.FieldName = "amt";
            this.fieldPVAMT.Name = "fieldPVAMT";
            // 
            // FrmClaimAmt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pivotGridControl1);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmClaimAmt";
            this.Size = new System.Drawing.Size(1277, 738);
            this.Load += new System.EventHandler(this.FrmCustomLoss_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn rmks;
        private DevExpress.XtraGrid.Columns.GridColumn mc_nm;
        private DevExpress.XtraGrid.Columns.GridColumn chk_nm;
        private DevExpress.XtraGrid.Columns.GridColumn act_dsc;
        private DevExpress.XtraGrid.Columns.GridColumn amt;
        private DevExpress.XtraGrid.Columns.GridColumn qty;
        private DevExpress.XtraGrid.Columns.GridColumn clm_dsc;
        private DevExpress.XtraGrid.Columns.GridColumn itm_cd;
        private DevExpress.XtraGrid.Columns.GridColumn itm_nm;
        private DevExpress.XtraGrid.Columns.GridColumn cust_nm;
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl1;
        private DevExpress.XtraPivotGrid.PivotGridField filedPVCustNM;
        private DevExpress.XtraPivotGrid.PivotGridField filedPVDate;
        private DevExpress.XtraPivotGrid.PivotGridField fieldPVAMT;
    }
}
