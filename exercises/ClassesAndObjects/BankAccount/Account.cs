using System.Globalization;
using System.Threading;

namespace BankAccount
{
    internal class Account
    {
            private string _name;
            private double _money;

            public Account(string v1, double v2)
            {
                _name = v1;
                _money = v2;
            }

            public string ShowUserNameAndBalance()
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture.NumberFormat.CurrencyNegativePattern = 1;
                return $"{_name}, {_money:C}";
            }

            public double Withdrawal(double i)
            {
                return _money -= i;
            }

            public void Deposit(double i)
            {
                _money += i;
            }

            public double Balance()
            {
                return _money;
            }

            public override string ToString()
            {
                return $"{_name}: {_money}";
            }

            public string Name
            {
                get => _name;
                set => _name = value;
            }
    }
}
