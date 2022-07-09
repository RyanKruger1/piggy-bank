using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using piggy_bank.Interfaces;
using piggy_bank.Enums;


namespace piggy_bank
{
    internal class PiggyBank : ICoinJar
    {

        List<ICoin> coinList;
        public decimal totalVolume = 0m;
        

        public PiggyBank()
        {
            coinList = new List<ICoin>();
        }
        
        public void AddCoin(ICoin coin)
        {
            totalVolume = totalVolume + coin.Volume;
            coinList.Add(coin);
        }

        public decimal GetTotalAmount()
        {
            decimal sum = 0;
            foreach(Coin c in coinList)
            {
                sum = sum + c.Amount;
            }
            return sum;
        }

        public void Reset()
        {
            coinList.Clear();
        }
    }
}
