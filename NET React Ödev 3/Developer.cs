using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET_React_Ödev_3
{
    public class Developer : Employee
    {
        public string About { get; set; }

        
        public override double CalculateBonus()
        {
            return Salary * 0.10; 
        }
    }

}
