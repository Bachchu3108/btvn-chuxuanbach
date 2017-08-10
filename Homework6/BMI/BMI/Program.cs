using System;

namespace BMI
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string command_1, command_2;
			float height, weight, bmi;
			while (true) {
				Console.WriteLine ("What's your height in cm?");
				command_1 = Console.ReadLine ();
				height = Convert.ToInt64 (command_1);
				height = height / 100;

				Console.WriteLine ("What's your weight in kg?");
				command_2 = Console.ReadLine ();
				weight = Convert.ToInt64 (command_2);

				bmi = weight / (height * height);
				Console.WriteLine ("Your BMI is " + bmi);

				if (bmi < 16)
				{
					Console.WriteLine ("You're severely underweight");
				} 
				else if (bmi <= 18.5) 
				{
					Console.WriteLine ("You're underweight");
				}
				else if (bmi <= 25) 
				{
					Console.WriteLine ("You're normal");
				}
				else if (bmi <= 30) 
				{
					Console.WriteLine ("You're overweigh");
				}
				else 
				{
					Console.WriteLine ("You're obese");
				}

				Console.WriteLine ("***************************************");
			}
		}
		
	}
}
