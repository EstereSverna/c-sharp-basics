using System;
using System.Globalization;
using System.Threading;

namespace exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much money is in the account?: ");
            double money = double.Parse(Console.ReadLine());
            var myAccount = new SavingsAccount(money);
            Console.WriteLine("Enter the annual interest rate: ");
            double annualInterestRate = double.Parse(Console.ReadLine());
            Console.WriteLine("How long has the account been opened? ");
            int months = int.Parse(Console.ReadLine());

            for (int i = 1; i <= months; i++)
            {
                Console.WriteLine("Enter amount deposited for month: {0}: ", i);
                double dep = double.Parse(Console.ReadLine());
                myAccount.Deposit(dep);
                Console.WriteLine("Enter amount withdrawn for {0}: ", i);
                double withdraw = double.Parse(Console.ReadLine());
                myAccount.Withdrawal(withdraw);
                myAccount.MonthlyInterest(annualInterestRate);
            }

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine("Total deposited: {0:C}", myAccount.GetDepositedAmount());
            Console.WriteLine("Total withdrawn: {0:C}", myAccount.GetWithdrawalAmount());
            Console.WriteLine("Interest earned: {0:C}", myAccount.GetInterestEarned());
            Console.WriteLine("Ending balance: {0:C}", myAccount.GetBalance());       
        }
    }
}
