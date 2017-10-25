using System;

namespace MaxNum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n, max = 0;
			Console.Write ("Number: ");
			n = Convert.ToInt32 (Console.ReadLine());

			for(int i = 0; n > 0; i++)
			{
				if (max < n % 10)
					max = n % 10;
				n /= 10;
			}
			Console.WriteLine ("Max: " + max);
		}
	}
}
