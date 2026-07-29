using WinStatusLib.DataBase;
using System;
using System.Collections.Generic;
using System.Data;


namespace WinStatusBoard.Data
{
    public class Query
    {
        public static string FactoryCode { get; set; } = "01";
        public static Dictionary<string, string> QueryParam { get; set; }

        public static string WorkDate
        {
            get
            {
                string szSQL = string.Format("select dbo.fnStdWorkDate_SNS('{0}', getdate())", FactoryCode);
                DataTable dt = DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);

                return dt.Rows[0][0].ToString().Substring(0, 4) + "년 " + dt.Rows[0][0].ToString().Substring(5, 2) + "월 ";
            }
        }
        public static DataTable MonthFGData()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusFGMonthly '{0}', '', ''", FactoryCode);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }

        public static DataTable MchInfoProdGDate()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format(" EXEC EXEC SNSMESINC_MachineMonitoring_Detail '{0}','{1}', '' ", FactoryCode, QueryParam["mc_cd"]);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }
            catch
            {
                return null;
            }
        }
    }
}
