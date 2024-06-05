namespace TenTimes.App.Homeworks;

public class AgeGate
{
    private static readonly DateTime _today = DateTime.Now;
    private static DateTime _birthdayDate;

    public static void Run()
    {
        Console.WriteLine("Enter your birthday: ");
        while (!DateTime.TryParse(Console.ReadLine(), out _birthdayDate))
        {
            PrintNumberLine("first");
        }

        int ageDifference = _today.Year - _birthdayDate.Year;
        int monthDifference = _today.Month - _birthdayDate.Month;
        if (ageDifference <= 0)
        {
            Console.WriteLine("TIME TRAVELER (OR SUPERHUMAN INFANT) DETECTED, SHUTTING DOWN COMPUTER IN in 3....2....1....");
        }
        else if (ageDifference < 18)
        {
            Console.WriteLine("Oi, you're underage! (In most countries)");
        }
        else if (ageDifference >= 18 || (ageDifference == 17  && monthDifference == 0))
        {
            Console.WriteLine("Come right in, human individual of enough age to vote.");
        }
    }

    public static void PrintNumberLine(string gradeNumber)
    {
        Console.WriteLine("Enter a valid date: ");
    }
}
