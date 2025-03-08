﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        
        public virtual double CalculateInterest()
        {
            return 0; 
        }
    }
}
