using System;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            AccountActions firstAccount = new AccountActions("First account", 100.00);
            firstAccount.Deposit(20.0);
            Console.WriteLine(firstAccount);

            AccountActions mattsAccount = new AccountActions("Matt's account", 1000.00);
            AccountActions myAccount = new AccountActions("My account", 0.00);

            mattsAccount.Withdrawal(100.00);
            myAccount.Deposit(100.00);

            Console.WriteLine(mattsAccount);
            Console.WriteLine(myAccount);

            AccountActions A = new AccountActions("A", 100.00);
            AccountActions B = new AccountActions("B", 0.00);
            AccountActions C = new AccountActions("C", 0.00);

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);

            Transfer(A, B, 50.0);
            Transfer(A, C, 25.0);

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
        }

        public static void Transfer(AccountActions from, AccountActions to, double howMuch)
        {
            from.Withdrawal(howMuch);
            to.Deposit(howMuch);
        }
    }
}
