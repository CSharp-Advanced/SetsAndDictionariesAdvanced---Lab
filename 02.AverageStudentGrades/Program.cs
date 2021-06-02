using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<decimal>> info = new Dictionary<string, List<decimal>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split();
                string name = tokens[0];
                decimal grade = decimal.Parse(tokens[1]);

                if (!info.ContainsKey(name))
                {
                    info.Add(name, new List<decimal>());
                }
                info[name].Add(grade);
            }

            foreach (var item in info)
            {
                Console.Write($"{item.Key} -> ");
                foreach (var grade in item.Value)
                {
                    Console.Write($"{grade:F2} ");
                }
                Console.WriteLine($"(avg: {item.Value.Average():F2})");
            }
        }
    }
}
