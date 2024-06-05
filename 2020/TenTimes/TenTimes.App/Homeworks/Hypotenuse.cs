namespace TenTimes.App.Homeworks;

public static class Hypotenuse
{
    static double firstNumber;
    static double secondNumber;

    public static void Run()
    {
        Console.WriteLine("Enter the first cathetus: ");
        while (!double.TryParse(Console.ReadLine(), out firstNumber))
        {
            PrintNumberLine("first");
        }

        Console.WriteLine("Enter the second cathetus: ");
        while (!double.TryParse(Console.ReadLine(), out secondNumber))
        {
            PrintNumberLine("second");
        }

        double hypothenuse = Math.Sqrt(Math.Pow(firstNumber, 2) + Math.Pow(secondNumber, 2));
        Console.WriteLine($"The hypotenuse is: {hypothenuse}");
    }

    public static void PrintNumberLine(string number)
    {
        Console.WriteLine($"Enter the {number} cathetus: ");
    }
}