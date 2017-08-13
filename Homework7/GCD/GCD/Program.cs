using System;
using System.Collections.Generic;
namespace GCD
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> numbers = new List<int> ();
			Random rnd = new Random();
			int n = 10;

			for (int i = 0; i < n; i++) {
				numbers.Add (rnd.Next (1, 100));
				Console.WriteLine (numbers [i]);

			}

			int k = numbers [0];
			for (int i = 1; i < n; i++) {
				if (k > numbers[i]){
					k = numbers[i];
			}

		}
			Console.WriteLine(k);
	}
}
}