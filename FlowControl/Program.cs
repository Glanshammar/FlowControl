namespace FlowControl;

class Program
{
    static public void Greeting()
    {
        Console.WriteLine("Hello, World!" +
                          "\nWhat do you want to do?" +
                          "\n0. Quit" +
                          "\n1. Enter the movies. (Single person)" +
                          "\n2. Enter the movies. (Group)");
    }
    
    static void Main(string[] args)
    {
        //Startup
        bool running = true;
        Cinema cinema = new Cinema();
        Greeting();

        //Main loop
        do
        {
            Console.Write(">> ");
            string input = Console.ReadLine()?.Trim() ?? string.Empty;

            switch (input)
            {
                case "0": //Quit the program.
                    running = false;
                    break;
                case "1": //For a single person.
                    Person person = new Person();
                    cinema.EnterCinema(person.GetAge());
                    break;
                case "2": //For a group of people.
                    Group group = new Group();
                    cinema.EnterCinemaGroup(group);
                    break;
                default: //For invalid input.
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        } while (running);
    }
}