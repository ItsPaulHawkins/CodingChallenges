using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;

namespace WageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("What is your hourly wage?");
            double wage = double.Parse(Console.ReadLine());
            wage = wage / 60;
            wage = wage / 60;
            double staticWage = wage;
            while (true)
            {
                sleep();
                Console.Clear();
                Console.WriteLine("You have made " + wage);
                wage = wage + staticWage;

            }
            


        }
        public static void sleep()
        {
            Thread.Sleep(1000);
        }

    }
}
