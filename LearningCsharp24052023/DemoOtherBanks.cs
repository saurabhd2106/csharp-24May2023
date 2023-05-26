using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp24052023
{
    public class DemoOtherBanks
    {

        public static void Main(string[] args)
        {
            var giftCardBankAccount = new GiftCardAccount("Saurabh", 1000, 500);

            giftCardBankAccount.MakeWithdrawal(200, DateTime.Now, "First withdrawal");

            giftCardBankAccount.MakeWithdrawal(500, DateTime.Now, "2nd withdrawal");

            giftCardBankAccount.CalculateMonthEndInterestTransaction();

            Console.WriteLine( giftCardBankAccount.GetTransactionHistory());

            //----------------------------------

            var interestEarningBank = new InterestEarningAccount("Harman", 1000);



        }

    }
}
