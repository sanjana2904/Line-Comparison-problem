using System;

namespace Line_Comparison_problem
{
    class Program
    {
        static void Main(string[] args)
        {
			int x1 = 1, y1 = 0, x2 = 5, y2 = 0;
			
            double len = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
			Console.WriteLine("length is:" + len);
		}
    }
}
