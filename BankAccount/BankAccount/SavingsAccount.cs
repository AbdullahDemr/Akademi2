﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class SavingsAccount : BankAccount
    {
        
        public override double CalculateInterest()
        {
            return Balance * 0.05; 
        }
    }
}
