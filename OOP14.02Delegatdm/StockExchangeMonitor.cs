using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class StockExchangeMonitor
    {

        public delegate void PriceChange(int price);

        public PriceChange PriceChangeHandler { get; set; }

        public void Start()
        {
            while(true)
            {
                int bankofamericansbank = (new Random().Next(0, 1000));
                PriceChangeHandler(bankofamericansbank);
                Thread.Sleep(1000);
            }
        }
    }
}
