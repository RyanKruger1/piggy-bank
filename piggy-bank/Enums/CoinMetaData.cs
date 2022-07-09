using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piggy_bank.Enums
{
    public class CoinMetaData
    {
        //All values from this class has been converted to use the metric system.
        public static Dictionary<string, Dictionary<string,decimal>> coinInfo;

        public static Dictionary<string, Dictionary<string, decimal>> getCoinInformation()
        {
            coinInfo = new Dictionary<string, Dictionary<string,decimal>>();
            coinInfo.Add("Cent",
                new Dictionary<string, decimal> {
                    ["value"] = Cent.value ,
                    ["height"] = Cent.height,
                    ["diameter"] = Cent.diameter
                });

            coinInfo.Add("Nickel",
               new Dictionary<string, decimal>
               {
                   ["value"] = Nickel.value,
                   ["height"] = Nickel.height,
                   ["diameter"] = Nickel.diameter
               });

            coinInfo.Add("Dime",
               new Dictionary<string, decimal>
               {
                   ["value"] = Dime.value,
                   ["height"] = Dime.height,
                   ["diameter"] = Dime.diameter
               });

            coinInfo.Add("Quarter",
               new Dictionary<string, decimal>
               { 
                   ["value"] = Quarter.value,
                   ["height"] = Quarter.height,
                   ["diameter"] = Quarter.diameter
               });

             coinInfo.Add("Dollar",
               new Dictionary<string, decimal>
               {  
                   ["value"] = Dollar.value,
                   ["height"] = Dollar.height,
                   ["diameter"] = Dollar.diameter
               });

            return coinInfo;
        }
       
        // height and diameter is in millimeter
        // value is in us dollar 
        public struct Cent
        {
            public const decimal value = 0.01m;
            public const decimal height = 1.52m;
            public const decimal diameter = 19.05m;
        }

        public struct Nickel
        {
            public const decimal value = 0.05m;
            public const decimal height = 1.95m;
            public const decimal diameter = 21.21m;
        }

        public struct Dime
        {
            public const decimal value = 0.1m;
            public const decimal height = 1.95m;
            public const decimal diameter = 21.21m; 
        }

        public struct Quarter
        {
            public const decimal value = 0.25m;
            public const decimal height = 1.75m;
            public const decimal diameter = 24.26m;
           
        }

        public struct Dollar
        {
            public const decimal value = 1m;
            public const decimal height = 2.00m;
            public const decimal diameter = 26.49m;
        }

    }

}
// Ref: https://en.wikipedia.org/wiki/Coins_of_the_United_States_dollar#:~:text=Today%2C%20circulating%20coins%20exist%20in,by%20the%20United%20States%20Mint.
// Ref 2: https://www.usmint.gov/learn/coin-and-medal-programs/coin-specifications