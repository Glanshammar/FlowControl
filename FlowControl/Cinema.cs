namespace FlowControl;

public class Cinema
{    
    public void EnterCinema(int age)
    {
        int cost = CalculateCost(age);
        Console.WriteLine($"Your cost is {cost}kr");
    }
    
    
    public void EnterCinemaGroup(Group group)
    {
        int totalCost = 0;
        List<Person> people = group.GetPeople();
        int peopleCount = people.Count;

        int personNumber = 1;
        foreach (var person in people)
        {
            int cost = CalculateCost(person.GetAge());
            Console.WriteLine($"The cost for person {personNumber}, aged {person.GetAge()} is {cost}kr");
            totalCost += cost;
            personNumber++;
        }

        Console.WriteLine($"Total cost for the group of {peopleCount} people: {totalCost}kr");
        people.Clear();
    }

    private int CalculateCost(int age)
    {
        switch (age)
        {
            case >= 100:
                return 0;
            case >= 65:
                return 90;
            case >= 6 and <= 19:
                return 80;
            case <= 5:
                return 0;
            default:
                return 120;
        }
    }
}