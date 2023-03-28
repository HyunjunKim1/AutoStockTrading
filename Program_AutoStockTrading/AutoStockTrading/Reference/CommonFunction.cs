using AutoStockTrading.Forms.Popup;
using AutoStockTrading.Models;
using System;
using System.Collections.Generic;
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
        // ========================================================

        #region Global Function

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
