/*
Author: Ikhlas Jenfi
Description: Counting n factorial
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Factorial(4); //Method call
            Console.WriteLine(result);
            //For big factorials, use Stirling Formula
            result = FactorialRec(15);
        }

        private static int FactorialRec(int v)
        {
            //Base case
            if (v == 1)
            {
                return 1;
            }
            //recursive case
            else
            {
                return v*FactorialRec(v - 1);
            }

        }

        private static int Factorial(int v)
        {
            int result = 1;
            for (int i = 1; i <= v; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
