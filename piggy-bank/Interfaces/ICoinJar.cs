﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piggy_bank.Interfaces
{
    internal interface ICoinJar
    {
        void AddCoin(ICoin coin);
        decimal GetTotalAmount(); 
        void Reset();
    }
}
