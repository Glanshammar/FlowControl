
public class Group
{
    private static List<Person> people = new List<Person>();

    public Group()
    {
        AddToList();
    }
    
    public List<Person> GetPeople()
    {
        return people;
    }

    private void AddToList()
    {
        Console.Write("How many people are in the group? ");
        int groupNumber = Convert.ToInt32(Console.ReadLine());
        
        for (int i = 1; i <= groupNumber; i++)
        {
            people.Add(new Person(true, i));
        }
    }
}

public class Person
{
    private int age { get; }
    private bool isGroup { get; }

    public Person(bool group = false, int person = 0)
    {
        isGroup = group;
        age = SetAge(person);
    }

    private int SetAge(int person)
    {
        while (true)
        {
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
    
    public int GetAge()
    {
        return age;
    }
}