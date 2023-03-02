using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoStockTrading.Reference
{
    class CommonLog : IDisposable
    {
        private List<string> _logList;

        WhileThread _threadLogging;
        object _criticalSection;

        public CommonLog()
        {
            _logList = new List<string>();
            _criticalSection = new object();
            _threadLogging = new WhileThread(10, LoggingToFile);
            _threadLogging.Start();
        }

        public void Dispose()
        {
            _threadLogging.Stop();
            _threadLogging.WaitStopThread();
        }

        private void LoggingToFile()
        {
            if (GetLogCount() <= 0)
                return;

            try
            {
                // C:\\..BIN\\_Log\\2022_06\\DirectDocking[2022-06-12].log
                string logPath = $@"{GetLogFolderPath()}\DirectDocking[{DateTime.Now:yyyy-MM-dd}].log";

                using (FileStream fs = new FileStream(logPath, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
                {
                    sw.WriteLine(GetLog());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Exception] LoggingToFile() : {ex.Message}");
            }
        }

        private int GetLogCount()
        {
            int count = 0;

            Monitor.Enter(_criticalSection);
            try
            {
                count = _logList.Count;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Exception] GetLogCount() : {ex.Message}");
            }
            finally
            {
                Monitor.Exit(_criticalSection);
            }
            return count;
        }

        string GetLogFolderPath()
        {
            string path = $@"{Application.StartupPath}\_Log\{DateTime.Now:yyyy}_{DateTime.Now:MM}"; // "C:\\...BIN\\_log\\2022_06";

            DirectoryInfo logFolder = new DirectoryInfo(path);
            if (logFolder.Exists == false)
                logFolder.Create();

            return path;
        }

        private string GetLog()
        {
            string log = string.Empty;

            Monitor.Enter(_criticalSection);
            try
            {
                log = _logList[0];
                _logList.RemoveAt(0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Exception] GetLog() : {ex.Message}");
            }
            finally
            {
                Monitor.Exit(_criticalSection);
            }
            return log.Trim();
        }

        public void AddLog(string log)
        {
            Monitor.Enter(_criticalSection);
            try
            {
                _logList.Add(log);
            }
            catch (Exception e)
            {
                Console.WriteLine($"[Exception] AddLog() : {e.Message}");
            }
            finally
            {
                Monitor.Exit(_criticalSection);
            }
        }
    }
}
