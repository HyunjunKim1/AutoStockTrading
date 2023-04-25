using AutoStockTrading.Forms.Popup;
using AutoStockTrading.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoStockTrading
{
    // 프로그램 구성 Enum
    //==============================================
    public enum E_MESSAGE
    {
        YESNO,
        OK,
        YESNO_TIMER,
        OK_TIMER
    };
    //==============================================

    // 동작 및 매매등 키움관련 구성 Enum
    //==============================================
    public enum OP_STEP
    {
        // STEP
        S1_VERIFICATION,
        S2_SEARCH,
        S3_DEFAULT_SRC_SEARCH,
        S4_ACCOUNT_SEARCH,
        S5_PROFIT_SEARCH,
        S0_STOP_SEARCH,
    }
    //==============================================
    public enum SCREEN_NUMBER
    {
        조건식조회               = 1000,
        조건검색종목실시간시세   = 1101,
        계좌수익률실시간시세     = 1102,
        미체결주문취소           = 1103,
        주문체결정보             = 1104,
        계좌수익률               = 1105,
        미체결내역조회           = 1106,
        매매주문전송             = 1107,
        당일실현손익금           = 1108,
        예수금조회               = 1109,
    }
}


namespace AutoStockTrading.Reference
{
    
    class CommonFunction
    {
        private static CommonFunction instance;
        public static CommonFunction Global
        {
            get
            {
                if (instance == null)
                    instance = new CommonFunction();
                return instance;
            }
        }

        // Global Class 정의 =============================================
        public FormManager Form             = new FormManager();

        // 기능 Class =============================================
        public CommonCommunication Comm     = new CommonCommunication();
        public CommonLog Log                = new CommonLog();
        public CommonTimeOut Timeout        = new CommonTimeOut();
        // ========================================================

        // 주식 Class =============================================
        public Jun_RuntimeSet Runtime       = new Jun_RuntimeSet();
        public Jun_StocksInfo StockInfo     = new Jun_StocksInfo();
        // ========================================================

        public string strUserID = "misunjun";

        #region Global Function
        public static DataTable GetDataGridViewAsDataTable(DataGridView _DataGridView)
        {
            try
            {
                if (_DataGridView.ColumnCount == 0)
                    return null;
                DataTable dtSource = new DataTable();
                //////create columns
                foreach (DataGridViewColumn col in _DataGridView.Columns)
                {
                    if (col.ValueType == null)
                        dtSource.Columns.Add(col.Name, typeof(string));
                    else
                        dtSource.Columns.Add(col.Name, col.ValueType);
                    dtSource.Columns[col.Name].Caption = col.HeaderText;
                }
                ///////insert row data
                foreach (DataGridViewRow row in _DataGridView.Rows)
                {
                    DataRow drNewRow = dtSource.NewRow();
                    foreach (DataColumn col in dtSource.Columns)
                    {
                        drNewRow[col.ColumnName] = row.Cells[col.ColumnName].Value;
                    }
                    dtSource.Rows.Add(drNewRow);
                }
                return dtSource;
            }
            catch
            {
                return null;
            }
        }
        public static void SaveDataSet(DataSet _ds)
        {
            _ds.WriteXml("./AutoStockTrading_log.xml", XmlWriteMode.WriteSchema);
        }

        public void AddLog(string Msg)
        {
            Msg = $"[{DateTime.Now:HH:mm:ss:fff}] {Msg}"; // [19:23:34:212] Blah, blah, blah.
            Log.AddLog(Msg);

            // 로그 form에 로그추가
            Global.Form.Log?.AddLog(Msg);
        }
        public void Delay(int nMilliseconds)
        {
            DateTime _dtNow = DateTime.Now;
            TimeSpan _tsDuration = new TimeSpan(0, 0, 0, 0, nMilliseconds);
            DateTime _dtAfterWards = _dtNow.Add(_tsDuration);

            while (_dtAfterWards >= _dtNow)
            {
                Application.DoEvents();
                _dtNow = DateTime.Now;
            }
        }
        public DialogResult Message(E_MESSAGE MessageType, string Message)
        {
            DialogResult DResult = DialogResult.None;

            Global.Form.Main.Invoke(new Action(() =>
            {
                using (form_Message frm_Message = new form_Message(MessageType, Message))
                {
                    frm_Message.TopMost = true;
                    DResult = frm_Message.ShowDialog();
                }
            }));

            return DResult;
        }
        #endregion
    }
}
