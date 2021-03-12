using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciHelper fibonacci = new FibonacciHelper();

            //Fibonacci 1 - using recursion
            Stopwatch timer1 = new Stopwatch();
            timer1.Start();
            Console.WriteLine("Fibonacci 41 (method 1) = " + fibonacci.fibonacci1(40));
            timer1.Stop();
            Console.WriteLine("Time taken : " + timer1.Elapsed.ToString(@"m\:ss\.fff"));

            //Fibonacci 2 - using dictionary
            Stopwatch timer2 = new Stopwatch();
            fibonacci.memoization();
            timer2.Start();
            Console.WriteLine("Fibonacci 41 (method 2) = " + fibonacci.fibonacci2(40));
            timer2.Stop();
            Console.WriteLine("Time taken : " + timer2.Elapsed.ToString(@"m\:ss\.fff"));

            //Fibonacci 3 - using iteration
            Stopwatch timer3 = new Stopwatch();
            timer3.Start();
            Console.WriteLine("Fibonacci 41 (method 3) = " + fibonacci.fibonacci2(40));
            timer3.Stop();
            Console.WriteLine("Time taken : " + timer3.Elapsed.ToString(@"m\:ss\.fff"));
            Console.ReadKey();
        }
    }
}
