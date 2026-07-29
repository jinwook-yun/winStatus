using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WinStatusBoard.Data;
using System.Collections.Generic;
using WinStatusLib.PageEvent;
using WinStatusBoard.Page;

namespace WinStatusBoard
{
    public partial class FrmClaim : Form
    {
        public PageEvent pageEvent = new PageEvent();

        FrmClaimChart frmClaimChart = new FrmClaimChart();
        FrmClaimTopChart frmClaimTopChart = new FrmClaimTopChart();
        FrmClaimAmt frmCustomLoss = new FrmClaimAmt();
        FrmClaimMonth frmMonthClaim = new FrmClaimMonth();
        string CurrentPageName = "";

        public FrmClaim()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("yyyy년 MM월 dd일\nHH:mm:ss");

            this.FormBorderStyle = FormBorderStyle.None;
            this.pageEvent.PageMove += PageMoveEvent;
            frmClaimChart.pageEvent.PageMove += PageMoveEvent;
            frmClaimTopChart.pageEvent.PageMove += PageMoveEvent;                        
        }

        private void FrmClaim_Load(object sender, EventArgs e)
        {
            pageEvent.MovePage("FrmClaimChart", null);
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
                case "FrmClaimChart":
                    panelMain.Controls.Add(frmClaimChart);
                    break;
                case "FrmClaimTopChart":
                    Query.QueryParam = e.Param;
                    panelMain.Controls.Add(frmClaimTopChart);
                    frmClaimTopChart.FrmBadTopChart_Load(null, null);
                    break;
                case "FrmCustomLoss":
                    Query.QueryParam = e.Param;
                    panelMain.Controls.Add(frmCustomLoss);
                    frmCustomLoss.FrmCustomLoss_Load(null, null);
                    break;
                case "FrmMonthClaim":
                    Query.QueryParam = e.Param;
                    panelMain.Controls.Add(frmMonthClaim);
                    frmMonthClaim.FrmMonthClaim_Load(null, null);
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
            switch (CurrentPageName)
            {
                case "FrmClaimChart":
                    pageEvent.PushPage("FrmClaimChart");
                    pageEvent.MovePage("FrmClaimTopChart", null);
                    break;
                case "FrmClaimTopChart":
                    pageEvent.PushPage("FrmClaimTopChart");
                    pageEvent.MovePage("FrmCustomLoss", null);
                    break;
                case "FrmCustomLoss":
                    pageEvent.PushPage("FrmCustomLoss");
                    pageEvent.MovePage("FrmMonthClaim", null);
                    break;
            }
        }

        private void StopTimer()
        {
            frmClaimChart.StopTimer();
            frmClaimTopChart.StopTimer();
            frmCustomLoss.StopTimer();
            frmMonthClaim.StopTimer();
        }

        private void CloseForm()
        {
            frmClaimChart.CloseUserForm();
            frmClaimTopChart.CloseUserForm();
            frmCustomLoss.CloseUserForm();
            frmMonthClaim.CloseUserForm();
        }

        #region 창크기 제어

        private bool _isDragging = false;
        private Point _dragCursorPoint;
        private Point _dragFormPoint;
        private bool _isFormSizeMax = true;
        private bool _isFormSizeable = true;


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

    }
}
