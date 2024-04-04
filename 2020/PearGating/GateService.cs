using System.Xml.Linq;

namespace PearGating;

public class GateService
{
    private int _age;
    private string _name;
    private string[] _fruits = new string[5];
    private const string _pear = "pear";

    public GateService()
    {
        SetName();
        SetAge();
    }
    private void SetName()
    {
        Console.WriteLine("Input your Name:");
        _name = Console.ReadLine() ?? string.Empty;
    }

    private void SetAge()
    {
        Console.WriteLine("Input your Age:");
        var age = Console.ReadLine();

        if (!int.TryParse(age, out _age))
        {
            Console.WriteLine("That was no real age you goofy, that's it, I'm shutting this down.");
            Environment.Exit(1);
            return;
        }
    }


    public void VerifyAge()
    {
        if(_age < 18)
        {
            Console.WriteLine("You can't go inside.");
            Environment.Exit(1);
            return;
        }

        Console.WriteLine("Welcome.");
    }

    public void SetFruits()
    {
        Console.WriteLine("Input 5 fruits: (Oh man, I sure would love a greenish fruit that's not an apple)");
        for (int i = 0; i < _fruits.Length; i++)
        {
            _fruits[i] = Console.ReadLine()!;
        }
    }

    public void VerifyPear()
    {
        if (_fruits.FirstOrDefault(f => f.Equals(_pear, StringComparison.OrdinalIgnoreCase)) is not null)
        {
            Console.WriteLine("Oh my, I do love myself a ripe pear, thanks!");
            return;
        }

        Console.WriteLine("How about you bring me a pear next time... please?");
    }

}
