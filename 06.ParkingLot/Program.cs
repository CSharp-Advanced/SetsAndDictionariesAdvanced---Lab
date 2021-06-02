using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> plates = new HashSet<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input=="END")
                {
                    break;
                }
                string[] tokens = input.Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string direction = tokens[0];
                string carNumber = tokens[1];

                if (direction=="IN")
                {
                    plates.Add(carNumber);
                }
                else
                {
                    if (plates.Contains(carNumber))
                    {
                        plates.Remove(carNumber);
                    }
                }
            }
            if (plates.Any())
            {
                Console.WriteLine(string.Join("\n", plates));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
