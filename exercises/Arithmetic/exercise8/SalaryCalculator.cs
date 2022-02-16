using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise8
{
    public class SalaryCalculator
    {
        const int minBasePay = 8;
        const int maxHours = 60;

        public double Calculate(double basePay, int hoursWorked)
        {
            if (hoursWorked > maxHours || basePay < minBasePay)
            {
                throw new InvalidBasePayOrHours();
            }
            else
            {
                return hoursWorked > 40
                    ? Math.Round(basePay * (40 + 1.5 * (hoursWorked - 40)), 2)
                    : Math.Round(basePay * hoursWorked, 2);
            }
        }
    }
}
