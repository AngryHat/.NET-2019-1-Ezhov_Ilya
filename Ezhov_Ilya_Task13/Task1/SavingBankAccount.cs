using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Defined_Exceptions;

namespace Task1
{
    public class SavingBankAccount : BankAccount
    {
        protected int withdrawCount = 0;

        public SavingBankAccount(string accountOwnerName, string accountNumber)
            : base(accountOwnerName, accountNumber)
        {
            this.MinAccountBalance = 20000m;
            this.MaxDepositAmount = 50000m;
            InteresetRate = 3.5m;
        }

        public override void Deposit(decimal amount)

        {
            if (amount <= 0)
            {
                throw new NonPositiveDepositAmountException("Deposit amount must be positive");
            }

            if (amount >= MaxDepositAmount)
            {
                throw new MaxDepositAmountException($"Your maximum deposit amount is {MaxDepositAmount.ToString()}");
            }

            AccountBalance = AccountBalance + amount;

            TransactionSummary = string.Format("{0}\n Deposit:{1}", TransactionSummary, amount);
        }

        public override void Withdraw(decimal amount)
        {
            if (withdrawCount >= 3)
            {
                throw new WithdrawCountException("You can not withdraw amount more than thrice");
            }

            if (AccountBalance - amount <= MinAccountBalance)
            {
                throw new MinBalanceReachedException("You can not withdraw amount from your Savings Account as Minimum Balance limit is reached");
            }

            AccountBalance = AccountBalance - amount;
            withdrawCount++;

            TransactionSummary = string.Format("{0}\n Withdraw:{1}", TransactionSummary, amount);
        }

        public override void GenerateAccountReport()
        {
            Console.WriteLine("Saving Account Report:");
            
            if (AccountBalance < 25000) // changed to demonstrate exp
            {
                throw new ReportGeneratingException("Insifficient amount of funds to generate report");
            }

            base.GenerateAccountReport();

            Console.WriteLine("Sending Email for Account {0}", AccountNumber);
        }
    }
}
