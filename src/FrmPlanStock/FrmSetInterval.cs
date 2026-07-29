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

namespace WinStatusBoard
{
    public partial class FrmSetInterval : Form
    {
        public FrmSetInterval()
        {
            InitializeComponent();
            txtInterval.Text = (Interval.DataReload / 1000).ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInterval.Text))
            {
                MessageBox.Show("값을 입력하지 않았습니다");
                return; 
            }                

            Interval.DataReload = Convert.ToInt32(txtInterval.Text) * 1000;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            //숫자만 입력되도록 필터링
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))    //숫자와 백스페이스를 제외한 나머지를 바로 처리
            {
                e.Handled = true;
            }
        }
    }
}
