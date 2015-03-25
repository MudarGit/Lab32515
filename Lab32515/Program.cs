using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab32515
{
    class Program
    {
        static void Main(string[] args)
        {
           //
            //
            // Income Tax Calculator
            //
            //
            
            //int income;
            //string value = args[0];
            //income = Convert.ToInt32(value);
            //int taxes;

            //if(income <=20000)
            //{
            //    taxes = income * 1 / 20;
            //    Console.WriteLine(taxes);
            //}
            //if(income >20000 && income <= 50000)
            //{
            //    taxes = income * 1 / 10;
            //    Console.WriteLine(taxes);
            //}
            //if(income >50000 && income <= 75000)
            //{
            //    taxes = income * 1 / 5;
            //    Console.WriteLine(taxes);
            //}
            //if (income > 75000)
            //{
            //    taxes = income * 35 / 100;
            //    Console.WriteLine(taxes);
            //}

            //
            //
            // Time and Classifications
            //
            //

            var time = (System.DateTime.Now);
            var timeseconds = (System.DateTime.Now.Second);

            Console.WriteLine(time);
            Console.WriteLine(timeseconds);

            if(timeseconds == 0)
            {
                Console.WriteLine("The new minute is just beginning");
            }
            if (timeseconds == 15)
            {
                Console.WriteLine("we're one quarter done");
            }
            if (timeseconds == 30)
            {
                Console.WriteLine("half way there");
            }
            if (timeseconds == 45)
            {
                Console.WriteLine("getting close to done");
            }
            else
            {
                Console.WriteLine("Working on it");
            }



        }
    }
}
