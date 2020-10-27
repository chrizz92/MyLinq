using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLinq
{
    internal class Program
    {
        public static bool isEven(int number)
        {
            return number % 2 == 0;
        }

        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> newNumbers = MyLinq.MyWhere(numbers, isEven) as List<int>;
            int[] myIntArray = new int[] { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int[] myNewIntArray = MyLinq.MyWhere(myIntArray, isEven).ToArray();

            foreach (var number in newNumbers)
            {
                Console.WriteLine(number);
            }

            foreach (int myInt in myNewIntArray)
            {
                Console.WriteLine(myInt);
            }
        }
    }
}