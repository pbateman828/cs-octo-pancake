using System;

public class Program
{
	public static void DoFizzBuzz(int userInput)
	{
		for (int i = 1; i <= userInput; i++)
		{
			bool fizz = i % 3 == 0;
			bool buzz = i % 5 == 0;
			bool jazz = i % 7 == 0;
			if (fizz && buzz)
				Console.WriteLine("FizzBuzz");
			else if (fizz && jazz)
				Console.WriteLine("JazzFizz");
			else if (fizz)
				Console.WriteLine("Fizz");
			else if (buzz)
				Console.WriteLine("Buzz");
			else if (jazz)
				Console.WriteLine("Jazz");
			else
				Console.WriteLine(i);
		}
	}

	public static void captureInput()
	{
		Console.Clear();
		string userString;
		Console.WriteLine("\n This is FizzBuzz. Please enter a number.");
		userString = Console.ReadLine();
		int userNumber;
		bool success = Int32.TryParse(userString, out userNumber);
		if (success)
		{
			Program.DoFizzBuzz(userNumber);
		}
		else
		{
			Console.WriteLine("Attempted conversion of '{0}' failed.", userString ?? "<null>");
			Console.WriteLine("\nA number is needed.");
		}
	}

	public static void Main()
	{
		Program.captureInput();
	}
}