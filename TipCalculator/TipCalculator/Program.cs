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
            decimal billAmount;
            int tipPercentage;

            Console.WriteLine("Welcome to the tip calculator! \n");

            Console.WriteLine("Enter the bill amount (e,g., 200,95):\n");
            billAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the tip percentage (e.g., 10 for 10%)");
            tipPercentage = int.Parse(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
