using AutoStockTrading.Reference;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AutoStockTrading.Reference.CommonFunction;

namespace AutoStockTrading
{
    public partial class form_Main : Form
    {
        public form_Main()
        {
            InitializeComponent();
        }

        private int _scrNum = 5000;

        #region Form Events

        private void m_Menu_Login_Click(object sender, EventArgs e)
        {
            if (axKHOpenAPI.CommConnect() == 0)
            {
                //Global.AddLog($"Login 성공");
                return;
            }

            else
            {   // Log 추가 실패
                return;
            }
        }

        private void m_Menu_Logout_Click(object sender, EventArgs e)
        {
            /*
             * Message창 띄울건지 아니면 그냥 Exit 시킬건지 정해야함.
             * 우선 Exit을 시키는식으로 구현
             */

            DisconnectAllRealData();
            axKHOpenAPI.CommTerminate();

            Global.AddLog("[System] Logout.");
        }

        private void m_Menu_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        public void ChangeMainButtonColor(FORM_NAME form, bool isActivateColor) // ...FORM추가... 
        {
            if (this.InvokeRequired) { this.BeginInvoke(new Action(() => { ChangeMainButtonColor(form, isActivateColor); })); return; }

            switch(form)
            {
                case FORM_NAME.STATUS:
                    ChangeImageButtonImage(iBtn_Status, isActivateColor ? Properties.Resources.STATUS_ON : Properties.Resources.STATUS_OFF);
                    break;

                case FORM_NAME.LOG:
                    ChangeImageButtonImage(iBtn_Log, isActivateColor ? Properties.Resources.LOG_ON : Properties.Resources.LOG_OFF);
                    break;
            }
        }
        private void ChangeImageButtonImage(Guna2ImageButton control, Bitmap image)
        {
            using (Image oldImage = control.Image)
            {
                control.Image = image;
            }
        }
        private void iBtn_Dockable_Click(object sender, EventArgs e)
        {
            FORM_NAME tag = (FORM_NAME)Enum.Parse(typeof(FORM_NAME), (sender as Guna2ImageButton).Tag.ToString());

            switch (tag)
            {
                case FORM_NAME.STATUS:
                    Global.Form.DockOrHide(Global.Form.Status);
                    break;
                case FORM_NAME.LOG:
                    Global.Form.DockOrHide(Global.Form.Log);
                    break;
            }
        }
        private void DisconnectAllRealData()
        {
            for (int i = _scrNum; i > 5000; i--)
            {
                axKHOpenAPI.DisconnectRealData(i.ToString());
            }

            _scrNum = 5000;
        }

        #region 키움 API 이벤트들

        private void axKHOpenAPI_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (Error.IsError(e.nErrCode))
            {
                Global.AddLog($"[System] Login - " + Error.GetErrorMessage());
            }
            else
            {
                Global.AddLog($"[System] Login - " + Error.GetErrorMessage());
            }
        }

        #endregion
    }
}
