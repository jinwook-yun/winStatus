using System;
using System.Windows.Forms;
using WinStatusBoard.View;
using WinStatusBoard.Data;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using DevExpress.XtraCharts;
using WinStatusLib.PageEvent;
using System.Diagnostics;

namespace WinStatusBoard.Page
{
    public partial class FrmClaimTopChart : UserControl
    {
        public PageEvent pageEvent = new PageEvent();
        ViewChart barPointChart = null;
        ViewChart pieChart = null;
        System.Timers.Timer timer = null;
        public FrmClaimTopChart()
        {
            InitializeComponent();
            InitializeTimer();

            Dock = DockStyle.Fill;

            DataSet dsClaimCustom = Query.ClaimCustom();
            DataTable pieData = dsClaimCustom.Tables[0];
            DataTable gridData = dsClaimCustom.Tables[1];
            pieChart = new ViewChart(claimChart);
            gridViewClaim.DataSource = gridData;

            pieChart.SeriesViewBases = new SeriesViewBase[] { new PieSeriesView() };
            pieChart.SeriesCount = 1;
            pieChart.SeriesMemberCount = pieData.Rows.Count;
            pieChart.SeriesMemberTitleColumnName = "cust_nm";
            pieChart.SeriesPointValueColumnName = new string[] { "rate" };

            string[] array2 = { "불만접수율" };
            pieChart.SetSeries(array2);
            pieChart.BindingChartData(pieData);

            DataTable data = Query.ClaimTopList();
            gridViewRate.DataSource = data;

            barPointChart = new ViewChart(chart);

            barPointChart.SeriesViewBases = new SeriesViewBase[] { new SideBySideBarSeriesView(), new LineSeriesView() };
            barPointChart.SeriesCount = 2;
            barPointChart.SeriesMemberCount = 5;
            barPointChart.SeriesMemberTitleColumnName = "clm_type";
            barPointChart.SeriesPointValueColumnName = new string[] { "clm_per", "clm_acc" };

            string[] array = { "구성비", "누적비" };
            barPointChart.SetSeries(array);
            barPointChart.BindingChartData(data);
            barPointChart.SetChartDiagram();
        }

        public void FrmBadTopChart_Load(object sender, EventArgs e)
        {
            StartTimer();
        }

        #region 타이머 이용한 반복작업
        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = Interval.DataReload;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.AutoReset = true;
            timer.Enabled = true;
            timer.Start();
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

            DataSet dsClaimCustom = Query.ClaimCustom();
            DataTable pieData = dsClaimCustom.Tables[0];
            DataTable gridData = dsClaimCustom.Tables[1];
            string[] array2 = { "불만접수율" };
            pieChart.SetSeries(array2);
            pieChart.BindingChartData(pieData);
            gridViewClaim.DataSource = gridData;

            DataTable data = Query.ClaimTopList();
            gridViewRate.DataSource = data;

            string[] array = { "구성비", "누적율" };
            barPointChart.SetSeries(array);
            barPointChart.BindingChartData(data);
        }

        public void SetTimerInterval()
        {
            if (timer != null)
            {
                timer.Interval = Interval.DataReload;
                Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} SetTimerInterval - {this.Name} timer.Interval : {timer.Interval.ToString()}");
            }
        }

        public void StartTimer()
        {
            timer.Start();
            Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} StartTimer - {this.Name}");
        }
        public void StopTimer()
        {
            timer.Stop();
            Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} StopTimer - {this.Name}");
        }
        public void CloseUserForm()
        {
            timer.Stop();
            timer.Dispose();
            Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} CloseUserForm - {this.Name}");
        }
        #endregion

        #region Grid 화면 정의
        private int GetRowHeight()
        {
            GridViewInfo viewInfo = (GridViewInfo)gridView.GetViewInfo();

            int gridHeight = gridViewRate.Size.Height;
            int headerHeight = viewInfo.ColumnRowHeight;
            int rowNum = gridView.RowCount;
            int rowHeight = (gridHeight - headerHeight) / rowNum;

            return rowHeight - 2;
        }

        private void gridView_CustomDrawColumnHeader(object sender, ColumnHeaderCustomDrawEventArgs e)
        {
            //if (gridView.RowCount > 0)
            //{
            //    int fontSize = Convert.ToInt32(GetRowHeight() * 0.2);
            //    e.Appearance.Font = new System.Drawing.Font("맑은 고딕", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            //}
        }
        private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int fontSize = Convert.ToInt32(GetRowHeight() * 0.33);
                fontSize = (fontSize >= 50) ? 40 : fontSize;
                e.Appearance.Font = new System.Drawing.Font("맑은 고딕", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            }
        }

        private void gridView_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e)
        {
            e.RowHeight = e.RowHeight = GetRowHeight();
        }

        #endregion
    }
}
