using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoStockTrading
{
    static class Program
    {
        static public string Version = "Ver 1.0.0";
        /* 
         * 230217_hjkim_1.0.0 : 스따또!!!!
         */
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // 프로그램 중복실행 방지.
                Mutex mutex = new Mutex(initiallyOwned: true, name: "DirectDocking", out bool isNewProgram);

                if (isNewProgram == false)
                {
                    MessageBox.Show("Program is already running.");
                    Application.Exit();
                    return;
                }

                //// 관리자 권한인지 확인
                //if (false == new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
                //{
                //    MessageBox.Show("Please run program as administrator authority.");
                //    Application.Exit();
                //    return;
                //}

                // 모니터 해상도가 변해도 비율 유지되도록 Dpi Awareness 끔.
                Dpi.SetProcessDpiAwareness((int)Dpi.DpiAwareness.None);

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                using (form_Splash frmSplash = new form_Splash())
                {
                    if (frmSplash.ShowDialog() != DialogResult.OK)
                    {
                        Application.Exit();
                        return;
                    }
                }

                Application.Run(new form_Main());
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static class Dpi
        {
            [System.Runtime.InteropServices.DllImport("Shcore.dll")]
            public static extern int SetProcessDpiAwareness(int processDpiAwareness);

            public enum DpiAwareness
            {
                None = 0,
                SystemAware = 1,
                PerMonitorAware = 2
            }
        }
    }
}
