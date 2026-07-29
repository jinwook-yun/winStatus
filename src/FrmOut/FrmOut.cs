using WinStatusBoard.Page;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using WinStatusBoard.Data;
using WinStatusLib.PageEvent;

namespace WinStatusBoard
{
    public partial class FrmOut : Form
    {
        public PageEvent pageEvent = new PageEvent();

        FrmOutChart frmOutChart = new FrmOutChart();
        FrmOutDetail frmOutDetail = new FrmOutDetail();        
        FrmOutCustomDetail frmOutCustomDetail = new FrmOutCustomDetail();
        string CurrentPageName = "";
        public FrmOut()
        {
            InitializeComponent();
            
            lblDate.Text = DateTime.Now.ToString("yyyy년 MM월 dd일\nHH:mm:ss");
            FormBorderStyle = FormBorderStyle.None;

            pageEvent.PageMove += PageMoveEvent;
            frmOutChart.pageEvent.PageMove += PageMoveEvent;
            frmOutDetail.pageEvent.PageMove += PageMoveEvent;
            frmOutCustomDetail.pageEvent.PageMove += PageMoveEvent;
        }

        /// <summary>
        /// 화면 로드 시 첫 화면으로 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            pageEvent.MovePage("FrmOutChart", null);
        }

        /// <summary>
        /// 화면 이동 이벤트, 화면추가 시 마다 하단부에도 추가해야함
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageMoveEvent(object sender, PageEventArgs e)
        {
            StopTimer();
            panelMain.Controls.Clear();
            BackButton.Visible = e.ShowBackButton;
            ReFreshButton.Visible = e.ShowRefreshButton;
            SetupButton.Visible = e.ShowSetupButton;

            lblTitle.Text = e.Title;
            CurrentPageName = e.PageName;

            switch (e.PageName)
            {
                case "FrmOutChart":
                    frmOutChart.StartTimer();
                    panelMain.Controls.Add(frmOutChart);
                    break;
                case "FrmOutDetail":
                    Query.QueryParam = e.Param;
                    panelMain.Controls.Add(frmOutDetail);
                    frmOutDetail.FrmOutDetail_Load(null, null);
                    break;
                case "FrmOutCustomDetail":
                    Query.QueryParam = e.Param;
                    panelMain.Controls.Add(frmOutCustomDetail);
                    frmOutCustomDetail.FrmOutCustomDetail_Load(null, null);
                    break;
            }            
        }

        /// <summary>
        /// 뒤로 가기 클릭 시 이전 화면 불러옴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BackButton_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            pageEvent.PreviousPage();
        }

        private void ReFreshButton_Click(object sender, EventArgs e)
        {
            switch (CurrentPageName)
            {
                case "FrmOutChart":
                    frmOutChart.DataLoad();
                    break;
                case "FrmOutDetail":
                    frmOutDetail.DataLoad();
                    break;
                case "FrmOutCustomDetail":
                    frmOutCustomDetail.DataLoad();
                    break;
            }
        }

        private void IntervalButton_Click(object sender, EventArgs e)
        {
            FrmSetInterval frm = new FrmSetInterval();
            frm.ShowDialog();

            frmOutChart.SetTimerInterval();
            frmOutDetail.SetTimerInterval();
            frmOutCustomDetail.SetTimerInterval();
        }

        private void StopTimer()
        {
            frmOutChart.StopTimer();
            frmOutDetail.StopTimer();
            frmOutCustomDetail.StopTimer();
        }

        private void CloseForm()
        {
            frmOutChart.CloseUserForm();
            frmOutDetail.CloseUserForm();
            frmOutCustomDetail.CloseUserForm();
        }

        #region 창크기 제어

        private bool _isDragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;
        private bool _isFormSizeMax = true;
        private bool _isFormSizeable = false;

        private void lblTitle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_isFormSizeMax) { this.WindowState = FormWindowState.Normal; _isFormSizeMax = false; this.FormBorderStyle = FormBorderStyle.Sizable; _isFormSizeable = true; return;  }
            if (!_isFormSizeMax) { this.WindowState = FormWindowState.Maximized; _isFormSizeMax = true; this.FormBorderStyle = FormBorderStyle.None; _isFormSizeable = false; return; }
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            _isDragging = true;
            _dragCursorPoint = Cursor.Position;
            _dragFormPoint = this.Location;
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(_dragCursorPoint));
                this.Location = Point.Add(_dragFormPoint, new Size(dif));
            }
        }

        private void lblTitle_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
        }
        private void lblDate_DoubleClick(object sender, EventArgs e)
        {
            CloseForm();
            Close();
        }        

        #endregion

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy년 MM월 dd일\nHH:mm:ss");
        }

        private void lblsize_DoubleClick(object sender, EventArgs e)
        {
            if (_isFormSizeable == true) { this.FormBorderStyle = FormBorderStyle.None; _isFormSizeable = false; return; }
            if (_isFormSizeable == false) { this.FormBorderStyle = FormBorderStyle.Sizable; _isFormSizeable = true; return; }
        }
    }
}
