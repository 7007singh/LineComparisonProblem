using System;
using System.Security.Cryptography;

namespace LineComparisonProblem
{
    internal class CalculateLength
    {
        public double x1, x2, y1, y2, a1, a2, b1, b2,  distance1, distance2;
        public CalculateLength(double a, double b, double c, double d, double e, double f, double g, double h)
        {
            x1 = a;
            x2 = b;
            y1 = c;
            y2 = d;
            a1 = e;
            a2 = f;
            b1 = g;
            b2 = h;
        }
        public void Calculate()
        {
            distance1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("distance of line: " + distance1);

            distance2 = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            Console.WriteLine("distance of line: " + distance2);

            
            if (distance2.Equals(distance1))
                Console.WriteLine("{0} is equal to {1}", distance1, distance2);
            else
                Console.WriteLine("{0} is not equal to {1}", distance1, distance2);
        }
    }
}
