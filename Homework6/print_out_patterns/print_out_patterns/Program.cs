using System;

namespace print_out_patterns
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int column = 10;
			int row = 10;

			for (int i = 0; i < column; i++) 
			{
				Console.Write (" * ");
			}
			Console.WriteLine ();
			Console.WriteLine ();
			Console.WriteLine ();

			for (int i = 0; i < column/2; i++) 
			{
				Console.Write (" x ");
				Console.Write (" * ");
			}
			Console.WriteLine ();
			Console.WriteLine ();
			Console.WriteLine ();

			for (int i = 0; i < row; i++)
			{
				if (row % 2 == 0) 
				{
					for (int z = 0; z < column/2; z++) 
					{
						Console.Write (" x ");
						Console.Write (" * ");
					}
					Console.WriteLine();
				}
				else
				{
					for (int z = 0; z < column/2; z++) 
					{
						Console.Write (" * ");
						Console.Write (" x ");
					}
				}
			}


		}
	}
}
