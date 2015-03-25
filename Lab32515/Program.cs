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

            //var time = (System.DateTime.Now);
            //var timeseconds = (System.DateTime.Now.Second);

            //Console.WriteLine(time);
            //Console.WriteLine(timeseconds);

            //if(timeseconds == 0)
            //{
            //    Console.WriteLine("The new minute is just beginning");
            //}
            //if (timeseconds == 15)
            //{
            //    Console.WriteLine("we're one quarter done");
            //}
            //if (timeseconds == 30)
            //{
            //    Console.WriteLine("half way there");
            //}
            //if (timeseconds == 45)
            //{
            //    Console.WriteLine("getting close to done");
            //}
            //else
            //{
            //    Console.WriteLine("Working on it");
            //}


            //
            //
            // Loops
            //
            //

            //for(int counter = 1; counter <= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //    Console.WriteLine("this is a message for every number 1 to 100");
            //}

            //for (int counter1 = 1; counter1 <= 100; counter1++)
            //{
            //    Console.WriteLine(counter1);

            //    if (counter1 % 3 == 0)
            //    {

            //        Console.WriteLine("Fizz");
            //    }
            //    if (counter1 % 5 == 0)
            //    {
            //        Console.WriteLine("buzz");
            //    }
            //    if (counter1 % 3 == 0  && counter1 % 15 == 0)
            //    {
            //        Console.WriteLine("fizzbuzz");
            //    }
            // }

            //
            //
            // Reverse
            //
            //

            // string name = "nicholas";

            // char[] array = name.ToCharArray();
            //  Array.Reverse(array);
            //  Console.WriteLine(array);

            //
            //
            // extra credit 
            //
            //


            string name1 = "Nick";
            string name2 = "Mudar";



            char[] array2 = name2.ToCharArray();
            Array.Reverse(array2);
            //Console.WriteLine(array2);
            char[] array1 = name1.ToCharArray();
            Array.Reverse(array1);
            //Console.WriteLine(array1);

            string full = new string(array1);
            string First = new string(array2);

            string[] Final = {First, full};
            foreach (var item in Final)
            {
                Console.WriteLine(item);
            }
        }

       
        
    }
    
    
}
