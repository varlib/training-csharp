using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Threading
{
    class Program
    {
        static BlockingCollection<int> bc;

        static void producer()
        {
            for (int i = 0; i < 100; i++)
            {
                bc.Add(i * i);
                Console.WriteLine($"Producer {i * i}");
            }
            bc.CompleteAdding();
        }

        static void consumer()
        {
            int i;
            while (!bc.IsCompleted)
            {
                if (bc.TryTake(out i))
                    Console.WriteLine($"Consumer {i}");
            }
        }

        static void Main(string[] args)
        {
            bc = new BlockingCollection<int>(5);

            Task ProducerTask = new Task(producer);
            Task ConsumerTask = new Task(consumer);

            ProducerTask.Start();
            ConsumerTask.Start();

            try
            {
                Task.WaitAll(ConsumerTask, ProducerTask);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                ConsumerTask.Dispose();
                ProducerTask.Dispose();
                    bc.Dispose();
            }
            Console.ReadKey();
        }
    }
}
