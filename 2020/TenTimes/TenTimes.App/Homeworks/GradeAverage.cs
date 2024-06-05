namespace TenTimes.App.Homeworks;

public static class GradeAverage
{
    static float firstGrade;
    static float secondGrade;
    static float thirdGrade;
    static float fourthGrade;
    
    public static void Run()
    {
        Console.WriteLine("Enter the first grade: ");
        while(!float.TryParse(Console.ReadLine(), out firstGrade))
        {
            PrintGradeLine("first");
        }

        Console.WriteLine("Enter the second grade: ");
        while (!float.TryParse(Console.ReadLine(), out secondGrade))
        {
            PrintGradeLine("second");
        }

        Console.WriteLine("Enter the third grade: ");
        while (!float.TryParse(Console.ReadLine(), out thirdGrade))
        {
            PrintGradeLine("third");
        }

        Console.WriteLine("Enter the fourth grade: ");
        while (!float.TryParse(Console.ReadLine(), out fourthGrade))
        {
            PrintGradeLine("fourth");
        }

        float average = (firstGrade + secondGrade + thirdGrade + fourthGrade) / 4;
        Console.WriteLine($"Your grade average is: {average}");
    }

    public static void PrintGradeLine(string gradeNumber)
    {
        Console.WriteLine($"Enter the {gradeNumber} grade: ");
    }
}