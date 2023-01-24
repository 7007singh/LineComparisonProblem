using System;

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

            Console.WriteLine("Enter the value of a2");
            double val5 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of a1");
            double val6 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of b2");
            double val7 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the value of b1");
            double val8 = Convert.ToDouble(Console.ReadLine());

            CalculateLength length = new CalculateLength(val1, val2, val3, val4, val5, val6, val7, val8);
            length.Calculate();
            Console.ReadLine();
        }
    }
}
