using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomToString
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 12345;
            double numberDouble = 12345.54321;

            var str = CustomIntToString2(number);

            Console.WriteLine($"Converted from int to string: {str}");

            str = CustomDoubleToString(numberDouble);

            Console.WriteLine($"Converted from float to string: {str}");

            Console.ReadLine();
        }

        private static string CustomIntToString(int number)
        {
            var stringResult = new StringBuilder();

            var arr = new List<int>();
            var arr2 = new List<char>();

            while (number % 10 > 0)
            {
                var lastElement = number % 10;
                var strNumber = (char)((int)'0' + lastElement);
                arr.Add(lastElement);
                arr2.Add(strNumber);
                number = number / 10;
            }

            arr2.Reverse();
            foreach (var item in arr2)
            {
                stringResult.Append(item);
            }

            return stringResult.ToString();
        }

        private static string CustomIntToString2(int number)
        {
            var stringResult = new StringBuilder();

            char[] defaultArr = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            var arr2 = new List<char>();

            while (number % 10 > 0)
            {
                var lastElement = number % 10;
                var strNumber = defaultArr[lastElement];
                arr2.Add(strNumber);
                number = number / 10;
            }

            arr2.Reverse();
            foreach (var item in arr2)
            {
                stringResult.Append(item);
            }

            return stringResult.ToString();
        }

        private static string CustomDoubleToString(double number)
        {
            var stringResult = new StringBuilder();

            int integerNumber = (int)number;
            var fractionalNumber = (number - integerNumber);

            

            return stringResult.ToString();
        }
    }
}
