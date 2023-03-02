using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        // ===================================================

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
        #endregion
    }
}
