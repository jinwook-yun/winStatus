using System;
using System.Windows.Forms;
using WinStatusBoard.Data;
using DevExpress.XtraGrid.Views.Grid;
using WinStatusLib.PageEvent;
using System.Diagnostics;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace WinStatusBoard.Page
{
    public partial class FrmOutCustomDetail : UserControl
    {
        public PageEvent pageEvent = new PageEvent();
        System.Timers.Timer timer = null;
        public FrmOutCustomDetail()
        {
            InitializeComponent();
            InitializeTimer();

            Dock = DockStyle.Fill;            
        }

        public void FrmOutCustomDetail_Load(object sender, EventArgs e)
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
            Grid.DataSource = Query.CustomData();
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
            int headerHeight = viewInfo.ColumnRowHeight * 2;
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
            //if (e.RowHandle >= 0)
            //{
            //    int fontSize = Convert.ToInt32(GetRowHeight() * 0.2);
            //    e.Appearance.Font = new System.Drawing.Font("맑은 고딕", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            //}
        }

        private void gridView_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e)
        {
            e.RowHeight = e.RowHeight = GetRowHeight();
        }

        #endregion

    }
}
