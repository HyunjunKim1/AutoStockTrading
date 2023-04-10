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

        public void UpdateUI()
        {
            if(this.InvokeRequired) { this.Invoke(new Action(() => { UpdateUI(); })); return; }
        }

        private void RefreshUI(object sender, EventArgs e)
        {
            string splitStr = " § ";
            toolStripTextBox_SelectedCondition.Text = "";
            if(Global.Runtime.Now_Step > (int)OP_STEP.S0_STOP_SEARCH)
            {
                CheckedListBox cb = sender as CheckedListBox;
                if(cb != null)
                {
                    Global.Message(E_MESSAGE.OK, "조건 검색중 조건식 변경은 불가능합니다. 검색을 중지합니다.\r\n조건식 변경 후 다시 시도하세요.");
                    btn_Stop.PerformClick();
                    return;
                }
            }

            if (cLbox_ConditionList.CheckedItems.Count == 0)
                toolStripTextBox_SelectedCondition.Text = "선택된 조건식이 없습니다.";
            else if (cLbox_ConditionList.CheckedItems.Count > 20)
                Global.Message(E_MESSAGE.OK, "키움증권의 조건식은 최대 20개까지만 선택가능합니다.");
            else
            {
                foreach (var item in cLbox_ConditionList.CheckedItems)
                    toolStripTextBox_SelectedCondition.Text += item + splitStr;
                if (toolStripTextBox_SelectedCondition.Text.Length > splitStr.Length)
                    toolStripTextBox_SelectedCondition.Text = toolStripTextBox_SelectedCondition.Text.Substring(0, toolStripTextBox_SelectedCondition.Text.Length - splitStr.Length);
            }
        }

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
                    Global.Form.DockOrHide(Global.Form .Status);
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

        /// <summary>
        /// 로그인 성공시 계좌정보 가져오기.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void axKHOpenAPI_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            Global.Runtime.ConditionalNameScrNo.Clear();
            Global.Runtime.ConditionalName.Clear();
            Global.Runtime.ConditionalIdx.Clear();

            // 연결확인
            if(axKHOpenAPI.GetConnectState() == 1)
            {
                // 조건식 가져오기
                if(axKHOpenAPI.GetConditionLoad() == 1)
                {
                    string str_ID = axKHOpenAPI.GetLoginInfo("USER_ID");

                }
            }

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

        #region 매매조건 관련 Event
        private void gDgv_Condition_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Global.Runtime.Now_Step > (int)OP_STEP.S0_STOP_SEARCH)
                Global.Message(E_MESSAGE.OK, "조건 검색중엔 설정변경이 불가능합니다.");
        }
        private void gDgv_Condition_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            Global.Message(E_MESSAGE.OK, "입력값이 잘못되었습니다.");
            e.Cancel = false;
            e.ThrowException = false;
        }

        private void cLbox_ConditionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshUI(sender, e);
        }
        #endregion

    }
}
