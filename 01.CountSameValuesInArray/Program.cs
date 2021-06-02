using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> info = new Dictionary<double, int>();

            double[] input = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (double number in input)
            {
                if (!info.ContainsKey(number))
                {
                    info.Add(number,0);
                }
                info[number]++;
            }
            foreach (var number in info)
            {
                Console.WriteLine($"{number.Key} - {number.Value} times");
            }
            
        }
    }
}
