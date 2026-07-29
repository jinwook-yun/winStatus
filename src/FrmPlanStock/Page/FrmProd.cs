using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WinStatusBoard.Data;
using WinStatusLib.PageEvent;

namespace WinStatusBoard
{
    public partial class FrmProd : UserControl
    {
        public PageEvent pageEvent = new PageEvent();
        AccordionControlElement selectedElement = new AccordionControlElement();
        System.Timers.Timer timer = null;
        public FrmProd()
        {
            InitializeComponent();
            InitializeTimer();

            Dock = DockStyle.Fill;
        }

        private void FrmProd_Load(object sender, System.EventArgs e)
        {
            StartTimer();

            GetMachineList(menuHF, "200", "PP135400");
            GetMachineList(menuFP, "200", "PP135300");
           // SetItemList(menuMaterial); 

            Dictionary<string, string> dicParam = new Dictionary<string, string>();
            dicParam.Add("mc_cd", "200-10001");
            Query.QueryParam = dicParam;
            DataLoad();

            accordionControl1.CustomDrawElement += accordionControl1_CustomDrawElement;
            accordionControl1.ElementClick += accordionControl1_ElementClick;
        }

        /// <summary>
        /// 메뉴 유동적으로 구성, ERP에 설비 추가되면 메뉴에도 추가됨
        /// </summary>
        /// <param name="accordian">적용 메뉴</param>
        /// <param name="workCenter">작업장</param>
        /// <param name="groupCode">설비그룹</param>
        private void GetMachineList(AccordionControlElement accordian, string workCenter, string groupCode)
        {
            Dictionary<string, string> dicParam = new Dictionary<string, string>();
            dicParam.Add("wc_cd", workCenter);
            dicParam.Add("grp_bc", groupCode);
            Query.QueryParam = dicParam;

            DataTable dt = Query.MachineList(); 

            foreach(DataRow dr in dt.Rows)
            {
                AccordionControlElement element = new AccordionControlElement();
                element.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                element.Text = dr["mc_nm"].ToString();
                element.Tag = dr["mc_cd"].ToString();
                element.Appearance.Normal.Font = new System.Drawing.Font("맑은 고딕", 15F);
                element.Appearance.Hovered.Font = element.Appearance.Normal.Font;
                element.Appearance.Pressed.Font = element.Appearance.Normal.Font;
                accordian.Elements.Add(element);
                element.Click += new EventHandler(accordionControlElement_Click);           
            }
        }

        /// <summary>
        /// [미사용] 메뉴 유동적 구성, list에 값 추가 시 메뉴 늘어남
        /// </summary>
        /// <param name="accordian">적용 메뉴</param>
        private void SetItemList(AccordionControlElement accordian)
        {
            string [] list = { "직구매", "사급" };
            for(int i = 0; i < list.Length; i++)
            { 
                AccordionControlElement element = new AccordionControlElement();
                element.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
                element.Text = list[i].ToString();
                element.Appearance.Normal.Font = new System.Drawing.Font("맑은 고딕", 15F);
                element.Appearance.Hovered.Font = element.Appearance.Normal.Font;
                element.Appearance.Pressed.Font = element.Appearance.Normal.Font;
                accordian.Elements.Add(element);
                element.Click += new EventHandler(accordionControlElement1_Click);              
            }
        }

        private void Element_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
            Grid.DataSource = Query.MonthPlan();
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
        /// 설비 클릭 시 데이터 로드
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accordionControlElement_Click(object sender, EventArgs e)
        {
            AccordionControlElement element = (AccordionControlElement)sender;
            Dictionary<string, string> dicParam = new Dictionary<string, string>();
            dicParam.Add("mc_cd", element.Tag.ToString());
            Query.QueryParam = dicParam;
            DataLoad();
        }

        /// <summary>
        /// 원자재 재고 하위 메뉴 클릭 시 현 화면 Stack에 저장 후 화면 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accordionControlElement1_Click(object sender, EventArgs e)
        {            
            AccordionControlElement btn = (AccordionControlElement)sender;
            string category = (btn.Text == "직구매") ? "SD300100" : "SD300200";
            Query.QueryParam = new Dictionary<string, string>() { { "de_bc", category } };

            pageEvent.PushPage("FrmProd");
            pageEvent.MovePage("FrmMatCustomList", Query.QueryParam);
        }

        private void accordionControl1_ElementClick(object sender, ElementClickEventArgs e)
        {
            if (e.Element.Style != ElementStyle.Group)
                selectedElement = e.Element;
        }

        private void accordionControl1_CustomDrawElement(object sender, CustomDrawElementEventArgs e)
        {
            if (e.ObjectInfo.Element == selectedElement || selectedElement.OwnerElement == e.ObjectInfo.Element)
            {
                e.Cache.FillRectangle(Color.FromArgb(201, 222, 245), e.ObjectInfo.HeaderBounds);
                e.DrawText();
                e.Handled = true;
            }
        }

        /// <summary>
        /// 내수/수출 제품재고 메뉴 클릭 시 현 화면 Stack에 저장 후 화면 이동
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menu_Click(object sender, EventArgs e)
        {            
            AccordionControlElement btn = (AccordionControlElement)sender;

            //원자재 클릭은 제외
            if (btn.Name == "menuMaterial")
            {
                pageEvent.PushPage("FrmProd");
                Query.QueryParam = new Dictionary<string, string>() { { "de_bc", "" } };
                
                pageEvent.MovePage("FrmMatCustomList", Query.QueryParam);
            }
            else
            {
                pageEvent.PushPage("FrmProd");
                string category = (btn.Name == "menuLocal") ? "SD300100" : "SD300200";
                Query.QueryParam = new Dictionary<string, string>() { { "de_bc", category } };

                pageEvent.MovePage("FrmCustomList", Query.QueryParam);
            }
        }

        //private int GetRowHeight()
        //{
        //    //GridViewInfo viewInfo = (GridViewInfo)gridView.GetViewInfo();

        //    //int gridHeight = Grid.Size.Height;
        //    //int headerHeight = viewInfo.ColumnRowHeight;
        //    //int rowNum = gridView.RowCount;
        //    //int rowHeight = (gridHeight - headerHeight) / rowNum;

        //    //return rowHeight;
        //}

        private void gridView_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            //if (e.RowHandle >= 0)
            //{
            //    int fontSize = Convert.ToInt32(GetRowHeight() * 0.15);
            //    fontSize = (fontSize >= 30) ? 25 : fontSize;
            //    e.Appearance.Font = new System.Drawing.Font("맑은 고딕", fontSize, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            //}
        }

        private void gridView_CalcRowHeight(object sender, DevExpress.XtraGrid.Views.Grid.RowHeightEventArgs e)
        {
            //e.RowHeight = GetRowHeight();
        }

        
    }
}
