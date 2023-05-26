using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{
    public class InterestEarningAccount : BankAccount
    {
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {
                
        }

        public override void CalculateMonthEndInterestTransaction()
        {

            if (this.Balance > 500)
            {
                decimal interest = this.Balance * 0.05m;

                MakeDeposit(interest, DateTime.Now, "Month end year transaction");

            }

        }

    }

    public class LineOfCreditAccount : BankAccount
    {
        public LineOfCreditAccount(string name, decimal initialBalance) : base (name, initialBalance)
        {
                
        }

        //Polymorphism
        public override void CalculateMonthEndInterestTransaction()
        {
            if (this.Balance < 0)
            {
                decimal interest = -Balance * 0.07m;

                MakeWithdrawal(interest, DateTime.Now, "Charging monthly interest");

            }
            
        }

    }

    public class GiftCardAccount : BankAccount
    {
        private decimal _monthlyDeosit = 0;

        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeosit) : base(name, initialBalance)
        {
            _monthlyDeosit = monthlyDeosit;
        }

        public override void CalculateMonthEndInterestTransaction()
        {
            if(_monthlyDeosit != 0)
            {
                MakeDeposit(_monthlyDeosit, DateTime.Now, "Monthly deposit");

            }


        }

    }
}
