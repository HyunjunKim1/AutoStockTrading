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
                _dtConditionList.Rows.Add(dr);

                //조건식 번호, 조건식 이름
                int ConditionNumber = int.Parse(item.Substring(0, 3));
                string ConditionName = item.Substring(item.IndexOf("^") + 1, item.Length - item.IndexOf("^") - 1);

                Global.Runtime.ConditionalNameScrNo.Add(Convert.ToInt32((int)SCREEN_NUMBER.조건식조회 + Global.Runtime.ConditionalNameScrNo.Count).ToString());
                Global.Runtime.ConditionalName.Add(ConditionName);
                Global.Runtime.ConditionalIdx.Add(ConditionNumber);

                strCondition = string.Format($"{_dtConditionList.Rows.Count}{item.Split('^')[1]}");
                cLbox_ConditionList.Items.Add(strCondition, strCondition.Contains("B") ? true : strCondition.Contains("S") ? true : false);
            }

            if(_dtConditionList.Rows.Count > 0)
            {
                btn_Start.Enabled = true;
                btn_Stop.Enabled = true;

                Global.AddLog("[System] Server Connected, Receive condition list");
                btn_Start.PerformClick();
            }
        }

        // 조건 검색 결과
        private void axKHOpenAPI_OnReceiveTrCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
        {
            Global.AddLog("[System] - Receive 'Search condition'");

            lock(TrLock)
            {
                Global.AddLog($"[System] - Condition Search event - {e.strConditionName}");
                if(e.strCodeList != "")
                {
                    char[] delimiterChars = { ';' };

                    // 마지막 ';' 삭제
                    string CodeList = e.strCodeList.Remove(e.strCodeList.Length - 1);

                    //최초검색 종목들 정보입력 여기서함
                    List<string> lstSearchStocks = new List<string>();
                    lstSearchStocks.AddRange(new List<string>(CodeList.Split(delimiterChars)));

                    if(lstSearch_HVStocks.Count > 50)
                    {
                        Global.Runtime.Now_Step = (int)OP_STEP.S0_STOP_SEARCH;
                        return;
                    }

                    Global.AddLog($"[System] Search stocks - {CodeList}");

                    foreach(var item in lstSearchStocks)
                    {
                        Global.StockInfo = new Models.Jun_StocksInfo();
                        Global.StockInfo.StockCode = item;
                        Global.StockInfo.StockName = axKHOpenAPI.GetMasterCodeName(item);

                        if (Global.StockInfo.Seach_fomula == "-")
                            Global.StockInfo.Seach_fomula = e.strConditionName;

                        Global.StockInfo.SignalTime = DateTime.Now;
                        Global.StockInfo.N_Price = -1;
                        Global.StockInfo.Now_isSearching = true;

                        // 매수 조건식이거나 매도 조건식인 경우 보유중 종목만 표시
                        if(Global.StockInfo.Seach_fomula.Contains("B") || 
                            (Global.StockInfo.Seach_fomula.Contains("S") && _dtBalance.Select(string.Format($"Code = {item}")).Length > 0
                            && Convert.ToDouble(_dtBalance.Select(string.Format($"Code = {item}"))[0].Field<string>("Profit Ration (%)")) > 0))
                        {
                            lstSearch_HVStocks.Add(Global.StockInfo);
                            if (!lstStocksCode.Contains(Global.StockInfo.StockCode))
                            {
                                lstStocksCode.Add(Global.StockInfo.StockCode);
                                axKHOpenAPI.SetRealReg(Convert.ToInt32(SCREEN_NUMBER.조건검색종목실시간시세).ToString(), item, "10;11;12;13;16;17", "1");
                                // FID=10:현재가, 11:전일대비, 12:등락률, 13:누적거래량, Opt=1 추가등록
                                // 41 ~ 45: 매수호가 1~5호가, 51 ~ 55: 매도호가 1~5호가
                            }
                        }
                    }
                }
                else { }

                Global.AddLog($"[System] - Start condition searching.. {e.strConditionName}");
                arGetDataCondSearching.Set();
            }
        }

        private void axKHOpenAPI_OnReceiveRealCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealConditionEvent e)
        {

        }
        #endregion
    }
}
