namespace FlowControl;

public class TenTimes
{
    public static void Print()
    {
        Console.Write("What do you want to print? ");
        string tenInput = Console.ReadLine()?.Trim() ?? string.Empty;
        
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