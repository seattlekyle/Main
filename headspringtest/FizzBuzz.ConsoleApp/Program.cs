using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FizzBuzzLib;

namespace headspringtest
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            foreach (string result in fizzBuzz.GetResults(
                1,
                100, 
                new CriteriaOutputInfo[] { new CriteriaOutputInfo(3, 5, "Fizz", "Buzz") }))
            {
                Console.WriteLine(result);
            }

            Console.Read();
        }
    }
}
