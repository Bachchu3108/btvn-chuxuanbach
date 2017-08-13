using System;
using System.Collections.Generic;
namespace ConvertNumber
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
				
			}
			for (int i = 0; i < n; i++) {
				int decimalNumber = numbers [i];
				int remainder;
				string result = string.Empty;
				while (decimalNumber > 0)
				{
					remainder = decimalNumber % 2;
					decimalNumber /= 2;
					result = remainder.ToString() + result;
				}
				Console.WriteLine("Decimal : {0} and Binary:  {1}",numbers[i],result);
			}
		}
	}
}
