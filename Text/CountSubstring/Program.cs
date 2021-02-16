using System;

namespace CountSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string shablon = Console.ReadLine().ToLower();

            int count = 0;
            int index = text.IndexOf(shablon);

            while (index != -1)
            {
                count++;
                index = text.IndexOf(shablon, index + 1);
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}
