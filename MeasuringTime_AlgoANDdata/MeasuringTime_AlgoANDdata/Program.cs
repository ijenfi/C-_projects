/*
Author: Ikhlas Jenfi
Description: measuring time
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MeasuringTime_AlgoANDdata
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            Stopwatch timer1 = new Stopwatch();
            //we start the lock
            timer1.Start();
            //measuring time
            //let's calculate 2^50

            for (int i = 0; i< 10; i++)
            {
                Console.WriteLine(Math.Pow(2, 50));
            }

           
            timer1.Stop();
            Console.WriteLine(timer1.ElapsedMilliseconds);
            //reset the clock
            timer1.Reset();

            //after this you can remeasure
            #endregion
            Console.WriteLine(1 / 1.5 + 1.5 / 2);
            Console.WriteLine(1 / 1.42 + 1.42 / 2);
            //calculte the square root in an interative way
            //initial value guessed x0

            double x = 1.0, a = 2.0;
            for (int i = 0; i < 10; i++)
            {
                x = a / (2 * x) + x / 2;
                Console.WriteLine("Iteration" + (i + 1) + "=" + x);
            }

        }
    }
}
