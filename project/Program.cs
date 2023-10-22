using System;

public class Program
{
	public static void Main()
	{
		Manager m = new Manager();
		m.showMenu();
		//Console.WriteLine("Hello World");
	}
}

class Manager
{
    public string[] Products;
	public void showMenu()
	{
		int num = 0;
		string userChoice = string.Empty;
		do
		{
			Console.WriteLine("Select the number of your choice: ");
			Console.WriteLine("1: Add a game");
			Console.WriteLine("2: Remove a game");
			Console.WriteLine("3: List games");
			Console.WriteLine("4: Save games");
			Console.WriteLine("5: Read games from file");
			Console.WriteLine("6: Quit");
			Console.Write("Enter the number of your choice: ");
			if(num == 6)
				break;
			else
				userChoice = Console.ReadLine();
		}
		while (Int32.TryParse(userChoice, out num)); //checks to see if the input is a number
            Console.WriteLine(userChoice);
		if (userChoice == "6")
		{
			Environment.Exit(0);
		}
		Console.WriteLine("Choice = " + userChoice);
		if (userChoice == "1")
		{
            Console.WriteLine("test");
		//Some code that will allow me to enter info on some game
		// it will then display the menu again after all questions are answered.
		}
	}

    public void listProduct()
    {

    }
}