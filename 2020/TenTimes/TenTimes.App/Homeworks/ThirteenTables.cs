using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TenTimes.App.Homeworks;

public static class ThirteenTables
{
    static double firstNumber;

    public static void Run()
    {
        Console.WriteLine("Enter a random number, and I'll show you its multiplication table up to thirteen");
        while (!double.TryParse(Console.ReadLine(), out firstNumber))
        {
            PrintNumberLine();
        }

        PrintTimeTables(firstNumber);
    }

    public static void PrintNumberLine()
    {
        Console.WriteLine($"Enter an actual number you goofus: ");
    }

    public static void PrintTimeTables(double number)
    {
        for(int i = 1; i <= 13; i++)
        {
            Console.WriteLine($"{i} X {number} = {i*number}");
        }
    }
}
