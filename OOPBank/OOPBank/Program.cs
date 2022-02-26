using System;
using BankLibrary;

namespace OopBank {
    class Program {
        static void Main() {
            var account = new BankAccount("Ritchiel", 1000 );
            Console.WriteLine($"Account {account.Number} was created by {account.Owner} with {account.Balance} initial balance");

            var account2 = new BankAccount("Rene", 100000);
            Console.WriteLine($"Account {account2.Number} was created by {account2.Owner} with {account2.Balance} initial balance");

            account2.MakeWithdrawal(1000, DateTime.Now, "Give this money to Ritchiel");
            Console.WriteLine($"Account {account2.Number} was created by {account2.Owner}, which now has {account2.Balance}");

            account.MakeDeposit(1000, DateTime.Now, "Take this money from Rene");
            Console.WriteLine($"Account {account.Number} was created by {account.Owner}, which now has {account.Balance}");

            account.MakeWithdrawal(500, DateTime.Now, "Xbox Game Console");
            Console.WriteLine($"Account {account.Number} was created by {account.Owner}, which now has {account.Balance}");

            Console.WriteLine($"\n{account.GetAccountHistory()}");
        }
    }
}
