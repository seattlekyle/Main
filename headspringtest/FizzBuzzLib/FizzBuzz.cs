using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class FizzBuzz
    {
        public IEnumerable<string> GetResults(
            int start,
            int end,
            IEnumerable<CriteriaOutputInfo> criteriaOutputInfos)
        {
            for (int i = start; i < end + 1; i++)
            {
                foreach (CriteriaOutputInfo criteria in criteriaOutputInfos)
                {
                    yield return criteria.GetResultText(i);
                }
            }
        }
    }
}