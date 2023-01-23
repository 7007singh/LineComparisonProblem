using System;

namespace LineComparisonProblem
{
    internal class CalculateLength
    {
        public double x1, x2, y1, y2, distance;
        public CalculateLength(double a, double b, double c, double d)
        {
            x1 = a;
            x2 = b;
            y1 = c;
            y2 = d;
        }
        public void Calculate()
        {
            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("distance of line: " + distance);
        }
    }
}
