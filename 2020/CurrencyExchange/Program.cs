using CurrencyExchange;
using System.Text.Json;

const string url = "https://v6.exchangerate-api.com/v6/YOUR-API-KEY/latest/USD";
using (var webClient = new HttpClient())
{
    var json = await webClient.GetStreamAsync(url);
    var currency = JsonSerializer.Deserialize<CurrencyModel>(json);

    if(currency is not null)
    {
        double exchangeRate = currency.conversion_rates.DOP;

        Console.WriteLine("Howdy, how many dollars you got?");
        _ = double.TryParse(Console.ReadLine(), out double usdAmount);
        if (usdAmount == 0) return;

        Console.WriteLine($"Woah, that's the equivalent to {usdAmount * exchangeRate} $DOP.");
    }
}