using System;

namespace Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слова для удаления из текста");
            string[] bad = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Введите текст");
            string text = Console.ReadLine();

            foreach (var item in bad)
            {
                text = text.Replace(item, new string('*', item.Length));
            }
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
