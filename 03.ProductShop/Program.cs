using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> info = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
                string shop = tokens[0];

                if (shop== "Revision")
                {
                    break;
                }
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!info.ContainsKey(shop))
                {
                    info.Add(shop,new Dictionary<string, double>());
                }
                info[shop].Add(product,price);
            }
            info = info
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var shop in info)
            {
                Console.WriteLine($"{shop.Key}->");
                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
