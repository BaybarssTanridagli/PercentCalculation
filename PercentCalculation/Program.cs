using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PercentCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number, percent, result;
            Console.WriteLine("Please Enter The Number: ");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter The Percent: ");
            percent = Convert.ToDouble(Console.ReadLine());
            result = number * percent / 100;
            Console.WriteLine("Number Entered % {0} : {1}",percent,result);
            Console.ReadKey();
        }
    }
}
