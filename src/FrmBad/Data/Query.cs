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

        public static DataTable ProdBadChart()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusProdBadChart '{0}', ''", FactoryCode);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }

        public static DataTable ProdBad()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusProdBad '{0}', ''", FactoryCode);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }

        public static DataTable BadTopList()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusBadTopList '{0}', ''", FactoryCode);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }        

        public static DataTable BadStatus()
        {
            string szSQL = "";

            try
            {
                szSQL = string.Format("EXEC SNSMESINC_StatusBadStatus '{0}', ''", FactoryCode);
                return DataBaseSQL.ExecuteSQLReturnDataTable(szSQL);
            }

            catch
            {
                return null;
            }
        }        
    }
}
