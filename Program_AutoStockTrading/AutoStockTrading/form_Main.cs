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

            lbl_Version.Text = Program.Version;
            Global.Form.Main = this;
        }

        private int _scrNum = 5000;

        #region Form Events
        private void form_Main_Load(object sender, EventArgs e)
        {
            Global.Form.CreatePanelAndSetForm(pnl_Dock1, Global.Form.Status, true);
            Global.Form.CreatePanelAndSetForm(pnl_Dock1, Global.Form.Log, true);

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

        private void form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Global.Message(E_MESSAGE.YESNO, "Do you want to close the program?") != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }

            Global.Form.Dispose();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
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
