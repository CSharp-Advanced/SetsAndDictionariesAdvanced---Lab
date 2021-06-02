using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> guests = new HashSet<string>();

            while (true)
            {
                string guest = Console.ReadLine();
                if (guest == "PARTY")
                {
                    break;
                }
                guests.Add(guest);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="END")
                {
                    Console.WriteLine(guests.Count);
                    PrintVip(guests);
                    PrintRegular(guests);
                    break;
                }
                if (guests.Contains(input))
                {
                    guests.Remove(input);
                }
            }
        }

        private static void PrintRegular(HashSet<string> guests)
        {
            foreach (var item in guests)
            {
                char[] ch = item.ToCharArray();

                if (char.IsLetter(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }

        private static void PrintVip(HashSet<string> guests)
        {
            foreach (var item in guests)
            {
                char[] ch = item.ToCharArray();

                if (char.IsDigit(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
