namespace Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = 35.5d;
            Console.WriteLine($"{celsius:F1}° C = {Temperature.CelsiusToFahrenheit(celsius):F1}° F");

            double fahrenheit = 75.3d;
            Console.WriteLine($"{fahrenheit:F1}° F = {Temperature.FahrenheitToCelsius(fahrenheit):F1}° C");
        }
    }
}
