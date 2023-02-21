using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        // Forms =============================================
        public form_Main frm_Main;
        // ===================================================

        // Class =============================================
        public CommonCommunication  Comm;
        public CommonLog            Log;
        // ===================================================

        #region Global Function

        public void AddLog(string Msg)
        {
            string Time = string.Empty;
            string Content = string.Empty;

            //Time = DateTime.Now.ToString("hh:mm:ss:fff");

            Time = DateTime.Now.ToString("HH:mm:ss:fff");

            Content = "[" + Time + "] " + Msg; // [19:23:34:212] Logging this way.

            Log.AddLog(Content);

            if (frm_Main != null)
            {
                frm_Main.Invoke(new Action(delegate
                {
                    frm_Main.lbl_Log.Text = Content;
                }));
            }
        }
        #endregion
    }
}
