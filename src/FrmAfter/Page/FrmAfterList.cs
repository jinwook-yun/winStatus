using System;
using System.Drawing;
using WinStatusBoard.Data;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid;
using System.Data;
using DevExpress.XtraNavBar;
using WinStatusLib.PageEvent;
using System.Diagnostics;

namespace WinStatusBoard.Page
{
    public partial class FrmAfterList : UserControl
    {
        public PageEvent pageEvent = new PageEvent();
        System.Timers.Timer timer = null;

        public FrmAfterList()
        {
            InitializeComponent();
            InitializeTimer();            

            Dock = DockStyle.Fill;            
        }

        private void FrmMonthFG_Load(object sender, EventArgs e)
        {
            MakeMachineList();
        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            timer.Interval = Interval.DataReload;
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.AutoReset = true;
            timer.Enabled = true;
        }
        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //설비리스트만 불러오는 것이기 일정시간으로 불러올 필요가 없어 주석처리
            //if (this.InvokeRequired)
            //{
            //    BeginInvoke(new TimerEventFiredDelegate(DataLoad));
            //}
        }

        public void DataLoad()
        {
            Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} DataLoad - {this.Name} timer.Interval : {timer.Interval.ToString()}");
            tableLayoutPanel1.Controls.Clear();
            MakeMachineList();
        }
        public void SetTimerInterval()
        {
            if (timer != null)
            {
                timer.Interval = Interval.DataReload;
                Debug.WriteLine($"{DateTime.Now.ToString("HH:mm:ss")} SetTimerInterval - {this.Name} timer.Interval : {timer.Interval.ToString()}");
            }
        }

        public void MakeMachineList()
        {
            DataTable groupTable = Query.AfterList().Tables[0];
            DataTable machineTable = Query.AfterList().Tables[1];

            NavBarControl [] navBarContol = new NavBarControl[groupTable.Rows.Count];
            NavBarGroup [] navBarGroup = new NavBarGroup[groupTable.Rows.Count];

            tableLayoutPanel1.ColumnCount = groupTable.Rows.Count;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100 / groupTable.Rows.Count));

            for (int i = 0; i < groupTable.Rows.Count; i++)
            {
                DataRow row = groupTable.Rows[i];
                string express = $"grp_bc = '{row["grp_bc"].ToString()}'";
                DataTable mcTable = machineTable.Select(express).CopyToDataTable();
                int grpMachineList = Convert.ToInt32(row["cnt"].ToString());

                navBarContol[i] = new NavBarControl();
                navBarContol[i].Dock = DockStyle.Fill;
                navBarContol[i].Appearance.Item.Font = new Font("맑은 고딕", 25F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(129)));
                navBarContol[i].Appearance.Item.Options.UseFont = true;
                navBarContol[i].Appearance.Item.Options.UseTextOptions = true;
                navBarContol[i].Appearance.Item.TextOptions.HAlignment = HorzAlignment.Center;
                navBarContol[i].Appearance.Item.TextOptions.VAlignment = VertAlignment.Center;

                navBarContol[i].Appearance.ItemHotTracked.Font = navBarContol[i].Appearance.Item.Font;
                navBarContol[i].Appearance.ItemHotTracked.Options.UseFont = navBarContol[i].Appearance.Item.Options.UseFont;
                navBarContol[i].Appearance.ItemHotTracked.Options.UseTextOptions = navBarContol[i].Appearance.Item.Options.UseTextOptions;
                navBarContol[i].Appearance.ItemHotTracked.TextOptions.HAlignment = navBarContol[i].Appearance.Item.TextOptions.HAlignment;
                navBarContol[i].Appearance.ItemHotTracked.TextOptions.VAlignment = navBarContol[i].Appearance.Item.TextOptions.VAlignment;

                navBarContol[i].Appearance.ItemPressed.Font = navBarContol[i].Appearance.Item.Font;
                navBarContol[i].Appearance.ItemPressed.Options.UseFont = navBarContol[i].Appearance.Item.Options.UseFont;
                navBarContol[i].Appearance.ItemPressed.Options.UseTextOptions = navBarContol[i].Appearance.Item.Options.UseTextOptions;
                navBarContol[i].Appearance.ItemPressed.TextOptions.HAlignment = navBarContol[i].Appearance.Item.TextOptions.HAlignment;
                navBarContol[i].Appearance.ItemPressed.TextOptions.VAlignment = navBarContol[i].Appearance.Item.TextOptions.VAlignment;

                navBarContol[i].LinkInterval = 35;
                navBarContol[i].ExplorerBarShowGroupButtons = false;

                tableLayoutPanel1.Controls.Add(navBarContol[i], i, 0);

                navBarGroup[i] = new NavBarGroup();
                navBarGroup[i].Appearance.Font = new Font("맑은 고딕", 30F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(129)));
                navBarGroup[i].Appearance.Options.UseTextOptions = true;
                navBarGroup[i].Appearance.Options.UseFont = true;
                navBarGroup[i].Appearance.TextOptions.HAlignment = HorzAlignment.Center;
                navBarGroup[i].Appearance.TextOptions.VAlignment = VertAlignment.Center;

                navBarGroup[i].Caption = row["grp_bc"].ToString();
                navBarGroup[i].DragDropFlags = NavBarDragDrop.None;                
                navBarGroup[i].Expanded = true;
                navBarGroup[i].GroupStyle = NavBarGroupStyle.SmallIconsList;
                navBarGroup[i].Name = "navBarGroup1";

                navBarContol[i].Groups.AddRange(new NavBarGroup[] { navBarGroup[i] });

                for (int j = 0; j < mcTable.Rows.Count; j++)
                {
                    DataRow mcRow = mcTable.Rows[j];
                    NavBarItem[] navBarItem = new NavBarItem[grpMachineList];
                    if (row["grp_bc"].ToString().Equals(mcRow["grp_bc"].ToString()))
                    {                        
                        navBarItem[j] = new NavBarItem();
                        navBarItem[j].Caption = mcRow["mc_nm"].ToString();
                        navBarItem[j].Tag = mcRow["mc_cd"].ToString();
                        navBarItem[j].LinkClicked += new NavBarLinkEventHandler(navBarItem_LinkClicked);
                        navBarContol[i].Items.AddRange(new NavBarItem[] {navBarItem[j]});
                        navBarGroup[i].ItemLinks.AddRange(new NavBarItemLink[] {new NavBarItemLink(navBarItem[j])});
                    }                    
                }
            }
        }

        #region Grid 화면 정의

        private int GetRowHeight()
        {
            //GridViewInfo viewInfo = (GridViewInfo)gridView.GetViewInfo();

            //int gridHeight = Grid.Size.Height;
            //int headerHeight = viewInfo.ColumnRowHeight;
            //int rowNum = gridView.RowCount;
           // int rowHeight = (gridHeight - headerHeight) / rowNum;

            return 0;
        }

        private void gridView_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (e.RowHandle >= 0)
            {
                int fontSize = Convert.ToInt32(GetRowHeight() * 0.33);
                fontSize = (fontSize >= 50) ? 40 : fontSize;
                e.Appearance.Font = new System.Drawing.Font("맑은 고딕", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            }
        }

        private void gridView_CalcRowHeight(object sender, RowHeightEventArgs e)
        {
            e.RowHeight = e.RowHeight = GetRowHeight(); ;
        }

        private void gridView_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            //Dictionary<string, string> dicParam = new Dictionary<string, string>();

            if (e.RowHandle >= 0)
            {
               // string mcMn = gridView.GetRowCellDisplayText(e.RowHandle, gridView.Columns["mc_nm"]);             
               // string mccd = gridView.GetRowCellDisplayText(e.RowHandle, gridView.Columns["mc_cd"]);

                //if (mccd != "9999")
                //{ 
                //    //Dictionary<string, string> mchParam = new Dictionary<string, string>();
                //    //mchParam.Add("mc_cd", mccd);

                //    //Query.QueryParam = mchParam;
                //    ////Query.MchInfoProdGDate();
                //    FrmPopUp frmPopUp = new FrmPopUp();
                //    frmPopUp.StartPosition = FormStartPosition.CenterParent;
                //    frmPopUp.lblMachine.Text = mcMn;
                //    frmPopUp.vMchNO = mccd;
                //    frmPopUp.ShowDialog();
                //}

            }
        }

        private void grid_RowStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowStyleEventArgs e)
        {
            
            //if (e.RowHandle >= 0)
            //{
            //   // string mcnm = gridView.GetRowCellDisplayText(e.RowHandle, gridView.Columns["mc_nm"]);
            //    if (mcnm =="소 계")
            //    {
            //        e.Appearance.BackColor = Color.Gainsboro;
            //        e.Appearance.BackColor2 = Color.WhiteSmoke;
            //    }
            //}

        }

        #endregion

        private void navBarItem_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string mccd = e.Link.Item.Tag.ToString();
            string mcMn = e.Link.Item.Caption.ToString();

            FrmPopUp frmPopUp = new FrmPopUp();
            frmPopUp.StartPosition = FormStartPosition.CenterParent;
            frmPopUp.lblMachine.Text = mcMn;
            frmPopUp.vMchNO = mccd;
            frmPopUp.ShowDialog();
        }
    }
}
