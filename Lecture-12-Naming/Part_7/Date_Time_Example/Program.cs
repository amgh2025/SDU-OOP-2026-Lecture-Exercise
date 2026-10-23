
public class Test
{
    static void Main(string[] args)
    {
        // 1. Get current date and time
        DateTime now = DateTime.Now;

        Console.WriteLine("Current date and time: " + now);

        // 2. Get only today's date
        DateTime today = DateTime.Today;

        Console.WriteLine("Today: " + today.ToShortDateString());

        // 3. Access individual components
        Console.WriteLine("Year: " + now.Year);
        Console.WriteLine("Month: " + now.Month);
        Console.WriteLine("Day: " + now.Day);
        Console.WriteLine("Hour: " + now.Hour);

        // 4. Create a specific date
        DateTime birthday = new DateTime(2000, 5, 15);

        Console.WriteLine("Birthday: " + birthday.ToShortDateString());

        // 5. Add days to a date
        DateTime nextWeek = now.AddDays(7);

        Console.WriteLine("Next week: "+ nextWeek.ToShortDateString());

        // 6. Compare two dates
        if (birthday < today)
        {
            Console.WriteLine("Birthday date is in the past.");
        }
    }
}
