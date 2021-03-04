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


			int x3 = 0, y3 = 2, x4 = 0, y4 = 6;
			double len1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
			double len2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
			Console.WriteLine("The length of the first line:" + len1);
			int x3 = 0, y3 = 2, x4 = 0, y4 = 5;
		
			double len1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
			double len2 = Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));
			Console.WriteLine("The length of the first line:" + len1 );
			Console.WriteLine("The length of the second line:" + len2);
			if (len1 == len2)
			{
				Console.WriteLine("lines are equal");
			}
			else if (len1 > len2)
			{
				Console.WriteLine("greater");
			}
			else
			{
				Console.WriteLine("less");
			}


		}
	}

}
   
