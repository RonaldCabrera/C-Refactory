namespace TenTimes.App.Homeworks;

public class GeneralFormula
{
    static double firstNumber;
    static double secondNumber;
    static double thirdNumber;

    //(−b ± b2 − 4ac) / 2a
    public static void Run()
    {
        Console.WriteLine("Enter a: ");
        while (!double.TryParse(Console.ReadLine(), out firstNumber))
        {
            PrintNumberLine("a");
        }

        Console.WriteLine("Enter b: ");
        while (!double.TryParse(Console.ReadLine(), out secondNumber))
        {
            PrintNumberLine("b");
        }

        Console.WriteLine("Enter c: ");
        while (!double.TryParse(Console.ReadLine(), out thirdNumber))
        {
            PrintNumberLine("c");
        }

        double triangle = Math.Pow(secondNumber, 2) - (4 * firstNumber * thirdNumber);

        if(triangle <= 0)
        {
            Console.WriteLine("It won't work that way my guy.");
            return;
        }

        double positiveX = -secondNumber + Math.Sqrt(triangle);
        double negativeX = -secondNumber - Math.Sqrt(triangle);

        Console.WriteLine($"X1 is: {positiveX}, X2 is: {negativeX}");
    }

    public static void PrintNumberLine(string number)
    {
        Console.WriteLine($"Enter {number}: ");
    }

}