namespace TenTimes.App.Homeworks;

public static class TwentyToText
{
    static bool infinite = true;

    public static void Run()
    {
        int number = 0;

        while (infinite)
        {
            Console.WriteLine("Enter a number between 1 and 20");            
            _ = int.TryParse(Console.ReadLine(), out number);

            if(number > 0 && number <= 20)
            {
                Console.WriteLine("Your number is: " + NumberToWords(number));
            }
            else
            {
                Console.WriteLine("This is not between 1 and 20, what the heck is this?");
                infinite = false;
            }
        }
    }

    public static string NumberToWords(int number)
    {
        var words = new Dictionary<int, string>
        {
            { 1, "one" }, { 2, "two" }, { 3, "three" }, { 4, "four" }, { 5, "five" },
            { 6, "six" }, { 7, "seven" }, { 8, "eight" }, { 9, "nine" }, { 10, "ten" },
            { 11, "eleven" }, { 12, "twelve" }, { 13, "thirteen" }, { 14, "fourteen" },
            { 15, "fifteen" }, { 16, "sixteen" }, { 17, "seventeen" }, { 18, "eighteen" },
            { 19, "nineteen" }, {20, "twenty"}
        };

        return words[number];
    }
}