using System;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using WinStatusBoard.Data;
using System.Collections.Generic;
using WinStatusLib.PageEvent;

namespace WinStatusBoard
{
    public partial class FrmPlanStock : Form
    {        
        public PageEvent pageEvent = new PageEvent();           //페이지 이동 이벤트

        FrmProd frmProd = new FrmProd();
        FrmCustomList frmCustomList = new FrmCustomList();
        FrmCustomDetail frmCustomDetail = new FrmCustomDetail();
        FrmStockDetail frmStockDetail = new FrmStockDetail();

        FrmMatCustomList frmMatCustomList = new FrmMatCustomList();
        FrmMatCustomDetail frmMatCustomDetail = new FrmMatCustomDetail();
        FrmMatStockDetail frmMatStockDetail = new FrmMatStockDetail();

        string CurrentPageName = "";

        public FrmPlanStock()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("yyyy년 MM월 dd일\nHH:mm:ss");

            this.FormBorderStyle = FormBorderStyle.None;
            this.pageEvent.PageMove += PageMoveEvent;
            frmProd.pageEvent.PageMove += PageMoveEvent;
            frmCustomList.pageEvent.PageMove += PageMoveEvent;
            frmStockDetail.pageEvent.PageMove += PageMoveEvent;
            frmCustomDetail.pageEvent.PageMove += PageMoveEvent;

            frmMatCustomList.pageEvent.PageMove += PageMoveEvent;
            frmMatStockDetail.pageEvent.PageMove += PageMoveEvent;
            frmMatCustomDetail.pageEvent.PageMove += PageMoveEvent;
        }

        /// <summary>
        /// 화면 로드 시 첫 화면으로 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            pageEvent.MovePage("FrmProd", null);            
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
            windowsUIButtonPanel1.Visible = e.ShowBackButton;
            lblTitle.Text = e.Title;
            CurrentPageName = e.PageName;

            switch (e.PageName)
            {
                case "FrmProd":
                    frmProd.StartTimer();
                    panelMain.Controls.Add(frmProd);
                    break;
                case "FrmCustomList":
                    Query.QueryParam = e.Param;
                    panelMain.Controls.Add(frmCustomList);
                    frmCustomList.FrmCustomList_Load(null, null);
                    break;
                case "FrmCustomDetail":
                    Query.QueryParam = e.Param;
                    panelMain.Controls.Add(frmCustomDetail);
                    frmCustomDetail.FrmCustomDetail_Load(null, e);
                    break;
                case "FrmStockDetail":
                    Query.QueryParam = e.Param;
                    panelMain.Controls.Add(frmStockDetail);
                    frmStockDetail.FrmStockDetail_Load(null, null);
                    break;
                case "FrmMatCustomList":
                    Query.QueryParam = e.Param;
                    panelMain.Controls.Add(frmMatCustomList);
                    frmMatCustomList.FrmMatCustomList_Load(null, null);
                    break;
                case "FrmMatCustomDetail":
                    Query.QueryParam = e.Param;
                    panelMain.Controls.Add(frmMatCustomDetail);
                    frmMatCustomDetail.FrmMatCustomDetail_Load(null, null);
                    break;
                case "FrmMatStockDetail":
                    Query.QueryParam = e.Param;
                    panelMain.Controls.Add(frmMatStockDetail);
                    frmMatStockDetail.FrmMatStockDetail_Load(null, null);
                    break;
            }
        }

        /// <summary>
        /// 뒤로 가기 클릭 시 이전 화면 불러옴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            pageEvent.PreviousPage();
        }

        private void ReFreshButton_Click(object sender, EventArgs e)
        {
            switch (CurrentPageName)
            {
                case "FrmProd":
                    frmProd.DataLoad();
                    break;
                case "FrmCustomList":
                    frmCustomList.DataLoad();
                    break;
                case "FrmCustomDetail":
                    frmCustomDetail.DataLoad();
                    break;
                case "FrmStockDetail":
                    frmStockDetail.DataLoad();
                    break;
                case "FrmMatCustomList":
                    frmMatCustomList.DataLoad();
                    break;
                case "FrmMatCustomDetail":
                    frmMatCustomDetail.DataLoad();
                    break;
                case "FrmMatStockDetail":
                    frmMatStockDetail.DataLoad();
                    break;
            }
        }

        private void SetupButton_Click(object sender, EventArgs e)
        {
            FrmSetInterval frm = new FrmSetInterval();
            frm.ShowDialog();

            frmProd.SetTimerInterval();
            frmCustomList.SetTimerInterval();
            frmCustomDetail.SetTimerInterval();
            frmStockDetail.SetTimerInterval();
            frmMatCustomList.SetTimerInterval();
            frmMatCustomDetail.SetTimerInterval();
            frmMatStockDetail.SetTimerInterval();
        }

        private void StopTimer()
        {
            frmProd.StopTimer();
            frmCustomList.StopTimer();
            frmCustomDetail.StopTimer();
            frmStockDetail.StopTimer();
            frmMatCustomList.StopTimer();
            frmMatCustomDetail.StopTimer();
            frmMatStockDetail.StopTimer();
        }

        private void CloseForm()
        {
            frmProd.CloseUserForm();
            frmCustomList.CloseUserForm();
            frmCustomDetail.CloseUserForm();
            frmStockDetail.CloseUserForm();
            frmMatCustomList.CloseUserForm();
            frmMatCustomDetail.CloseUserForm();
            frmMatStockDetail.CloseUserForm();
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

    }
}
