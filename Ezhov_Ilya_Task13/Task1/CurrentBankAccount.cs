using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Defined_Exceptions;

namespace Task1
{
    public class CurrentBankAccount : BankAccount
    {
        public CurrentBankAccount(string accountOwnerName, string accountNumber)
            : base(accountOwnerName, accountNumber)
        {
            this.MinAccountBalance = 0m;
            this.MaxDepositAmount = 100000000m;
            InteresetRate = .25m;
        }

        public override void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new NonPositiveDepositAmountException("You can not deposit amount less than zero");
            }

            if (amount >= MaxDepositAmount)
            {
                throw new MaxDepositAmountException(string.Format("You can not deposit amount greater than {0}", MaxDepositAmount.ToString()));
            }

            AccountBalance = AccountBalance + amount;
            TransactionSummary = string.Format("{0}\n Deposit:{1}", TransactionSummary, amount);
        }

        public override void Withdraw(decimal amount)
        {
            if (AccountBalance - amount <= MinAccountBalance)
            {
                throw new MinBalanceReachedException("You can not withdraw amount from your Current Account as Minimum Balance limit is reached");
            }

            AccountBalance = AccountBalance - amount;
            TransactionSummary = string.Format("{0}\n Withdraw:{1}", TransactionSummary, amount);
        }

        public override void GenerateAccountReport()
        {
            Console.WriteLine("Current Account Report");
            base.GenerateAccountReport();
        }
    }
}
