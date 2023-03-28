using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStockTrading.Models
{
    class Jun_CandleInfo
    {
        public string Date { get; set; }
        public double StartPrice { get; set; }
        public double HighPrice { get; set; }
        public double LowPrice { get; set; }
        public double LastPrice { get; set; }
        public double TradeRate { get; set; }
        public Jun_CandleInfo(string m_Date, double m_SP, double m_HP, double m_LP, double m_LaP, double TR)
        {
            Date = m_Date;
            StartPrice = m_SP;
            HighPrice = m_HP;
            LowPrice = m_LP;
            LastPrice = m_LaP;
            TradeRate = TR;
        }
    }
}
