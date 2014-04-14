using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzLib;

namespace FizzBuzzTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerifyGetFullResultCountFor1_100()
        {
            FizzBuzz buzz = new FizzBuzz();
            int count = buzz.GetResults(1, 100, new CriteriaOutputInfo[] { new CriteriaOutputInfo(3, 5, "Fizz", "Buzz") }).Count();
            Assert.IsTrue(count == 100);
        }

        [TestMethod]
        public void VerifyThreeAndFiveAreFizzAndBuzz()
        {
            FizzBuzz buzz = new FizzBuzz();
            var results = buzz.GetResults(3, 5, new CriteriaOutputInfo[] { new CriteriaOutputInfo(3, 5, "Fizz", "Buzz") });
            Assert.IsTrue(results.ElementAt(0) == "Fizz" && results.ElementAt(2) == "Buzz");
        }

        [TestMethod]
        public void VerifyFizzBuzz()
        {
            FizzBuzz buzz = new FizzBuzz();
            var results = buzz.GetResults(15, 15, new CriteriaOutputInfo[] { new CriteriaOutputInfo(3, 5, "Fizz", "Buzz") });
            Assert.IsTrue(results.First() == "FizzBuzz");
        }

        [TestMethod]
        public void VerifyCharlieBravo()
        {
            FizzBuzz buzz = new FizzBuzz();

            var results = buzz.GetResults(15, 15, new CriteriaOutputInfo[] 
            { 
                new CriteriaOutputInfo(3, 5, "Fizz", "Buzz"),
                new CriteriaOutputInfo(3, 5, "Charlie", "Bravo")
            });

            Assert.IsTrue(results.ElementAt(0) == "FizzBuzz");
            Assert.IsTrue(results.ElementAt(1) == "CharlieBravo");
        }
    }
}