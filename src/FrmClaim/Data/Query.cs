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

        public static DataTable ClaimChart()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusClaim '{0}', ''", FactoryCode);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }
        public static DataTable ClaimChartList()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusClaimChartList '{0}', ''", FactoryCode);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }
        public static DataSet ClaimCustom()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusClaimCustom '{0}', ''", FactoryCode);
                return DataBaseSQL.ExecuteSQLReturnDataSet(szSQL);
            }

            catch
            {
                return null;
            }
        }
        public static DataTable ClaimTopList()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusClaimTopList '{0}', ''", FactoryCode);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }
        public static DataTable ClaimAmt()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusClaimAmt '{0}', ''", FactoryCode);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }

        public static DataTable ClaimMonth()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusClaimMonth '{0}', ''", FactoryCode);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }

        
    }
}
