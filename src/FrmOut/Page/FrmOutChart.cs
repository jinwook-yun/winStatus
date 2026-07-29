using System.Data;
using System.Windows.Forms;
using WinStatusBoard.View;
using WinStatusBoard.Data;
using DevExpress.XtraGrid.Views.BandedGrid;
using System;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Collections.Generic;
using WinStatusLib.PageEvent;
using System.Diagnostics;

namespace WinStatusBoard.Page
{
    public partial class FrmOutChart : UserControl
    {
        public PageEvent pageEvent = new PageEvent();
        ViewChart barChart = null;
        System.Timers.Timer timer = null;
        public FrmOutChart()
        {
            InitializeComponent();
            InitializeTimer();

            Dock = DockStyle.Fill;            
        }

        public void FrmOut_Load(object sender, System.EventArgs e)
        {
            StartTimer();

            string yearMonth = Query.WorkDate;
            gridBand2.Caption = yearMonth + "계획대비 실적";
            so_amt.Caption = yearMonth + "판매계획";

            DataTable data = Query.MonthData();
            GridMonth.DataSource = data;

            barChart = new ViewChart(chart);
            barChart.SeriesCount = 2;
            barChart.SeriesMemberCount = 3;
            barChart.SeriesMemberTitleColumnName = "de_nm";
            barChart.SeriesPointValueColumnName = new string[] { "chart_so_amt", "chart_out_amt" };

            string[] array = { yearMonth + "계획대비 실적\n" + yearMonth.Substring(6, 3) + " 판매계획\n", yearMonth + "계획대비 실적\n출하실적누계\n" };
            barChart.SetSeries(array);
            barChart.BindingChartData(data);
            barChart.SetChartDiagram();

            BandMergeHelper helper = new BandMergeHelper(bgGrid, new GridBand[] { gridBand1 }); //밴드 합치기
            bgGrid.UserCellPadding = new Padding(7);
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

            string yearMonth = Query.WorkDate;
            gridBand2.Caption = yearMonth + "계획대비 실적";
            so_amt.Caption = yearMonth + "판매계획";
            string[] array = { yearMonth + "계획대비 실적\n" + yearMonth.Substring(6, 3) + " 판매계획\n", yearMonth + "계획대비 실적\n출하실적누계\n" };

            barChart.SetSeries(array);
            barChart.BindingChartData(Query.MonthData());
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

        /// <summary>
        /// 행 선택 후 현재 화면 Stack에 저장 및 다음 페이지로 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bgGrid_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string dicKey = "de_bc";
                string category = bgGrid.GetRowCellDisplayText(e.RowHandle, bgGrid.Columns[dicKey]);

                if(category != "SD999999")
                {
                    Query.QueryParam = new Dictionary<string, string>() { { dicKey, category } };

                    string pageTitle = category.Equals("SD300100") ? "내수 출하현황판" : "수출 출하현황판";
                    pageEvent.PushPage("FrmOutChart");
                    pageEvent.ChangePageTitle("FrmOutDetail", pageTitle);                    
                    pageEvent.MovePage("FrmOutDetail", Query.QueryParam);
                }   
            }

            #region 과거 합계 색상 추가
            //if (e.RowHandle >= 0)
            //{
            //    GridView View = sender as GridView;
            //    string category = View.GetRowCellDisplayText(e.RowHandle, View.Columns["de_bc"]);
            //    string stringRate = View.GetRowCellDisplayText(e.RowHandle, View.Columns["amt_rate"]).ToString().ToString().Replace(",", "").Replace("%", "");
            //    int rate = Convert.ToInt32(stringRate);

            //    //소계, 합계 일 경우 바탕색 및 글자색 지정
            //    if (category == "SD999999")
            //    {
            //        e.Appearance.BackColor = Color.FromArgb(255, 232, 202);
            //        e.Appearance.ForeColor = Color.Black;
            //    }
            //    else
            //    {
            //        if (rate >= 90)
            //        {
            //            e.Appearance.BackColor = Color.Green;
            //            e.Appearance.ForeColor = Color.White;
            //        }
            //        else if (rate >= 80 && rate < 90)
            //        {
            //            e.Appearance.BackColor = Color.Yellow;
            //            e.Appearance.ForeColor = Color.Black;
            //        }
            //        else
            //        {
            //            e.Appearance.BackColor = Color.White;
            //            e.Appearance.ForeColor = Color.Black;
            //        }
            //    }

            //    int fontSize = Convert.ToInt32(GetRowHeight() * 0.36);
            //    e.Appearance.Font = new System.Drawing.Font("맑은 고딕", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            //}
            #endregion
        }

        #region Grid 화면 정의
        private int GetRowHeight()
        {
            GridViewInfo viewInfo = (GridViewInfo)bgGrid.GetViewInfo();

            int gridHeight = GridMonth.Size.Height;
            int headerHeight = viewInfo.ColumnRowHeight * 2;
            int rowNum = bgGrid.RowCount;
            int rowHeight = (gridHeight - headerHeight) / rowNum;

            return rowHeight;
        }

        private void bgGrid_CustomDrawBandHeader(object sender, BandHeaderCustomDrawEventArgs e)
        {
            if (bgGrid.RowCount > 0)
            {
                int fontSize = Convert.ToInt32(GetRowHeight() * 0.3);
                e.Appearance.Font = new System.Drawing.Font("맑은 고딕", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            }
        }

        private void bgGrid_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            if (bgGrid.RowCount > 0)
            {
                int fontSize = Convert.ToInt32(GetRowHeight() * 0.3);
                e.Appearance.Font = new System.Drawing.Font("맑은 고딕", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            }
        }

        private void bgGrid_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int fontSize = Convert.ToInt32(GetRowHeight() * 0.3);
                fontSize = (fontSize >= 50) ? 40 : fontSize;
                e.Appearance.Font = new System.Drawing.Font("맑은 고딕", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            }
        }

        private void bgGrid_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e)
        {
            e.RowHeight = GetRowHeight() - 5;
        }

        #endregion
    }
}
