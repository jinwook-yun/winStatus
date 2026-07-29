using WinStatusBoard.Page;
using System;
using System.Drawing;
using System.Windows.Forms;
using WinStatusLib.PageEvent;

namespace WinStatusBoard
{
    public partial class FrmFGscreen : Form
    {
        public PageEvent pageEvent = new PageEvent();
        FrmMonthFG frmMonthFG = new FrmMonthFG();
        string CurrentPageName = "";

        public FrmFGscreen()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToString("yyyy년 MM월 dd일\nHH:mm:ss");

            this.FormBorderStyle = FormBorderStyle.None;
            this.pageEvent.PageMove += PageMoveEvent;
            frmMonthFG.pageEvent.PageMove += PageMoveEvent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy년 MM월 dd일\nHH:mm:ss");
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            pageEvent.MovePage("FrmFGscreen", null);
        }

        private void ReFreshButton_Click(object sender, EventArgs e)
        {
            switch (CurrentPageName)
            {
                case "FrmFGscreen":
                    frmMonthFG.DataLoad();
                    break;               
            }
        }

        private void SetupButton_Click(object sender, EventArgs e)
        {
            FrmSetInterval frm = new FrmSetInterval();
            frm.ShowDialog();

            frmMonthFG.SetTimerInterval();
        }

        #region
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

        private void lblDate_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            pageEvent.PreviousPage();
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

        #endregion

        private void PageMoveEvent(object sender, PageEventArgs e)
        {
            panelMain.Controls.Clear();
            windowsUIButtonPanel1.Visible = e.ShowBackButton;
            lblTitle.Text = e.Title;
            CurrentPageName = e.PageName;

            switch (e.PageName)
            {
                case "FrmFGscreen":
                    panelMain.Controls.Add(frmMonthFG);
                    break;              
            }
        }


    }
}
