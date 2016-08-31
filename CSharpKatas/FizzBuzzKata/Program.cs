using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(1, 100));
            Console.ReadKey();
        }

        private static string FizzBuzz(int start, int end) //unit testable/functional style
        {
            return Enumerable
                .Range(start, end)
                .Select(FizzBuzzOne)
                .Aggregate((result, current) => result + Environment.NewLine + current);
        }

        private static string FizzBuzzOne(int number)
        {
            if (number % (3 * 5) == 0) return "FizzBuzz";
            else if (number % 3 == 0) return "Fizz";
            else if (number % 5 == 0) return "Buzz";
            else return number.ToString();
        }
    }
}
