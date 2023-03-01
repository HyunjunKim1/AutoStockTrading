using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStockTrading.Reference
{
    class CommonTimeOut
    {
        DateTime _startTime;

        public void Start()
        {
            _startTime = DateTime.Now;
        }

        public bool IsTimeOut(int second)
        {
            TimeSpan dueTime = DateTime.Now - _startTime;

            return (dueTime.TotalSeconds > second);
        }
    }
}
