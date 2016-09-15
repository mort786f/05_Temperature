using System;

namespace _05_Temperature
{
    public class Temperature
    {
        public static double FahrenheitToCelcius(double v)
        {
            v = (v - 32) * 5.0 / 9.0;
            return v;
        }

        public static double CelciusToFahrenheit(double v)
        {
            v = (v * 9.0 / 5.0) + 32;
            return v;
        }
    }
}