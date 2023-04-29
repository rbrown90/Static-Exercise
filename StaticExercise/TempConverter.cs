using System;
namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var result = (fahrenheit - 32) * (9/5);

            return result;
        }

        public static double CelsiusToFahrenheit(double celsius)
        {
            var result = (celsius * (5 / 9)) + 32;

            return result;
        }


    }
}

