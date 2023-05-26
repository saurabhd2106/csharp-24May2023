using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{
    public class BankAccount
    {
        public string NameOfTheOwner { get; set; }

        public string Number { get; }

        public decimal Balance { get
            {

                decimal balance = 0;

                foreach (var item in transactionList)
                {
                    balance += item.Amount;
                }
                
                return balance;
            }
        }

        private static long accountNumberSeries = 7834276000l;

       

        public BankAccount(string name, decimal initialAmount)
        {
            NameOfTheOwner = name;

            Number =   accountNumberSeries.ToString();
            
            accountNumberSeries++;

            this.MakeDeposit(initialAmount, DateTime.Now, "Initial balance");
            
        }

        private List<Transaction> transactionList = new List<Transaction>();



        public void MakeDeposit(decimal amount, DateTime date, string comments)
        {
            if(amount <= 0)
            {
                throw new ArgumentException(nameof(amount), "Invalid amount, amount cannot be zero or negative" );
            }

            Transaction deposit = new Transaction(amount, date, comments);

            transactionList.Add(deposit);

        }

        public void MakeWithdrawal(decimal amount, DateTime date, string comments)
        {
            if(amount <= 0)
            {
                throw new ArgumentException(nameof(amount), "Invalid amount");
            }

            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not suffiecient Balance");
            }

            Transaction withdrawal = new Transaction(-amount, date, comments);

            transactionList.Add(withdrawal);
        }

        public string GetTransactionHistory()
        {
            var report = new StringBuilder();

            report.AppendLine("Date \t Amount \t Balance \t Comments");

            decimal balance = 0;

            foreach(var transaction in transactionList)
            {
                balance += transaction.Amount;
                report.AppendLine($"{transaction.Date.ToShortDateString()} \t {transaction.Amount} \t {balance} \t {transaction.Comments}");
            }

            return report.ToString();
        }

        public virtual void CalculateMonthEndInterestTransaction()
        {

        }


    }
}
