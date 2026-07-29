using System.Windows.Forms;
using WinStatusBoard.Data;
using System;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Collections.Generic;
using WinStatusLib.PageEvent;
using System.Diagnostics;

namespace WinStatusBoard
{
    public partial class FrmCustomList : UserControl
    {
        public PageEvent pageEvent = new PageEvent();
        System.Timers.Timer timer = null;
        public FrmCustomList()
        {
            InitializeComponent();
            InitializeTimer();

            Dock = DockStyle.Fill;
        }

        public void FrmCustomList_Load(object sender, System.EventArgs e)
        {
            StartTimer();
            DataLoad();
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
            Grid.DataSource = Query.CustomList();
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
        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                string dicKey = "cust_cd";
                string category = gridView.GetRowCellDisplayText(e.RowHandle, gridView.Columns[dicKey]);
                Query.QueryParam = new Dictionary<string, string>() { { dicKey, category } };

                string pageTitle = category.Equals("SD300100") ? "내수 재고모니터링" : "수출 재고모니터링";
                pageEvent.PushPage("FrmCustomList");
                pageEvent.ChangePageTitle("FrmCustomList", pageTitle);
                pageEvent.MovePage("FrmCustomDetail", Query.QueryParam);
            }
        }

        #region Grid 화면 정의
        //private int GetRowHeight()
        //{
        //    GridViewInfo viewInfo = (GridViewInfo)gridView.GetViewInfo();

        //    int gridHeight = Grid.Size.Height;
        //    int headerHeight = viewInfo.ColumnRowHeight;
        //    int rowNum = gridView.RowCount;
        //    int rowHeight = (gridHeight - headerHeight) / rowNum;

        //    return rowHeight;
        //}

        private void gridView_CustomDrawColumnHeader(object sender, DevExpress.XtraGrid.Views.Grid.ColumnHeaderCustomDrawEventArgs e)
        {
            //if (gridView.RowCount > 0)
            //{
            //    int fontSize = Convert.ToInt32(GetRowHeight() * 0.33);
            //    e.Appearance.Font = new System.Drawing.Font("맑은 고딕", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            //}
        }

        private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //이건 너무 크기가 작아져서 사용할 수가 없음
            //if (e.RowHandle >= 0)
            //{

            //    int fontSize = Convert.ToInt32(GetRowHeight() * 0.6);
            //    fontSize = (fontSize >= 50) ? 40 : fontSize;
            //    e.Appearance.Font = new System.Drawing.Font("맑은 고딕", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            //}
        }

        private void gridView_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e)
        {
            //e.RowHeight = GetRowHeight();
        }

        #endregion
    }
}
