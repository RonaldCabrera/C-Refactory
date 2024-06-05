namespace TenTimes.App.Homeworks;
public static class FiftyToRoman
{
    static bool infinite = true;

    public static void Run()
    {
        while (infinite)
        {
            Console.WriteLine("Enter a number between 1 and 50");
            _ = int.TryParse(Console.ReadLine(), out int number);

            if (number > 0 && number <= 50)
            {
                Console.WriteLine("Your number in roman is: " + NumberToRoman(number));
            }
            else
            {
                Console.WriteLine("This number is not between 1 and 50.");
                infinite = false;
            }
        }
    }

    public static string NumberToRoman(int number)
    {
        var alfifty = new List<string>
        {
            "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX", "X",
            "XI", "XII", "XIII", "XIV", "XV", "XVI", "XVII", "XVIII", "XIX", "XX",
            "XXI", "XXII", "XXIII", "XXIV", "XXV", "XXVI", "XXVII", "XXVIII", "XXIX", "XXX",
            "XXXI", "XXXII", "XXXIII", "XXXIV", "XXXV", "XXXVI", "XXXVII", "XXXVIII", "XXXIX", "XL",
            "XLI", "XLII", "XLIII", "XLIV", "XLV", "XLVI", "XLVII", "XLVIII", "XLIX", "L"
        };

        return alfifty[number - 1];
    }
}
