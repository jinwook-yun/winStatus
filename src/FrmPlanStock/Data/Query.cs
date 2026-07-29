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

        public static DataTable MachineList()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_GetMachineList '{0}', '{1}', '{2}'", FactoryCode, QueryParam["wc_cd"], QueryParam["grp_bc"]);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }

        public static DataTable MonthPlan()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusMonthPlan '{0}', '{1}', ''", FactoryCode, QueryParam["mc_cd"]);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }
        public static DataTable CustomList()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusCustomList '{0}', '{1}', ''", FactoryCode, QueryParam["de_bc"]);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;                
            }
        }

        public static DataTable MaterialCustomList()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusMaterialCustomList '{0}', '{1}', ''", FactoryCode, QueryParam["de_bc"]);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }

        public static DataTable CustomStock()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusCustomStock '{0}', '{1}', ''", FactoryCode, QueryParam["cust_cd"]);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }

        public static DataTable MaterialCustomStock()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusMaterialCustomStock '{0}', '{1}', ''", FactoryCode, QueryParam["cust_cd"]);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }

        public static DataTable StockDetail()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusCustomStockDetail '{0}', '{1}', ''", FactoryCode, QueryParam["itm_id"]);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }

        public static DataTable MaterialStockDetail()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusMaterialCustomStockDetail '{0}', '{1}', ''", FactoryCode, QueryParam["itm_id"]);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }
    }
}
