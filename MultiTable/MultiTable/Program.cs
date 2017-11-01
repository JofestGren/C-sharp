using System;

namespace MultiTable
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("y/x |  ");
			for (int k = 1; k <= 10; k++)
				Console.Write ("{0,4} ", k);
			Console.Write ("\n------------------------------------------------------------");
			Console.WriteLine ();
			for (int i = 1; i <= 10; i++) 
			{
				Console.Write ("{0,3} |  ", i);
				for (int j = 1; j <= 10; j++)
					Console.Write ("{0,4} ", i * j);
				Console.WriteLine ("");
				Console.WriteLine ("");
			}
			
		}
	}
}
