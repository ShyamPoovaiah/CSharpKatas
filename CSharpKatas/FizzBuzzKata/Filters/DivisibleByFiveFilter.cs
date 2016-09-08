using FizzBuzzKata.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzKata.Filters
{
    class DivisibleByFiveFilter : IFilter
    {
        private const string value = "Buzz";

        public string GetValue()
        {
            return value;
        }

        public bool isValid(int number)
        {
            return number % 5 == 0;
        }
    }
}
