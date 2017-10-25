using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyNum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n, count = 1;
			bool isPrime = true;

			Console.Write ("N: ");
			n = Convert.ToInt32 (Console.ReadLine());

			Console.WriteLine("Prime Numbers : ");
			for (int i = 2; count <= n; i++)
			{
				for (int j = 2; j <= n; j++)
				{

					if (i != j && i % j == 0)
					{
						isPrime = false;
						break;
					}

				}
				if (isPrime) {
					Console.Write (i + " , ");
				} else
					n += 1;
				count++;
				isPrime = true;
			}
			Console.ReadKey();
		}
	}
}
