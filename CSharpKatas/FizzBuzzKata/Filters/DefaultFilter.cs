using FizzBuzzKata.Interfaces;

namespace FizzBuzzKata.Filters
{
    internal class DefaultFilter : IFilter
    {
        private string numberString;

        public string GetValue()
        {
            return numberString;
        }

        public bool isValid(int number)
        {
            numberString = number.ToString();
            return true;
        }
    }
}