﻿using System;
namespace StaticKeywordExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            var result = (fahrenheit - 32) / 1.8;

            return result;
        }

        public static double CelciusToFahrenheit(double celsius)
        {
            return (celsius * 9) / 5 + 32;
        }
    }
}
