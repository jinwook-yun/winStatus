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
    public partial class FrmBadTopList : UserControl
    {
        public PageEvent pageEvent = new PageEvent();
        System.Timers.Timer timer = null;
        ViewChart barPointChart = null;
        public FrmBadTopList()
        {
            InitializeComponent();
            InitializeTimer();

            DataTable data = Query.BadTopList();
            Grid.DataSource = data;

            barPointChart = new ViewChart(chart);

            barPointChart.SeriesViewBases = new SeriesViewBase[] { new SideBySideBarSeriesView(), new LineSeriesView() };
            barPointChart.SeriesCount = 2;
            barPointChart.SeriesMemberCount = 5;
            barPointChart.SeriesMemberTitleColumnName = "bad_nm";
            barPointChart.SeriesPointValueColumnName = new string[] { "bad_per", "bad_acc" };

            string[] array = { "구성비", "누적비" };
            barPointChart.SetSeries(array);
            barPointChart.BindingChartData(data);
            barPointChart.SetChartDiagram();

            //barPointChart.SetChartTitle(Query.WorkDate);    

            Dock = DockStyle.Fill;
        }

        public void FrmBadTopList_Load(object sender, EventArgs e)
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
            DataTable data = Query.BadTopList();
            Grid.DataSource = data;

            string[] array = { "구성비", "누적비" };
            barPointChart.SetSeries(array);
            barPointChart.BindingChartData(data);

            // barPointChart.SetChartTitle(Query.WorkDate);
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

            int gridHeight = Grid.Size.Height;
            int headerHeight = viewInfo.ColumnRowHeight;
            int rowNum = gridView.RowCount;
            int rowHeight = (gridHeight - headerHeight) / rowNum;

            return rowHeight;
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
                int fontSize = Convert.ToInt32(GetRowHeight() * 0.30);
                fontSize = (fontSize >= 50) ? 40 : fontSize;
                e.Appearance.Font = new System.Drawing.Font("맑은 고딕", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            }
        }

        private void gridView_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e)
        {
            e.RowHeight = GetRowHeight() - 2;
        }

        #endregion
    }
}
