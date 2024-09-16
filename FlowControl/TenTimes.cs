namespace FlowControl;

public class TenTimes
{
    public static void Print()
    {
        string tenInput;

        while (true)
        {
            Console.Write("What do you want to print? ");
            tenInput = Console.ReadLine()?.Trim() ?? string.Empty;

            if (!string.IsNullOrWhiteSpace(tenInput))
            {
                break;
            }

            Console.WriteLine("Input cannot be empty. Please try again.");
        }
        
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"{i}. {tenInput}");
            if (i < 10)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}