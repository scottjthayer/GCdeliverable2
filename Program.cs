using System;

namespace deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Hello. I am chat bot.");
			string currentInput = "";
			while (currentInput != "bye")
			{
				Console.WriteLine("Please select an option.\nhello, bye, sup, or hello there\n");
				string userInput = Console.ReadLine().ToLower();
				if (currentInput == userInput)
				{
					Console.WriteLine("I'm sorry but you have already said that\n");
					continue;
				}
				else
				{
					currentInput = userInput;
					switch (userInput)
					{
						case "hello":
							Console.WriteLine("Hi good to see you\n");
							break;
						case "bye":
							Console.WriteLine("Good Bye!");
							break;
						case "sup":
							Console.WriteLine("I am good\n");
							break;
						case "hello there":
							Console.WriteLine("General Kenobi\n");
							break;
						default:
							break;
					}
				}
			}

			Environment.Exit(0);
		}
	}

}
    

