using LearningCsharp24052023;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestBankAccount
{
    public class BankAccountTest
    {

        [Test]
        public void VerifyInitialBalanceIsSetCorrectly()
        {
            //Pre-requisite or setting test data

            BankAccount saurabhAccount = new BankAccount("Saurabh", 1000);

            Assert.AreEqual(1000, saurabhAccount.Balance);

            //Taking action

            //Assertion


        }


        [Test]
        public void VerifyDepositInBankAccount()
        {
            

            BankAccount saurabhAccount = new BankAccount("Saurabh", 1000);

            saurabhAccount.MakeDeposit(2000, DateTime.Now, "1st Deposit");

            Assert.AreEqual(3000, saurabhAccount.Balance);

            


        }

        [Test]
        public void verifyMonthEndInterest()
        {
            InterestEarningAccount saurabhAccount = new InterestEarningAccount("Saurabh", 4000);

            saurabhAccount.MakeDeposit(6000, DateTime.Now, "1st Deposit");

            saurabhAccount.CalculateMonthEndInterestTransaction();

            Assert.AreEqual(10500, saurabhAccount.Balance);

        }

    }
}
