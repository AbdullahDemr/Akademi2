using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_React_Ödev_3
{
    public class Manager : Employee
    {
        public int TeamSize { get; set; }

        
        public override double CalculateBonus()
        {
            return Salary * 0.20; 
        }
    }
}
