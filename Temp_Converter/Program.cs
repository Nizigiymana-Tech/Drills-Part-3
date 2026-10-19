using System;

class Program
{
    static void Main()
    {
        static double FahrenheitToCelsius(double Fahrenheit)
        {
            double formula = (Fahrenheit - 32) * 5 / 9;

            return formula;
        }

        double Result = Math.Round(FahrenheitToCelsius(44));
        Console.WriteLine(Result);
    }
}