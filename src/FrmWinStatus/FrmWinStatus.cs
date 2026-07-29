using System.Data;
using WinStatusBoard;
using WinStatusLib.DataBase;
using WinStatusLib.PageEvent;

namespace FrmWinStatus
{
    public partial class FrmWinStatus : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public FrmWinStatus()
        {
            InitializeComponent();
            MakePageList();
        }

        private void MakePageList()
        {
            //FrmOut
            PageList.pageList.Add(new PageList.Page { PageName = "FrmOutChart", Title = "월간 출하현황판", ShowBackButton = false, ShowNextButton = false, ShowRefreshButton = true, ShowSetupButton = true });
            PageList.pageList.Add(new PageList.Page { PageName = "FrmOutDetail", Title = "내수 출하현황판", ShowBackButton = true, ShowNextButton = false, ShowRefreshButton = true, ShowSetupButton = true });
            PageList.pageList.Add(new PageList.Page { PageName = "FrmOutCustomDetail", Title = "업체별 출하현황판", ShowBackButton = true, ShowNextButton = false, ShowRefreshButton = true, ShowSetupButton = true });

            //FrmPlanStock
            PageList.pageList.Add(new PageList.Page { PageName = "FrmProd", Title = "금주 생산계획", ShowBackButton = false, ShowNextButton = false, ShowRefreshButton = true, ShowSetupButton = true });
            PageList.pageList.Add(new PageList.Page { PageName = "FrmCustomList", Title = "내수 재고모니터링", ShowBackButton = true, ShowNextButton = false, ShowRefreshButton = true, ShowSetupButton = true });
            PageList.pageList.Add(new PageList.Page { PageName = "FrmCustomDetail", Title = "재고 모니터링", ShowBackButton = true, ShowNextButton = false, ShowRefreshButton = true, ShowSetupButton = true });
            PageList.pageList.Add(new PageList.Page { PageName = "FrmStockDetail", Title = "재고 모니터링", ShowBackButton = true, ShowNextButton = false, ShowRefreshButton = true, ShowSetupButton = true });
            PageList.pageList.Add(new PageList.Page { PageName = "FrmMatCustomList", Title = "재고 모니터링", ShowBackButton = true, ShowNextButton = false, ShowRefreshButton = true, ShowSetupButton = true });
            PageList.pageList.Add(new PageList.Page { PageName = "FrmMatCustomDetail", Title = "재고 모니터링", ShowBackButton = true, ShowNextButton = false, ShowRefreshButton = true, ShowSetupButton = true });
            PageList.pageList.Add(new PageList.Page { PageName = "FrmMatStockDetail", Title = "재고 모니터링", ShowBackButton = true, ShowNextButton = false, ShowRefreshButton = true, ShowSetupButton = true });

            //FrmFGscreen
            PageList.pageList.Add(new PageList.Page { PageName = "FrmFGscreen", Title = "월간 단조 생산현황", ShowBackButton = false, ShowNextButton = false, ShowRefreshButton = true, ShowSetupButton = true });

            //FrmAfter
            PageList.pageList.Add(new PageList.Page { PageName = "FrmAfter", Title = "후공정 생산현황", ShowBackButton = false, ShowNextButton = false, ShowRefreshButton = true, ShowSetupButton = true });

            //FrmBad
            PageList.pageList.Add(new PageList.Page { PageName = "FrmProdBadChart", Title = $"{Query.WorkDate} 공정품질 현황", ShowBackButton = false, ShowNextButton = true, ShowRefreshButton = false, ShowSetupButton = false });
            PageList.pageList.Add(new PageList.Page { PageName = "FrmBadTopList", Title = $"{Query.WorkDate} 유형별 불량현황", ShowBackButton = true, ShowNextButton = true, ShowRefreshButton = false, ShowSetupButton = false });
            PageList.pageList.Add(new PageList.Page { PageName = "FrmBadStatus", Title = "사내부적합 발생현황", ShowBackButton = true, ShowNextButton = false, ShowRefreshButton = false, ShowSetupButton = true });

            //FrmClaim
            PageList.pageList.Add(new PageList.Page { PageName = "FrmClaimChart", Title = $"고객 Claim 현황", ShowBackButton = false, ShowNextButton = true, ShowRefreshButton = false, ShowSetupButton = false });
            PageList.pageList.Add(new PageList.Page { PageName = "FrmClaimTopChart", Title = $"고객 Claim 현황", ShowBackButton = true, ShowNextButton = true, ShowRefreshButton = false, ShowSetupButton = false });
            PageList.pageList.Add(new PageList.Page { PageName = "FrmCustomLoss", Title = "업체별 손실 금액", ShowBackButton = true, ShowNextButton = true, ShowRefreshButton = false, ShowSetupButton = false });
            PageList.pageList.Add(new PageList.Page { PageName = "FrmMonthClaim", Title = "월별 클레임 관리 대장", ShowBackButton = true, ShowNextButton = false, ShowRefreshButton = false, ShowSetupButton = false });

            //FrmBIS
            PageList.pageList.Add(new PageList.Page { PageName = "FrmBISClaimChart", Title = $"고객 Claim 현황", ShowBackButton = false, ShowNextButton = true, ShowRefreshButton = false, ShowSetupButton = true });
            PageList.pageList.Add(new PageList.Page { PageName = "FrmBISProdBadChart", Title = $"{Query.WorkDate} 공정품질 현황", ShowBackButton = true, ShowNextButton = false, ShowRefreshButton = false, ShowSetupButton = true });
        }       

        private void tileMonthOut_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmOut frm = new FrmOut();
            frm.Show();
        }

        private void tilePlanStock_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmPlanStock frm = new FrmPlanStock();
            frm.Show();
        }

        private void tileFGscreen_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmFGscreen frm = new FrmFGscreen();
            frm.Show();
        }

        private void tileBad_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmBad frm = new FrmBad();
            frm.Show();
        }

        private void tileClaim_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmClaim frm = new FrmClaim();
            frm.Show();
        }

        private void tileItem4_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmAfter frm = new FrmAfter();
            frm.Show();
        }

        private void tileBIS_ItemClick(object sender, DevExpress.XtraEditors.TileItemEventArgs e)
        {
            FrmBIS frm = new FrmBIS();
            frm.Show();
        }
    }

    public class Query
    {
        public static string FactoryCode { get; set; } = "01";
        public static string WorkDate
        {
            get
            {
                string szSQL = string.Format("select dbo.fnStdWorkDate_SNS('{0}', getdate())", FactoryCode);
                DataTable dt = DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);

                return dt.Rows[0][0].ToString().Substring(0, 4) + "년 " + dt.Rows[0][0].ToString().Substring(5, 2) + "월 ";
            }
        }     
    }
}
