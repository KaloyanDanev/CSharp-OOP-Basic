using System;

namespace _02._Bank_Account_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            account.Id = 1;
            Console.WriteLine(account);
        }
    }
}
