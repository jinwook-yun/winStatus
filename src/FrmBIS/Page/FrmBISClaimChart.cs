using System;
using System.Windows.Forms;
using WinStatusBoard.Data;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;
using System.Collections.Generic;
using System.Data;
using WinStatusBoard.View;
using DevExpress.XtraCharts;
using WinStatusLib.PageEvent;
using DevExpress.XtraPivotGrid;
using System.Diagnostics;

namespace WinStatusBoard.Page
{
    public partial class FrmBISClaimChart : UserControl
    {
        public PageEvent pageEvent = new PageEvent();
        ViewSecondaryChart chart = null;
        System.Timers.Timer timer = null;
        public FrmBISClaimChart()
        {
            InitializeComponent();
            InitializeTimer();

            Dock = DockStyle.Fill;                
        }

        public void FrmClaimChart_Load(object sender, EventArgs e)
        {
            StartTimer();

            DataTable data = Query.ClaimChart();
            pivotGridControl1.DataSource = Query.ClaimChartListBIS();
            DrawChart(data);
        }

        private void DrawChart(DataTable data)
        {
            // Create a new chart.
            ChartControl chartControl1 = new ChartControl();
            chart = new ViewSecondaryChart(chartControl1);

            chart.SeriesViewTypes = new ViewType[] { ViewType.Bar, ViewType.Line, ViewType.Line, ViewType.Line };
            chart.SeriesCount = 4;
            chart.SeriesMemberCount = data.Rows.Count;
            chart.SeriesMemberTitleColumnName = "mon";
            chart.SeriesPointValueColumnName = new string[] { "out_qty", "std_ppm", "bad_qty", "ppm" };

            string[] array = { "출하수량", "품질지표", "불량수량", "불량율(PPM)" };

            chart.SetSeries(array);
            chart.BindingChartData(data);
            chart.SetChartDiagram();

            chartControl1.Dock = DockStyle.Fill;
            splitContainer1.Panel1.Controls.Add(chartControl1);          
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

            string[] array = { "출하수량", "품질지표", "불량수량", "불량율(PPM)" };
            chart.SetSeries(array);
            chart.BindingChartData(Query.ClaimChart());
            pivotGridControl1.DataSource = Query.ClaimChartListBIS();            
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
            //if (e.RowHandle >= 0)
            //{
            //    int fontSize = Convert.ToInt32(GetRowHeight() * 0.2);
            //    e.Appearance.Font = new System.Drawing.Font("맑은 고딕", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            //}
        }

        private void gridView_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e)
        {
            //GridViewInfo viewInfo = (GridViewInfo)gridView.GetViewInfo();

            //int gridHeight = Grid.Size.Height;
            //int headerHeight = viewInfo.ColumnRowHeight;
            //int rowNum = gridView.RowCount;
            //int rowHeight = (gridHeight - headerHeight) / rowNum;
            //e.RowHeight = rowHeight - 28;
        }


        #endregion

        private void pivotGridControl1_CustomServerModeSort(object sender, CustomServerModeSortEventArgs e)
        {
            if(e.Field.FieldName == "mon")
            {
                MessageBox.Show("test");
            }
        }
    }
}
