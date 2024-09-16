namespace FlowControl;

public class TenTimes
{
    //Prints the user input 10 times using a for loop
    public static void Print()
    {
        string input = string.Empty;

        while (true)
        {
            Console.Write("What do you want to print? ");
            input = Console.ReadLine()?.Trim() ?? string.Empty;

            if (!string.IsNullOrWhiteSpace(input))
            {
                break;
            }

            Console.WriteLine("Input cannot be empty. Please try again.");
        }
        
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}. {input}");
            if (i < 10)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}