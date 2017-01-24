using System;

namespace time_calculator
{
	class MainClass
	{
		/*
		 * Write a program that asks the user to enter a total amount of time in minutes only.
         * Print to the console the same amount of time in hours and minutes.
         */

		public static void Main(string[] args)
		{
			Console.WriteLine("Enter an amount of time in minutes");
			int userTime = int.Parse(Console.ReadLine());

			int calcHours = userTime / 60;
			int remMin = userTime % 60;

			Console.WriteLine("\n {0} hours {1} minutes", calcHours, remMin);
		}
	}
}
