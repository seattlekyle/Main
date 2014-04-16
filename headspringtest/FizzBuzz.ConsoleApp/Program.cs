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
            FizzBuzzHelper fizzBuzz = new FizzBuzzHelper(
                1,
                100,
                new CriteriaOutputInfo[] 
                { 
                    new CriteriaOutputInfo(3, "Fizz"),
                    new CriteriaOutputInfo(5, "Buzz")
                });

            foreach (string result in fizzBuzz.GetResults())
            {
                Console.WriteLine(result);
            }

            Console.Read();
        }
    }
}
