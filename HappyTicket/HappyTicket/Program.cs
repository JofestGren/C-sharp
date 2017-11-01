using System;

namespace HappyTicket
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Random rand = new Random ();
			int n = 6;
			string s = "";

			for (int i = 0; i < n; i++) 
			{
				s += Convert.ToString (rand.Next (9) + " ");
			}

			Console.WriteLine ("{0} ", s);
			int left = StrToInt(s.Remove (6));
			int right = StrToInt(s.Remove (0, 6));

			if (left== right)
				Console.WriteLine ("Happy ticket!");
			else
				Console.WriteLine ("Regular ticket!");
			Console.Write ("Left: {0}, Right: {1} ", left, right);
		}

		static int StrToInt (string str)
		{
			str = str.Trim ().Replace (" ", string.Empty);
			int num = Convert.ToInt32 (str, 10);
			return num;
		}
	}
}
