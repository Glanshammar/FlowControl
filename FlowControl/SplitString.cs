namespace FlowControl;

public class Split
{
    public static void Input()
    {
        Console.WriteLine("\nSplits a sentence and shows the third word.");
        Console.Write("Write a sentence (at least 3 words): ");
        
        string input = Console.ReadLine();
        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (words.Length >= 3)
        {
            string thirdWord = words[2];
            Console.WriteLine($"The third word is: {thirdWord}");
        }
        else
        {
            Console.WriteLine("The sentence must contain at least 3 words.");
        }
    }
}