using FizzBuzzKata.Filters;
using FizzBuzzKata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata
{
    /* Problem statement:
     * http://codingdojo.org/cgi-bin/index.pl?KataFizzBuzz
     * Stage 1
     * For a range of numbers from 1 to 100
     * Print 'Fizz' if the number is divisible by 3
     * Print 'Buzz' if the number is divisible by 5
     * Print 'FizzBuzz' if the number is divisible by both 3 and 5.
     * -----------------------------------------------------------
     * Stage 2 - New Requirement
     * Print 'Fizz' if the number is divisible by 3 or has a 3 in it.
     * Print 'Buzz' if the number is divisible by 5 or has a 5 in it.
    */
    class Program
    {
        static IEnumerable<IFilter> filters;

        static void Main(string[] args)
        {
            /*
            filters = new List<IFilter>() { // Use dependency injection. //stage - 1
                (IFilter)new DivisibleByThreeAndFiveFilter() ,
                (IFilter)new DivisibleByFiveFilter(),
                (IFilter)new DivisibleByThreeFilter(),
                (IFilter)new DefaultFilter()
            };
            */

            filters = new List<IFilter>() { // Use dependency injection. //stage - 2
                (IFilter)new DivisibleByThreeOrHasThreeFilter(),
                (IFilter)new DivisibleByFiveOrHasFiveFilter(),                
                (IFilter)new DefaultFilter()
            };

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

        /* 
        private static string FizzBuzzOne(int number) // Violates Open-Close principle
        {
            if (number % 3 == 0 && number % 5 == 0) return "FizzBuzz"; //Use of 3 and 5 instead of 15 since they are part of domain language (Problem statement).
            else if (number % 3 == 0) return "Fizz";
            else if (number % 5 == 0) return "Buzz";
            else return number.ToString();
        }
        */

        private static string FizzBuzzOne(int number) //A new filter can be added by changing the configuration
        {
           return filters
                .Where(f => f.isValid(number))
                .First()
                .GetValue();                
        }
    }
}
