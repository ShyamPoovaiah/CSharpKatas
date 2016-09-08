using FizzBuzzKata.Interfaces;

namespace FizzBuzzKata.Filters
{
    internal class DivisibleByThreeAndFiveFilter : IFilter
    {
        private const string value = "FizzBuzz";

        public string GetValue()
        {
            return value;
        }

        public bool isValid(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }
    }
}