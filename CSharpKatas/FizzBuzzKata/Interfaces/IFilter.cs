namespace FizzBuzzKata.Interfaces
{
    internal interface IFilter
    {
        bool isValid(int number);

        string GetValue();
    }
}