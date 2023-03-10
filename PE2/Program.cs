using System;

namespace PE2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Each new term in the Fibonacci sequence is generated by adding
             * the previous two terms. By starting with 1 and 2, the first 10
             * terms will be: 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ... By
             * considering the terms in the Fibonacci sequence whose values do
             * not exceed four million, find the sum of the even-valued terms.
             */
            
            int i = 2;
            var fibonacciList = new List<int>{0, 1};
            List<int> evenList = new List<int>();

            while (true)
            {
                if (fibonacciList.Max() < 4000000)
                {
                    fibonacciList.Add( fibonacciList[i-1] + fibonacciList[i-2]);
                    i += 1;
                }
                else
                {
                    break;
                }
            }

            foreach (var VARIABLE in fibonacciList)
            {
                if (VARIABLE % 2 == 0)
                {
                    evenList.Add(VARIABLE);
                }
            }

            int sum = evenList.Sum();
            Console.WriteLine(sum);
        }
    }
}