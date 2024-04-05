using CurrencyExchange;
using System.Net.Http.Json;

const string url = "https://v6.exchangerate-api.com/v6/YOUR-API-KEY/latest/USD";
using (var httpClient = new HttpClient())
{
    var currency = await httpClient.GetFromJsonAsync<CurrencyModel>(url);
    if(currency is null)
    {
        Console.WriteLine($"Something went wrong while requesting the currency data.");
        return;
    }

    double exchangeRate = currency.conversion_rates.DOP;

    Console.WriteLine("Howdy, how many dollars you got?");
    _ = double.TryParse(Console.ReadLine(), out double usdAmount);
    if (usdAmount == 0) return;

    Console.WriteLine($"Woah, that's the equivalent to {usdAmount * exchangeRate} $DOP.");
}
