using System;
namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            var benben = new Account("Benson", 17.25);

            Console.WriteLine(benben.ShowUserNameAndBalance());
            benben.Withdrawal(57.25);
            Console.WriteLine(benben.ShowUserNameAndBalance());
        }
    }
}
