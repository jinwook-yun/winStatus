using System;
using System.Drawing;
using System.Windows.Forms;
using WinStatusBoard.Data;
using WinStatusBoard.Page;
using WinStatusLib.PageEvent;

namespace WinStatusBoard
{
    public partial class FrmBad : Form
    {
        public PageEvent pageEvent = new PageEvent();

        FrmProdBadChart frmProdBadChart = new FrmProdBadChart();
        FrmBadTopList frmBadChart = new FrmBadTopList();
        FrmBadStatus frmBadStatus = new FrmBadStatus();
        string CurrentPageName = "";

        public FrmBad()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("yyyy년 MM월 dd일\nHH:mm:ss");

            this.FormBorderStyle = FormBorderStyle.None;
            this.pageEvent.PageMove += PageMoveEvent;
            frmProdBadChart.pageEvent.PageMove += PageMoveEvent;
            frmBadChart.pageEvent.PageMove += PageMoveEvent;
            frmBadStatus.pageEvent.PageMove += PageMoveEvent;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pageEvent.MovePage("FrmProdBadChart", null);
        }

        private void PageMoveEvent(object sender, PageEventArgs e)
        {
            StopTimer();
            panelMain.Controls.Clear();
            BackButton.Visible = e.ShowBackButton;
            NextButton.Visible = e.ShowNextButton;
            lblTitle.Text = e.Title;
            CurrentPageName = e.PageName;

            switch (e.PageName)
            {
                case "FrmProdBadChart":
                    panelMain.Controls.Add(frmProdBadChart);
                    break;
                case "FrmBadTopList":
                    Query.QueryParam = e.Param;
                    panelMain.Controls.Add(frmBadChart);
                    frmBadChart.FrmBadTopList_Load(null, null);
                    break;
                case "FrmBadStatus":
                    Query.QueryParam = e.Param;
                    panelMain.Controls.Add(frmBadStatus);
                    frmBadStatus.FrmBadStatus_Load(null, null);
                    break;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            pageEvent.PreviousPage();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            switch(CurrentPageName)
            {
                case "FrmProdBadChart":
                    pageEvent.PushPage("FrmProdBadChart");
                    pageEvent.MovePage("FrmBadTopList", null);
                    break;
                case "FrmBadTopList":
                    pageEvent.PushPage("FrmBadTopList");
                    pageEvent.MovePage("FrmBadStatus", null);
                    break;
            }            
        }
        private void StopTimer()
        {
            //frmProdBadChart.StopTimer(); //타이머 미사용
            frmBadChart.StopTimer();
            frmBadStatus.StopTimer();
        }

        private void CloseForm()
        {
            //frmProdBadChart.CloseUserForm(); //타이머 미사용
            frmBadChart.CloseUserForm();
            frmBadStatus.CloseUserForm();
        }
        #region 창크기 제어

        private bool _isDragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;
        private bool _isFormSizeMax = true;
        private bool _isFormSizeable = false;

        private void lblsize_DoubleClick(object sender, EventArgs e)
        {
            if (_isFormSizeable == true) { this.FormBorderStyle = FormBorderStyle.None; _isFormSizeable = false; return; }
            if (_isFormSizeable == false) { this.FormBorderStyle = FormBorderStyle.Sizable; _isFormSizeable = true; return; }
        }

        private void lblTitle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (_isFormSizeMax) { this.WindowState = FormWindowState.Normal; _isFormSizeMax = false; this.FormBorderStyle = FormBorderStyle.Sizable; _isFormSizeable = true; return; }
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

        private void SetupButton_Click(object sender, EventArgs e)
        {
            FrmSetInterval frm = new FrmSetInterval();
            frm.ShowDialog();

            //frmProdBadChart.SetTimerInterval();
            frmBadChart.SetTimerInterval();
            frmBadStatus.SetTimerInterval();
        }
    }
}
