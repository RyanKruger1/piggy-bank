using piggy_bank.Enums;
using piggy_bank.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piggy_bank
{
    internal class Coin : ICoin
    {
        Dictionary<string, decimal> metaData;
        public Coin(string name)
        {
            metaData = CoinMetaData.getCoinInformation()[name];

            decimal raduis = metaData["diameter"] / 2;

            this.Amount = metaData["value"];

            this.Volume = (decimal)Math.PI * metaData["height"] * (decimal)Math.Pow((double)raduis,2);
        }

        public decimal Amount { get;set;}

        public decimal Volume { get; set; }
    }
}
