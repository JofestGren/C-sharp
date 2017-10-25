using System;

namespace SumNepar
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n, sum = 0, count = 1;

			Console.Write ("Number: ");
			n = Convert.ToInt32 (Console.ReadLine());

			for(int i = 1; count <= n; i+=2)
			{
				count++;
				sum += i;
			}

			/*for(int i = 1; count <= n; i++)
			{
				count++;
				sum += i * 2 -1;
			}*/

			Console.WriteLine ("Sum: " + sum);

		}
	}
}
