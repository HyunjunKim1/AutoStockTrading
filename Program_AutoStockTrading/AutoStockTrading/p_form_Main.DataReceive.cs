using AutoStockTrading.Reference;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AutoStockTrading.Reference.CommonFunction;

namespace AutoStockTrading
{
    public partial class form_Main
    {
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
            if (axKHOpenAPI.GetConnectState() == 1)
            {
                // 조건식 가져오기
                if (axKHOpenAPI.GetConditionLoad() == 1)
                {
                    string str_ID = axKHOpenAPI.GetLoginInfo("USER_ID");
                    tabControl1.SelectedIndex = 1;

                    if(str_ID != Global.strUserID)
                    {

                    }

                    char[] delimiterChars = { ';' };
                    string strAccount = axKHOpenAPI.GetLoginInfo("ACCLIST");
                    string[] AccountList = strAccount.Split(delimiterChars);

                    foreach (var item in AccountList)
                        toolStripComboBox_Account.Items.Add(item);

                    toolStripComboBox_Account.SelectedIndex = 0;
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


        private void axKHOpenAPI_OnReceiveConditionVer(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveConditionVerEvent e)
        {
            Global.AddLog("[System] Read Condition List.");
            string strCondition;

            char[] delimiterChars = { ';' };

            // 마지막 - 1은 ';' 때문
            strCondition = axKHOpenAPI.GetConditionNameList().Remove(axKHOpenAPI.GetConditionNameList().Length - 1);
            string[] conditionList = strCondition.Split(delimiterChars);

            foreach(var item in conditionList)
            {
                DataRow dr = _dtConditionList.NewRow();
                dr.SetField<string>(0, string.Format($"{_dtConditionList.Rows.Count}{item.Split('^')[1]}"));
            }
        }
        #endregion
    }
}
