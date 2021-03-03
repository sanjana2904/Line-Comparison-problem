using System;

namespace Line_Comparison_problem
{
    class Program
    {
        static void Main(string[] args)
        {
			int x1 = 1, y1 = 0, x2 = 5, y2 = 0, z1, z2, a;
			int x3 = 0, y3 = 2, x4 = 0, y4 = 6, z3, z4, b;
			z1 = x2 - x1;
			z2 = y2 - y1;
			z3 = x4 - x3;
			z4 = y4 - y3;
			a = ((z1 * z1) + (z2 * z2));
			b = ((z3 * z3) + (z4 * z4));
			Console.WriteLine("The length of the first line:" + Math.Sqrt(a));
			Console.WriteLine("The length of the second line:" + Math.Sqrt(b));
			if (a == b)
			{
				Console.WriteLine("lines are equal");
			}
			else
			{
				Console.WriteLine("lines are not equal");
			}
		}
    }
}
