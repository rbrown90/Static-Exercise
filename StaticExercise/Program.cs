namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(80);
            {
                Console.WriteLine($"It is {celsius}º C today!!");
            }

            var fahrenheit = TempConverter.CelsiusToFahrenheit(58);
            {
                Console.WriteLine($"It is {fahrenheit}º F today!!");
            }

        }
    }
}
