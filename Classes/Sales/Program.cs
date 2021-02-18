using System;
using System.Collections.Generic;

namespace Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Count sale:");
            int countOfSale = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[countOfSale];

            for (int i = 0; i < countOfSale; i++)
            {
                Console.WriteLine("Write SALE (Town, Product, Price, Quantity)");
                sales[i] = ReadSale(Console.ReadLine());
            }

            SortedDictionary<string, decimal> dictionary = new SortedDictionary<string, decimal>();

            foreach (Sale sale in sales)
            {
                if (dictionary.ContainsKey(sale.Town))
                {
                    dictionary[sale.Town] += sale.Price * sale.Quantity;
                }
                else
                {
                    dictionary[sale.Town] = sale.Price * sale.Quantity;
                }
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine($"Key: {pair.Key} | Value: {pair.Value}");
            }
            Console.ReadKey();
        }

        static Sale ReadSale(string input)
        {
            string[] token = input.Split(' ');
            return new Sale { Town = token[0], Product = token[1], Price = decimal.Parse(token[2]), Quantity = decimal.Parse(token[3]) };
        }
    }
}
