
// Represents a group of people visiting the cinema.
public class Group
{
    private static List<Person> people = new List<Person>();

    public Group()
    {
        AddToList();
    }
    
    // Returns the list of people in the group.
    public List<Person> GetPeople()
    {
        return people;
    }

    // Prompts for the number of people in the group and adds them to the list.
    private void AddToList()
    {
        int groupNumber;
        
        while (true)
        {
            Console.Write("How many people are in the group? ");
            string input = Console.ReadLine()?.Trim() ?? string.Empty;

            if (int.TryParse(input, out groupNumber) && groupNumber > 0)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a positive number.");
        }
        
        for (int i = 1; i <= groupNumber; i++)
        {
            people.Add(new Person(true, i));
        }
    }
}

// Represents an individual person, either in a group or alone.
public class Person
{
    private int age { get; }
    private bool isGroup { get; }

    public Person(bool group = false, int person = 0)
    {
        isGroup = group;
        age = SetAge(person);
    }

    // Prompts for and sets the age of the person.
    private int SetAge(int person)
    {
        while (true)
        {
            // Adjust prompt based on whether it's a group or individual
            string prompt = isGroup ? $"What's the age of person {person}? " : "What's your age? ";
            Console.Write(prompt);
            string input = Console.ReadLine()?.Trim() ?? string.Empty;

            if (int.TryParse(input, out int parsedAge))
            {
                if (parsedAge > 0 && parsedAge <= 120)
                {
                    return parsedAge;
                }
                Console.WriteLine("Please enter a valid age between 1 and 120.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }
    
    // Returns the age of the person.
    public int GetAge()
    {
        return age;
    }
}