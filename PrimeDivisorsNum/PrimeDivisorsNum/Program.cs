using System;

namespace PrimeDivisorsNum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n;
			bool isPrime = true;
			string d = "";

			Console.Write ("N: ");
			n = Convert.ToInt32 (Console.ReadLine());

			Console.WriteLine("Simple dividers: ");
			for (int i = 2; i <= n; i++)
			{
				if (n % i == 0) 
				{
					for (int j = 2; j <= i/2; j++)
					{

						if (i % j == 0)
						{
							isPrime = false;
							break;
						}
					}
					if (isPrime) {
						d += Convert.ToString (i + " , ");
					} 
					else 
					{
						isPrime = true;
					}
				}
			}
			Console.WriteLine (d.Remove (d.Length - 2));
		}
	}
}
