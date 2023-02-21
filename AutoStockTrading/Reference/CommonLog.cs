using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoStockTrading.Reference
{
    class CommonLog : IDisposable
    {
        private List<string> _logList;

        Task taskLog;
        object _Lock;

        bool m_StopTaskLog;
        bool m_Disposed;
        bool m_StartLogging;
        string m_StartupPath;

        #region 생성 소멸자
        // 생성자
        public CommonLog(string StartupPath)
        {
            _logList = new List<string>();

            m_StopTaskLog   = false;
            m_Disposed      = false;
            m_StartLogging  = false;

            m_StartupPath  = StartupPath;

            _Lock = new object();

            taskLog = Task.Run(() => Logging());
        }
        // 소멸자
        ~CommonLog()
        {
            Dispose(false);
        }
        #endregion

        #region Dispose

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool isDispose)
        {
            if (m_Disposed)
                return;

            if(isDispose)
            {
                //pass
            }

            m_StopTaskLog = true;
            taskLog.Wait();

            m_Disposed = true;
        }

        #endregion


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

        private void LoggingToFile()
        {
            int nCount = 0;
            string LogMonthPath = string.Empty;
            string FileName = string.Empty;
            string LogContent = string.Empty;

            nCount = GetLogCount();

            if (nCount <= 0)
                return;

            FileStream fs = null;
            StreamWriter writer = null;

            try
            {
                // Log를 저장 하기 위한 Directory를 검사 및 생성.
                LogMonthPath = Create_Log_Directory(); // C:\\...BIN\\_log\\2023_02

                // C:\\..BIN\\_log\\2023_02\\이름[2023-02-21].log
                FileName = LogMonthPath + "\\AutoTrading[" + DateTime.Now.ToString("yyyy-MM-dd") + "].log";

                // 기존에 생성된 파일이 있는지 검사 , 없을 경우 Create
                fs = new FileStream(FileName, FileMode.Append, FileAccess.Write); // 이어쓰기, 없으면 파일생성.
                writer = new StreamWriter(fs, System.Text.Encoding.UTF8);

                LogContent = GetLog(); // LogList에서 첫번째 Log를 읽어옴
                LogContent = LogContent.TrimEnd();

                // Log를 File에 저장
                writer.WriteLine(LogContent);
                //tssLbl_Log.Text = LogContent;                    
            }
            catch (Exception e)
            {
                Console.WriteLine("[Exception] LoggingToFile() : " + e.ToString());
            }
            finally
            {
                writer.Flush();
                writer.Close();
                fs.Close();
            }
        }
        private int GetLogCount()
        {
            int Count = 0;

            Monitor.Enter(_Lock);
            try
            {
                Count = _logList.Count;
            }
            catch (Exception e)
            {
                Console.WriteLine("[Exception] GetLogCount() : " + e.ToString());
            }
            finally
            {
                Monitor.Exit(_Lock);
            }
            return Count;
        }

        string Create_Log_Directory()
        {
            string sDate = string.Empty;
            string sFull_Path = string.Empty;

            sDate = DateTime.Now.ToString("yyyy") + "_" + DateTime.Now.ToString("MM"); // 2019_04

            sFull_Path = m_StartupPath + "\\_Log\\" + sDate; // "C:\\...BIN\\_log\\2019_04";

            DirectoryInfo di = new DirectoryInfo(sFull_Path);
            if (di.Exists == false)
                di.Create();

            return sFull_Path;
        }

        private string GetLog()
        {
            string Content = string.Empty;

            Monitor.Enter(_Lock);
            try
            {
                Content = _logList[0];
                _logList.RemoveAt(0);
            }
            catch (Exception e)
            {
                Console.WriteLine("[Exception] GetLog() : " + e.ToString());
            }
            finally
            {
                Monitor.Exit(_Lock);
            }
            return Content;
        }

        public void AddLog(string Msg)
        {
            // 로깅이 시작되지 않았으면 리스트에 추가하지 않는다.
            if (m_StartLogging == false)
                return;

            Monitor.Enter(_Lock);
            try
            {
                // Log를 LogList에 추가하여 LoggingToFile()에서 File에 기록 하도록 함
                _logList.Add(Msg);
            }
            catch (Exception e)
            {
                Console.WriteLine("[Exception] AddLog() : " + e.ToString());
            }
            finally
            {
                Monitor.Exit(_Lock);
            }
        }

        public void Start()
        {
            m_StartLogging = true;
        }

        public void Pause()
        {
            m_StartLogging = false;
        }
    }
}
