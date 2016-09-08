using System;
using FizzBuzzKata.Interfaces;

namespace FizzBuzzKata
{
    internal class DivisibleByFiveOrHasFiveFilter : IFilter
    {
        private const string value = "Buzz";

        public string GetValue()
        {
            return value;
        }

        public bool isValid(int number)
        {
            return number % 5 == 0 || number.ToString().Contains("5");
        }
    }
}