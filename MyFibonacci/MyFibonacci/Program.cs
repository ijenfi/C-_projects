/*
Author: Ikhlas Jenfi
Description: Fibonacci sequence
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive version of Fibonacci sequence
            int result = FiboRec(10);
            Console.WriteLine(result);
            //Iterative version
            result = Fibo(10);
            Console.WriteLine(result);
        }

        private static int Fibo(int n)
        {
            int result0 = 0, result1 = 1, result;
            for (int i = 2; i <= n; i++)
            {
                result = result0;
                 result0 = result1 ;
                 result1 = result1 + result;
               
            }
            return result1;
        }

        private static int FiboRec(int n)
        {
            if (n == 0)
            {
                return 0;

            }
            if (n == 1)
            {
                return 1;

            }
            else
            {
                return FiboRec(n - 1) + FiboRec(n - 2);
            }
        }
    }
}
