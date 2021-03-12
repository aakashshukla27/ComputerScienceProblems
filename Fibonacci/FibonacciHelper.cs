using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class FibonacciHelper
    {
        /// <summary>
        /// Simple calculation using recursion
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int fibonacci1(int n)
        {
            if (n < 2)
            {
                return n;
            }
            return fibonacci1(n - 1) + fibonacci1(n - 2);
        }


        public Dictionary<int, int> memo = new Dictionary<int, int>();

        /// <summary>
        /// Searching Ditionary if record exists to control the number of times we recursively call the function
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public int fibonacci2(int n)
        {
            if (!memo.ContainsKey(n))
            {
                memo.Add(n, fibonacci2(n - 1) + fibonacci2(n - 2));
            }
            return memo[n];
        }

        public void memoization()
        {
            memo.Add(0, 0);
            memo.Add(1, 1);
        }

        public int fibonacci3(int n)
        {
            int last = 0, next = 1;  //fibonacci3(0) and fibonacci(1)
            for (int i = 0; i < n; i++)
            {
                int oldLast = last;
                last = next;
                next = oldLast + next;
            }
            return last;
        }


    }
}
