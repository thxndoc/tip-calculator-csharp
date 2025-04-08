using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            decimal billAmount = 0;

            Console.WriteLine("Welcome to the tip calculator! \n");

            Console.WriteLine("Enter the bill amount: ");
            billAmount = Convert.ToDecimal(Console.ReadLine());


            Console.ReadKey();
        }
    }
}
