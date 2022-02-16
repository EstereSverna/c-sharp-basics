namespace exercise_8
{
    internal class SavingsAccount
    {
        private double _balance;
        private double _deposited;
        private double _withdrawn;
        private double _interestEarned;
        public SavingsAccount(double startBalance)
        {
            _balance = startBalance;
        }

        public void Withdrawal(double i)
        {
            _balance -= i;
            _withdrawn += i;
        }

        public void Deposit(double i)
        {
            _balance += +i;
            _deposited += i;
        }

        public void MonthlyInterest(double annualInterest)
        {
            _interestEarned += _balance * annualInterest / 12;
            _balance += _balance * annualInterest / 12;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public double GetInterestEarned()
        {
            return _interestEarned;
        }

        public double GetWithdrawalAmount()
        {
            return _withdrawn;
        }

        public double GetDepositedAmount()
        {
            return _deposited;
        }
    }
}
