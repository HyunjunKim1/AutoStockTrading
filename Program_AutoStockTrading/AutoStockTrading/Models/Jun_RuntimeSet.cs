using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStockTrading.Models
{
    class Jun_RuntimeSet
    {
        public List<string> ConditionalNameScrNo   = new List<string>();
        public List<string> ConditionalName        = new List<string>();
        public List<int> ConditionalIdx            = new List<int>();
        public bool RefreshAccount      = false;
        public bool RealTimeDataReceive = false;
        public bool Stopbuying          = false;
        public double Evaluation_fee;
        public double Deposit = 0;
        public double Cash    = 0;
        public int profit     = 0;
        public int loss       = 0;
        public int Now_Step   = (int)OP_STEP.S0_STOP_SEARCH;

        public void Initialize()
        {
            Now_Step = (int)OP_STEP.S1_VERIFICATION;
            RealTimeDataReceive = false;
            Stopbuying = false;
            profit = 0;
            loss = 0;
        }
    }
}
