using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

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
            //=================
            var names = new List<string>{ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            
            //Normal
            names.ForEach(n => {
                Console.Write(" ,{0}", n);
                Thread.Sleep(200);
            });

            Console.WriteLine();
            //Parallel
            names.AsParallel().ForAll(n => {
                Console.Write(" ,{0}", n);
                Thread.Sleep(200);
            });
        }
    }
}
