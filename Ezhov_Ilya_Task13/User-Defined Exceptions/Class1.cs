using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Exceptions
{
    public class NonPositiveDepositAmountException : Exception
    {
        public NonPositiveDepositAmountException() : base()
        {
        }

        public NonPositiveDepositAmountException(string message) : base(message)
        {
        }

        public NonPositiveDepositAmountException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class MaxDepositAmountException : Exception
    {
        public MaxDepositAmountException()
        {
        }

        public MaxDepositAmountException(string message) : base(message)
        {
        }

        public MaxDepositAmountException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class WithdrawCountException : Exception
    {
        public WithdrawCountException()
        {
        }

        public WithdrawCountException(string message) : base(message)
        {
        }

        public WithdrawCountException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class MinBalanceReachedException : Exception
    {
        public MinBalanceReachedException()
        {
        }

        public MinBalanceReachedException(string message) : base(message)
        {
        }

        public MinBalanceReachedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }

    public class ReportGeneratingException : Exception
    {
        public ReportGeneratingException()
        {
        }

        public ReportGeneratingException(string message) : base(message)
        {
        }

        public ReportGeneratingException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
