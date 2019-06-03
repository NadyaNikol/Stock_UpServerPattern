using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Client : IObServer
    {
        public double USD { get; set; }
        public double BTC { get; set; }
        public double CourceForSell { get; set; }
        public double CourceForBuy { get; set; }
        public double SumForBuy { get; set; }
        public double SumForSell{ get; set; }
        public string Login{ get; set; }

        public void Update(IMyobserable obserable)
        {
            Stock stock = obserable as Stock;
            if (stock.BTCCource <= this.CourceForBuy)
            {
                if (this.SumForBuy*stock.BTCCource <this.USD)
                {
                    this.BTC += this.SumForBuy;
                    this.USD -= SumForBuy * stock.BTCCource;
                    this.SumForBuy = 0;
                }
            }

            else
            {
                if (stock.BTCCource >= this.CourceForSell)
                {
                    if (this.BTC > this.SumForSell)
                    {
                        this.USD += this.SumForSell * stock.BTCCource;
                        this.BTC -= this.SumForSell;
                        this.SumForSell = 0;
                    }
                }
            }
        }
    }
}
