using FizzBuzzKata.Interfaces;

namespace FizzBuzzKata.Filters
{
    internal class DivisibleByThreeFilter : IFilter
    {
        private const string value = "Fizz";

        public string GetValue()
        {
            return value;
        }

        public bool isValid(int number)
        {
            return number % 3 == 0;
        }
    }
}