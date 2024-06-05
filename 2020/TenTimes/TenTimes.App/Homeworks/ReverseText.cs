namespace TenTimes.App.Homeworks;

public static class ReverseText
{
    public static void Run()
    {
        Console.WriteLine("Enter a random text so I can reverse it");
        string randomString = Console.ReadLine()!;

        while (string.IsNullOrEmpty(randomString))
        {
            Console.WriteLine("Actually WRITE something.");
            randomString = Console.ReadLine()!;
        }

        string reversed = new(randomString.Reverse().ToArray());
        Console.WriteLine($"Your reversed random text is: {reversed}");
    }
}