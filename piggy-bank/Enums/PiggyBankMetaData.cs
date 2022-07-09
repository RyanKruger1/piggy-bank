using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piggy_bank.Enums
{
    internal class PiggyBankMetaData
    {
        public struct PiggyBank
        {
            public const decimal maxVolumeOunces = 42.0m;//imperial fluid ounces
            public const decimal maxVolumeMl = 1243.2m;// millileter Volume(Metric) = Volume(Imperial - fluid ounces)  * 29,5735
            public const decimal maxVolumeCMM = 1243200.0m; // Volume(CMM) = Volume(ML) * 1000
        }
    }
}
