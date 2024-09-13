using System.Linq.Expressions;

namespace FlowControl;

class Program
{
    static public void Greeting()
    {
        Console.WriteLine("Hello, World!" +
                          "\nWhat do you want to do?" +
                          "\n0. Quit" +
                          "\n1. Enter the movies." +
                          "\n2. ??");
    }
    
    static void Main(string[] args)
    {
        bool running = true;
        Greeting();

        do
        {
            string input = Console.ReadLine()?.Trim().ToLower() ?? string.Empty;

            switch (input)
            {
                case "0":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        } while (running);
    }
}