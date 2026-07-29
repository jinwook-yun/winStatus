using System;
using System.Drawing;
using WinStatusBoard.Data;
using System.Windows.Forms;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using WinStatusLib.PageEvent;
using System.Diagnostics;

namespace WinStatusBoard.Page
{
    public partial class FrmMonthFG : UserControl
    {
        public PageEvent pageEvent = new PageEvent();
        System.Timers.Timer timer = null;
        public FrmMonthFG()
        {
            InitializeComponent();
            InitializeTimer();

            Dock = DockStyle.Fill;                    
        }

        private void FrmMonthFG_Load(object sender, EventArgs e)
        {
            DataLoad();
            this.gridView.RowStyle += grid_RowStyle;
        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = Interval.DataReload;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new TimerEventFiredDelegate(DataLoad));
            }
        }
        public void DataLoad()
        {
            Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} DataLoad - {this.Name} timer.Interval : {timer.Interval.ToString()}");
            Grid.DataSource = Query.MonthFGData();
        }

        public void SetTimerInterval()
        {
            if (timer != null)
            {
                timer.Interval = Interval.DataReload;
                Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} SetTimerInterval - {this.Name} timer.Interval : {timer.Interval.ToString()}");
            }
        }      

        #region Grid 화면 정의

        private int GetRowHeight()
        {
            GridViewInfo viewInfo = (GridViewInfo)gridView.GetViewInfo();

            int gridHeight = Grid.Size.Height;
            int headerHeight = viewInfo.ColumnRowHeight;
            int rowNum = gridView.RowCount;
            int rowHeight = (gridHeight - headerHeight) / rowNum;

            return rowHeight;
        }

        private void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int fontSize = Convert.ToInt32(GetRowHeight() * 0.33);
                fontSize = (fontSize >= 50) ? 40 : fontSize;
                e.Appearance.Font = new System.Drawing.Font("맑은 고딕", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            }
        }

        private void gridView_CalcRowHeight(object sender, RowHeightEventArgs e)
        {
            e.RowHeight = e.RowHeight = GetRowHeight(); ;
        }

        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //Dictionary<string, string> dicParam = new Dictionary<string, string>();

            if (e.RowHandle >= 0)
            {
                string mcMn = gridView.GetRowCellDisplayText(e.RowHandle, gridView.Columns["mc_nm"]);             
                string mccd = gridView.GetRowCellDisplayText(e.RowHandle, gridView.Columns["mc_cd"]);

                if (mccd != "9999")
                { 
                    //Dictionary<string, string> mchParam = new Dictionary<string, string>();
                    //mchParam.Add("mc_cd", mccd);

                    //Query.QueryParam = mchParam;
                    ////Query.MchInfoProdGDate();
                    FrmPopUp frmPopUp = new FrmPopUp();
                    frmPopUp.StartPosition = FormStartPosition.CenterParent;
                    frmPopUp.lblMachine.Text = mcMn;
                    frmPopUp.vMchNO = mccd;
                    frmPopUp.ShowDialog();
                }

            }
        }

        private void grid_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            
            if (e.RowHandle >= 0)
            {
                string mcnm = gridView.GetRowCellDisplayText(e.RowHandle, gridView.Columns["mc_nm"]);
                if (mcnm =="소 계")
                {
                    e.Appearance.BackColor = Color.Gainsboro;
                    e.Appearance.BackColor2 = Color.WhiteSmoke;
                }
            }

        }


        #endregion        
    }
}
