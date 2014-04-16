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
            FizzBuzzHelper buzz = new FizzBuzzHelper(
                1, 
                100, 
                new CriteriaOutputInfo[] 
                { 
                    new CriteriaOutputInfo(3, "Fizz") ,
                    new CriteriaOutputInfo(5, "Buzz")
                });

            int count = buzz.GetResults().Count();
            Assert.IsTrue(count == 100);
        }

        [TestMethod]
        public void VerifyThreeAndFiveAreFizzAndBuzz()
        {
            FizzBuzzHelper buzz = new FizzBuzzHelper(
                3, 
                5,
                new CriteriaOutputInfo[] 
                { 
                    new CriteriaOutputInfo(3, "Fizz"),
                    new CriteriaOutputInfo(5, "Buzz")
                });

            var results = buzz.GetResults();
            Assert.IsTrue(results.ElementAt(0) == "Fizz" && results.ElementAt(2) == "Buzz");
        }

        [TestMethod]
        public void VerifyFizzBuzz()
        {
            FizzBuzzHelper buzz = new FizzBuzzHelper(
                15,
                15,
                new CriteriaOutputInfo[]
                { 
                    new CriteriaOutputInfo(3, "Fizz"),
                    new CriteriaOutputInfo(5, "Buzz")
                });

            var results = buzz.GetResults();
            Assert.IsTrue(results.First() == "FizzBuzz");
        }

        [TestMethod]
        public void VerifyCharlieBravo()
        {
            FizzBuzzHelper buzz = new FizzBuzzHelper(
                15, 
                15,
                new CriteriaOutputInfo[] 
            { 
                new CriteriaOutputInfo(3, "Fizz"),
                new CriteriaOutputInfo(5, "Buzz"),
                new CriteriaOutputInfo(3, "Charlie"),
                new CriteriaOutputInfo(5, "Bravo")
            });

            var results = buzz.GetResults();

            Assert.IsTrue(results.ElementAt(0) == "FizzBuzzCharlieBravo");
            ////Assert.IsTrue(results.ElementAt(1) == "CharlieBravo");
        }
    }
}