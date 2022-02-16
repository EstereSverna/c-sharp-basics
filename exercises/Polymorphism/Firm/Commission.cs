using System;
using System.Collections.Generic;
using System.Text;

namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSalesMade;
        private double _commissionRate;

        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionRate) : base(eName,
            eAddress, ePhone, socSecNumber, rate)
        {
            _commissionRate = commissionRate;
        }

        public void AddSales(double totalSales)
        {
            _totalSalesMade += totalSales;
        }

        public override double Pay()
        {
            var result = base.Pay() + _totalSalesMade * _commissionRate;
            _totalSalesMade = 0;
            return result;
        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal sales made: " + _totalSalesMade;
            return result;
        }

    }
}
