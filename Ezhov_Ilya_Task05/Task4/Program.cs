using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class MyString
    {
        public char[] Value;

        public MyString(string value)
        {
            this.Value = value.ToCharArray();
        }
        public MyString(char[] value)
        {
            this.Value = value;
        }

        public static MyString operator +(MyString str1, MyString str2)
        {
            int length = str1.Value.Length + str2.Value.Length;
            char[] result = new char[length];
            for (int i = 0; i < str1.Value.Length; i++)
            {
                result[i] = str1.Value[i];
            }
            for (int i = 0; i < str2.Value.Length; i++)
            {
                result[i + str1.Value.Length] = str2.Value[i];
            }
            return new MyString(result);
        }
        public static MyString operator -(MyString str1, MyString str2)
        {
            return new MyString(str1.ToString().Replace(str2.ToString(), ""));
        }
        public static bool operator ==(MyString str1, MyString str2)
        {
            if (str1.Value.Length != str2.Value.Length)
            {
                return false;
            }
            for (int i = 0; i < str1.Value.Length; i++)
            {
                if (str1.Value[i] != str2.Value[i])
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator !=(MyString str1, MyString str2)
        {
            if (str1.Value.Length != str2.Value.Length)
            {
                return true;
            }
            for (int i = 0; i < str1.Value.Length; i++)
            {
                if (str1.Value[i] != str2.Value[i])
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            string result = new string(this.Value);
            return result;
        }
        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program creates MyString class with own operators. Here is an examples:\n");
            MyString myStrHello = new MyString("Hello world");
            MyString myStrO = new MyString("o");
            MyString myStrResult;
            bool equals;

            myStrResult = myStrHello + myStrO;
            Console.WriteLine($"MyString \'{myStrHello.ToString()}\' + MyString \'{myStrO.ToString()}\' = {myStrResult.ToString()}.\n");

            myStrResult = myStrHello - myStrO;
            Console.WriteLine($"MyString \'{myStrHello.ToString()}\' - MyString \'{myStrO.ToString()}\' = {myStrResult.ToString()}.\n");

            equals = myStrHello == myStrO;
            Console.WriteLine($"Is MyString \'{myStrHello.ToString()}\' and MyString \'{myStrO.ToString()}\' are equals?: {equals}.\n");

            MyString myStrHelloCopy = new MyString("Hello world");
            equals = myStrHello == myStrO;
            Console.WriteLine($"Is MyString \'{myStrHello.ToString()}\' and MyString \'{myStrHelloCopy.ToString()}\' are equals?: {equals}.\n");

            Console.WriteLine("\n\nEnd of program. Press any key.");
            Console.ReadKey();
        }
    }
}
