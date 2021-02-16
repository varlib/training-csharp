using System;
using System.Collections.Generic;
using System.Linq;

namespace Append
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слова через запятую");
            List<string> numberText = Console.ReadLine().Split(",").Reverse().ToList();

            foreach (var item in numberText)
            {
                string[] textArr = item.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine(string.Join(" ", textArr) + " ");
            }
            Console.ReadKey();
        }
    }
}
