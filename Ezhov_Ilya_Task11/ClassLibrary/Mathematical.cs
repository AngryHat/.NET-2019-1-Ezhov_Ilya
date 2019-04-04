using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Mathematical
    {
        public static int Factorial(int inputNumber)
        {
            int result = 1;
            if (inputNumber < 0)
            {
                throw new Exception("Error. You tried to get factorial of negative number.");
            }
            if (inputNumber == 0 || inputNumber == 1)
            {
                return result;
            }

            for (int i = 1; i < inputNumber; i++)
            {
                result *= i;
            }
            return result;
        }

        public static int RaiseToPower(int inputNumber, int power)
        {
            int result = 1;
            if (inputNumber == 1)
            {
                return result;
            }
            for (int i = 0; i < power; i++)
            {
                result *= inputNumber;
            }
            return result;
        }
    }
}
