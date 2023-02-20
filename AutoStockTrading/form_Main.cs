using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoStockTrading
{
    public partial class form_Main : Form
    {
        public form_Main()
        {
            InitializeComponent();
            axKHOpenAPI.CommConnect();

        }

        #region Form Events

        private void m_Menu_Login_Click(object sender, EventArgs e)
        {
            if (axKHOpenAPI.CommConnect() == 0)
                // Log 추가 성공
                return;

            else
                // Log 추가 실패
                return;
        }

        private void m_Menu_Logout_Click(object sender, EventArgs e)
        {
            /*
             * Message창 띄울건지 아니면 그냥 Exit 시킬건지 정해야함.
             * 우선 Exit을 시키는식으로 구현
             */
            Application.Exit();
        }


        #endregion

    }
}
