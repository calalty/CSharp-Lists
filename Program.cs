using System;

using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // arrays: static.
            // lists: dynamic
            // use list if you dont know how many items your array is going to hold
            // userSignup - cant predict how many times a user signs up.

            List<int> salary = new List<int>();
            int[] otherCosts = new int[] { 9, 12, 10 };
            salary.Add(15);
            salary.Add(18000);
            salary.Add(22000);
            salary.AddRange(otherCosts);
            salary.RemoveAt(1);
            Console.WriteLine(salary.Count);
            Console.WriteLine(salary);
            Console.ReadKey();
        }
    }
}
