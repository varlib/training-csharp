using System;
using System.Collections.Generic;
using System.Linq;

namespace CountNum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через запятую");
            List<int> num = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            num.Sort();

            int firstNum = num[0];
            int count = 1;

            for (int i = 1; i < num.Count; i++)
            {
                if (firstNum == num[i])
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{firstNum} -> {count}");
                    firstNum = num[i];
                    count = 1;
                }
            }
            Console.WriteLine($"{firstNum} -> {count}");
            Console.ReadKey();
        }
    }
}
