using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoStockTrading.Models
{
    class Jun_StocksInfo 
    {
        public string StockCode;
        public string StockName;
        public string Seach_fomula = "-"; //검출검색식
        public double N_Price;          //현재가
        public double Y_Price;          //전일대비
        public double Fluctuation;      //등락률
        public double Market_Price;     //시가대비
        public double High_Price;       //고가대비
        public double Trading_Ratio;    //거래량
        public double High_PriceRatio_250; // 250 최고가대비율
        public double High_Price_250;   // 250 최고가
        public DateTime SignalTime;
        public bool Now_isSearching;

        // 일봉, 5분봉~60분봉
        public List<Jun_CandleInfo> l_DayInfo    = new List<Jun_CandleInfo>();
        public List<Jun_CandleInfo> l_5minInfo   = new List<Jun_CandleInfo>();
        public List<Jun_CandleInfo> l_30minInfo  = new List<Jun_CandleInfo>();
        public List<Jun_CandleInfo> l_60minInfo  = new List<Jun_CandleInfo>();
    }
}
