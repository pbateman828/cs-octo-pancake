using System;

public class Program
{
	public static bool Palindrome(string userIn)
	{
		for (int i = 0, j = userIn.Length - 1; i < j; i++, j--)
		{
			if (userIn[i] != userIn[j])
			{
				return false;
			}
		}

		return true;
	}

	public static bool Palindrome(int userIn)
	{
		string userStr = userIn.ToString();
		for (int i = 0, j = userStr.Length - 1; i < j; i++, j--)
		{
			if (userStr[i] != userStr[j])
			{
				return false;
			}
		}

		return true;
	}

	public static bool captureInput()
	{
		Console.Clear();
		string userInput;
		Console.WriteLine("\n This is a Palindrome Test. Please enter a word or number.");
		userInput = Console.ReadLine();
		int userNumber;
		bool successInt = Int32.TryParse(userInput, out userNumber);
		if (successInt)
		{
			return Program.Palindrome(userNumber);
		}
		else
		{
			return Program.Palindrome(userInput);
		}
	}

	public static void Main()
	{
		Console.WriteLine(Program.captureInput());
	}
}