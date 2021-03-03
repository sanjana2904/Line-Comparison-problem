using System;

namespace Line_Comparison_problem
{
    class Program
    {
        static void Main(string[] args)
        {
			int x1 = 1, y1 = 0, x2 = 5, y2 = 0, z1, z2, a;
			z1 = x2 - x1;
			z2 = y2 - y1;
			a = ((z1 * z1) + (z2 * z2));
			Console.WriteLine("length is:" + Math.Sqrt(a));
		}
    }
}
