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


    }
}
