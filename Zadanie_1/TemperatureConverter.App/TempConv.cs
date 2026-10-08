using TemperatureConverter.Lib;
internal class Program
{
    private static void Main()
    {
        var lst = new List<int> {-20, 0, 20, 100};

        foreach (var temp in lst)
        {
            var TempF = TemperatureUtils.CelsiusToFahrenheit(temp);
            Console.WriteLine($"{temp} stopni C to {TempF} stopnie F");
        }
    }
}
