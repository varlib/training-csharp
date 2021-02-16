using System;
using System.Linq;
using System.Collections.Generic;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(new char[] { ' ', ',', '.', '!', '&' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindrom = new List<string>();
            List<string> other = new List<string>();

            foreach (var item in text)
            {
                if (item.SequenceEqual(item.Reverse()))
                {
                    palindrom.Add(item);
                }
                else
                {
                    other.Add(item);
                }
            }
            Console.WriteLine(string.Join(", ", palindrom.OrderBy(x => x)));
            Reverse(other);
            Console.ReadLine();
        }

        static void Reverse(List<string> temp)
        { 
            foreach (var item in temp)
            {
                Console.WriteLine(item.Reverse().ToArray());
            }
        }
    }
}
