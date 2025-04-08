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
            int tipPercentage;
            int numOfPeopleSplittingBill;

            Console.WriteLine("Welcome to the tip calculator! \n");

            Console.WriteLine("Enter the bill amount: ");
            decimal billAmount = decimal.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the tip percentage (e.g., 10 for 10%):");
            //tipPercentage = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("How many people are splitting the bill?");
            //numOfPeopleSplittingBill = Convert.ToInt32(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
