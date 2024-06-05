namespace TenTimes.App.Homeworks;

public class AgeGate
{
    private static readonly DateTime _today = DateTime.Today;
    private static DateTime _birthdayDate;

    public static void Run()
    {
        Console.WriteLine("Enter your birthday: ");
        while (!DateTime.TryParse(Console.ReadLine(), out _birthdayDate))
        {
            PrintNumberLine("first");
        }
        
        if (_birthdayDate > _today)
        {
            Console.WriteLine("TIME TRAVELER (OR SUPERHUMAN INFANT) DETECTED, SHUTTING DOWN COMPUTER IN in 3....2....1....");
            return;
        }

        int age = _today.AddTicks(-_birthdayDate.Ticks).Year - 1;
        if (age < 18)
        {
            Console.WriteLine("Oi, you're underage! (In most countries)");
        }
        else
        {
            Console.WriteLine("Come right in, human individual of enough age to vote.");
        }
    }

    public static void PrintNumberLine(string gradeNumber)
    {
        Console.WriteLine("Enter a valid date: ");
    }
}
