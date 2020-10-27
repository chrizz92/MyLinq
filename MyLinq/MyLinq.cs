using System;
using System.Collections.Generic;
using System.Text;

namespace MyLinq
{
    internal static class MyLinq
    {
        internal static List<int> MyWhere(List<int> numbers, Func<int, bool> isEven)
        {
            List<int> newList = new List<int>();
            foreach (int number in numbers)
            {
                if (isEven(number))
                {
                    newList.Add(number);
                }
            }
            return newList;
        }

        internal static List<T> MyWhere<T>(List<T> objects, Func<T, bool> isTrue)
        {
            List<T> newList = new List<T>();
            foreach (T obj in objects)
            {
                if (isTrue(obj))
                {
                    newList.Add(obj);
                }
            }
            return newList;
        }

        internal static IEnumerable<T> MyWhere<T>(IEnumerable<T> objects, Func<T, bool> isTrue)
        {
            List<T> newList = new List<T>();
            foreach (T obj in objects)
            {
                if (isTrue(obj))
                {
                    newList.Add(obj);
                }
            }
            return newList;
        }
    }
}