namespace TenTimes.App.Homeworks;

public static class LowestOfThree
{
    static float firstNumber;
    static float secondNumber;
    static float thirdNumber;

    public static void Run()
    {
        Console.WriteLine("Enter the first number: ");
        while (!float.TryParse(Console.ReadLine(), out firstNumber))
        {
            PrintNumberLine("first");
        }

        Console.WriteLine("Enter the second number: ");
        while (!float.TryParse(Console.ReadLine(), out secondNumber))
        {
            PrintNumberLine("second");
        }

        Console.WriteLine("Enter the third number: ");
        while (!float.TryParse(Console.ReadLine(), out thirdNumber))
        {
            PrintNumberLine("third");
        }

        float smallest;
        if (firstNumber < secondNumber && firstNumber < thirdNumber)
        {
            smallest = firstNumber;
        }
        else if (secondNumber < firstNumber && secondNumber < thirdNumber)
        {
            smallest = secondNumber;
        }
        else if (thirdNumber < firstNumber && thirdNumber < secondNumber)
        {
            smallest = secondNumber;
        }
        else
        {
            Console.WriteLine($"All three numbers are equally as small.");
            return;
        }

        Console.WriteLine($"The biggest number is: {smallest}");
    }

    public static void PrintNumberLine(string gradeNumber)
    {
        Console.WriteLine($"Enter the {gradeNumber} number: ");
    }
}
