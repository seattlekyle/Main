using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzzLib
{
    public class FizzBuzzHelper
    {
        private int _start;
        private int _end;
        private IEnumerable<CriteriaOutputInfo> _criteriaOutputInfos;

        public FizzBuzzHelper(
            int start,
            int end,
            IEnumerable<CriteriaOutputInfo> criteriaOutputInfos)
        {
            if (criteriaOutputInfos == null)
            {
                throw new ArgumentException("Must not be null or empty.", "criteriaOutputInfos");
            }

            _start = start;
            _end = end;
            _criteriaOutputInfos = criteriaOutputInfos;
        }

        public IEnumerable<string> GetResults()
        {
            for (int i = _start; i < _end + 1; i++)
            {
                foreach (string result in GetResultOutputs(i))
                {
                    yield return result;
                }
            }
        }

        private IEnumerable<string> GetResultOutputs(int value)
        {
            string divisibleByOutputTexts = string.Concat(
                _criteriaOutputInfos.Where(x => value % x.Number == 0)
                                    .Select(x => x.DivisibleByOutputText));

            if (!string.IsNullOrWhiteSpace(divisibleByOutputTexts))
            {
                yield return divisibleByOutputTexts;
            }
            else
            {
                yield return value.ToString();
            }
        }
    }
}