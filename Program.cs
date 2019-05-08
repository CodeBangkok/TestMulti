using System;
using System.Threading;
using System.Threading.Tasks;

namespace TestMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            // Normal
            for (int i=0; i<50;i++)
            {
                Console.Write(" ,{0}", i);
                Thread.Sleep(200);
            }
            Console.WriteLine();

            // Parallel
            Parallel.For(0, 50, i => {
                Console.Write(" , {0}", i);
                Thread.Sleep(200);
            });
        }
    }
}
