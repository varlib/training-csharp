using System;
using System.Linq;

namespace RotateSumm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int count = int.Parse(Console.ReadLine());
            int[] len = new int[intArray.Length];

            for (int i = 0; i < count; i++)
            {
                intArray = Rotate(intArray);
                for (int x = 0; x < len.Length; x++)
                {
                    len[x] += intArray[x];

                }
            }
            Console.WriteLine(string.Join(" ", len));
            Console.ReadKey();
        }

        static int[] Rotate(int[] number)
        {
            int[] rotate = new int[number.Length];
            int last = number[number.Length - 1];
            for (int i = 1; i < rotate.Length; i++)
            {
                rotate[i] = number[i - 1];
            }
            rotate[0] = last;
            return rotate;
        }
    }
}
