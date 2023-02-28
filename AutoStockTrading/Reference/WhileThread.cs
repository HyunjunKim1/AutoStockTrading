using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutoStockTrading.Reference
{
    class WhileThread
    {
        Task _task;

        public delegate void UserWhileFunction();
        private UserWhileFunction _whileFunction;

        bool _stopTask = false;
        bool _startTask = false;
        int _cycle;
        bool _isFinished = false;

        public WhileThread(int cycle_ms, UserWhileFunction UserFunc)
        {
            _cycle = cycle_ms / 10;
            _whileFunction = UserFunc;
            _task = Task.Run(() => Tasking());
        }

        ~WhileThread()
        {
            Stop();
        }

        private void Tasking()
        {
            int cnt = _cycle;
            while (_stopTask == false)
            {
                if (_startTask == false)
                {
                    Thread.Sleep(10);
                    continue;
                }

                if (cnt++ < _cycle)
                {
                    Thread.Sleep(10);
                    continue;
                }

                cnt = 0;
                _whileFunction();
            }
        }

        public void Start() { _startTask = true; }
        public void Pause() { _startTask = false; }
        public void Stop() { _stopTask = true; }

        public void WaitStopThread()
        {
            return;
        }
    }
}
