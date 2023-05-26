using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{
    public class DemoBankAccount
    {
        public static void Main(string[] args)
        {
            BankAccount saurabhAccount = new BankAccount("Saurabh", 1000);

            saurabhAccount.NameOfTheOwner = "Saurabh Dhingra";

            saurabhAccount.MakeDeposit(2000, DateTime.Now, "1st deposit");

            saurabhAccount.MakeDeposit(3000, DateTime.Now, "2nd deposit");

            saurabhAccount.MakeWithdrawal(800, DateTime.Now, "3rd withdrawal");

            Console.WriteLine($"A bank account with account number {saurabhAccount.Number} is opened for {saurabhAccount.NameOfTheOwner} with balance {saurabhAccount.Balance}" );

            Console.WriteLine( saurabhAccount.GetTransactionHistory());


            BankAccount harmanAccount = new BankAccount("Harman", 2000);

            Console.WriteLine($"A bank account with account number {harmanAccount.Number} is opened for {harmanAccount.NameOfTheOwner} with balance {harmanAccount.Balance}");

        }
    }
}
