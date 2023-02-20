using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoStockTrading.Reference
{
    class CommonLog
    {
        private List<string> _logList;

        Task taskLog;
        object _Lock;

        bool m_StopTaskLog;
        bool m_Disposed;
        bool m_StartLogging;
        string m_StartupPath;

        public CustomLog(string StartupPath)
        {
            _logList = new List<string>();

            m_StopTaskLog   = false;
            m_Disposed      = false;
            m_StartLogging  = false;

            m_StartupPath  = StartupPath;

            _Lock = new object();

            taskLog = Task.Run(() => Logging());
        }

        private void Logging()
        {
            while(m_StopTaskLog == false)
            {
                if(!m_StartLogging)
                {
                    Thread.Sleep(10);
                    continue;
                }

                // File에다가 Log 심어넣어버리기
                LoggingToFile();

                Thread.Sleep(10);
            }
        }
    }
}
