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
            int income;
            string value = args[0];
            income = Convert.ToInt32(value);
            int taxes;

            if(income <=20000)
            {
                taxes = income * 1 / 20;
                Console.WriteLine(taxes);
            }
            if(income >20000 && income <= 50000)
            {
                taxes = income * 1 / 10;
                Console.WriteLine(taxes);
            }
            if(income >50000 && income <= 75000)
            {
                taxes = income * 1 / 5;
                Console.WriteLine(taxes);
            }
            if (income > 75000)
            {
                taxes = income * 35 / 100;
                Console.WriteLine(taxes);
            }

        }
    }
}
