using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    /* Problem statement:
     * For a range of numbers from 1 to 100
     * Print 'Fizz' if the number is divisible by 3
     * Print 'Buzz' if the number is divisible by 5
     * Print 'FizzBuzz' if the number is divisible by both 3 and 5.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FizzBuzz(1, 100));
            Console.ReadKey();
        }

        private static string FizzBuzz(int start, int end) //unit testable, functional style of programming.
        {
            return Enumerable
                .Range(start, end)
                .Select(FizzBuzzOne)
                .Aggregate((result, current) => result + Environment.NewLine + current);
        }

        private static string FizzBuzzOne(int number)
        {
            if (number % 3 == 0 && number % 5 == 0) return "FizzBuzz"; //Use of 3 and 5 instead of 15 since they are part of domain language (Problem statement).
            else if (number % 3 == 0) return "Fizz";
            else if (number % 5 == 0) return "Buzz";
            else return number.ToString();
        }
    }
}
