using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinStatusBoard.Data;
using WinStatusLib.DataBase;

namespace WinStatusBoard
{
    public partial class FrmPopUp : Form
    {
        public string vMchNO;

        public FrmPopUp()
        {
            InitializeComponent();
        }

        private void lblMachine_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmPopUp_Load(object sender, EventArgs e)
        {
            //SetData();
            MatchData(vMchNO);
        }

        private void SetData()
        {
            try
            { 
                string stop;
                Dictionary<string, string> mchParam = new Dictionary<string, string>();

                mchParam.Add("mc_cd", vMchNO);
                Query.QueryParam = mchParam;
                DataTable DT = Query.MchInfoAfter();

                if (DT.Rows.Count <= 0) return;

                DataRow dr = DT.Rows[0];
                stop = dr["stop_yn"].ToString();

                switch (stop)
                {
                    case "0":   // 가동
                        lblMachine.BackColor = Color.Green;
                        lblMachine.ForeColor = Color.White;
                        break;
                    case "1":
                        lblMachine.BackColor = Color.Red;
                        lblMachine.ForeColor = Color.White;
                        break;
                    case "1R": //비가동 미입력
                        lblMachine.BackColor = Color.Red;
                        lblMachine.ForeColor = Color.White;
                        break;
                    case "1Y":  // 비가동 미입력
                        lblMachine.BackColor = Color.Red;
                        lblMachine.ForeColor = Color.White;
                        break;
                    case "1B":  //계획정지
                        lblMachine.BackColor = Color.FromArgb(17, 113, 157);
                        lblMachine.ForeColor = Color.White;
                        break;
                    case "-1":  // 통신이상
                        lblMachine.BackColor = Color.Yellow;
                        lblMachine.ForeColor = Color.Black;
                        break;
                }
                lblMData1.Text = dr["planQty"].ToString();
                lblMData2.Text = dr["prodQty"].ToString();
                lblProdData1.Text = dr["itm_cd"].ToString();
                lblProdData2.Text = dr["itm_nm"].ToString();
                    //lblProdData4.Text = dr["stop_nm"].ToString();
            }
        catch
            {
                return;
            }
        }

        public void MatchData(string MachineCode)
        {
            try
            {
                string sql = "";
                string stop;

                sql = string.Format("EXEC SNSMESINC_MachineMonitoring_AfterDetail '01', '{0}', ''", MachineCode);
                DataTable dt = DataBaseSQL.ExecuteSQLReturnDataTable(sql);

                if (dt.Rows.Count <= 0) return;

                DataRow dr = dt.Rows[0];
                stop = dr["stop_yn"].ToString();

                switch (stop)
                {
                    case "0":   // 가동
                        lblMachine.BackColor= Color.Green;
                        lblMachine.ForeColor = Color.White;
                        break;
                    case "1":
                        lblMachine.BackColor = Color.Red;
                        lblMachine.ForeColor = Color.White;
                        break;
                    case "1R": //비가동 미입력
                        lblMachine.BackColor = Color.Red;
                        lblMachine.ForeColor = Color.White;
                        break;
                    case "1Y":  // 비가동 미입력
                        lblMachine.BackColor = Color.Red;
                        lblMachine.ForeColor = Color.White;
                        break;
                    case "1B":  //계획정지
                        lblMachine.BackColor = Color.FromArgb(17, 113, 157);
                        lblMachine.ForeColor = Color.White;
                        break;
                    case "-1":  // 통신이상
                        lblMachine.BackColor = Color.Yellow;
                        lblMachine.ForeColor = Color.Black;
                        break;
                }
                lblMData1.Text = dr["planQty"].ToString();
                lblMData2.Text = dr["prodQty"].ToString();
                lblProdData1.Text = dr["itm_cd"].ToString();
                lblProdData2.Text = dr["itm_nm"].ToString();

            }
            catch
            {
                return;
            }
         }
         
     }
}

