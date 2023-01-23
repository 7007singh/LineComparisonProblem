using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Program");

            Console.WriteLine("Enter the value of x2");
            double val1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the value of x1");
            double val2 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the value of y2");
            double val3 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Enter the value of y1");
            double val4 = Convert.ToDouble(Console.ReadLine());

            CalculateLength length = new CalculateLength(val1, val2, val3, val4);
            length.Calculate();
            Console.Read();
        }
    }
}
