namespace FlowControl;

public class Split
{
    // Prompts the user for input, splits the sentence, and displays the third word.
    public static void Input()
    {
        Console.WriteLine("\nSplits a sentence and shows the third word.");

        string input = string.Empty;
        
        do
        {
            Console.Write("Write a sentence (at least 3 words): ");
            input = Console.ReadLine() ?? string.Empty;
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Input cannot be null or empty. Please try again.");
                continue;
            }
        
            string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length >= 3)
            {
                string thirdWord = words[2];
                Console.WriteLine($"The third word is: {thirdWord}");
            }
            else
            {
                Console.WriteLine("The sentence must contain at least 3 words.");
            }
        } while (string.IsNullOrWhiteSpace(input));
    }
}