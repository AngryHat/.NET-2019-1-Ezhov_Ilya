using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Defined_Exceptions;

namespace Task1
{
    class Program
    {
        public delegate void DepositOperation(decimal amount);
        public delegate void ReportOperation();

        static void Main(string[] args)
        {
            BankAccount savingAccount = new SavingBankAccount("Sarvesh", "S12345");
            BankAccount currentAccount = new CurrentBankAccount("Mark", "C12345");

            TryCatchAmount(savingAccount.Deposit, 40000);
            TryCatchAmount(savingAccount.Deposit, -1); // non-positive deposit amount ex
            TryCatchAmount(savingAccount.Deposit, 50001); // maximum deposit amount ex
            TryCatchAmount(savingAccount.Withdraw, 100000); // min balanse ex
            TryCatchAmount(savingAccount.Withdraw, 15000);
            TryCatchAmount(savingAccount.Withdraw, 1000);
            TryCatchAmount(savingAccount.Withdraw, 1000);
            TryCatchAmount(savingAccount.Withdraw, 1000);// fourth withdraw ex

            TryCatchReport(savingAccount.GenerateAccountReport);

            Console.WriteLine();
            TryCatchAmount(currentAccount.Deposit,190000);
            TryCatchAmount(currentAccount.Withdraw,1000);
            TryCatchAmount(currentAccount.Withdraw,189000);

            TryCatchReport(currentAccount.GenerateAccountReport);

            Console.ReadLine();
        }

        public static void TryCatchAmount(DepositOperation depositOperation, decimal amount)
        {
            try
            {
                depositOperation(amount);
            }
            catch (NonPositiveDepositAmountException e)
            {
                Console.WriteLine($"Operation failed!\n" +
                    $"Details: {e.Message}\n" +
                    $"Date  and time: {DateTime.Now}\n");
            }
            catch (MaxDepositAmountException e)
            {
                Console.WriteLine($"Operation failed!\n" +
                    $"Details: {e.Message}\n" +
                    $"Date  and time: {DateTime.Now}\n");
            }
            catch (WithdrawCountException e)
            {
                Console.WriteLine($"Operation failed!\n" +
                    $"Details: {e.Message}\n" +
                    $"Date  and time: {DateTime.Now}\n");
            }
            catch (MinBalanceReachedException e)
            {
                Console.WriteLine($"Operation failed!\n" +
                    $"Details: {e.Message}\n" +
                    $"Date  and time: {DateTime.Now}\n");
            }
        }

        public static void TryCatchReport(ReportOperation reportOperation)
        {
            try
            {
                reportOperation();
            }
            catch (ReportGeneratingException e)
            {
                Console.WriteLine($"Report operation failed!\n" +
                    $"Details: {e.Message}\n" +
                    $"Date  and time: {DateTime.Now}\n");
            }
        }

    }
}
