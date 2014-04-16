namespace FizzBuzzLib
{
    public class CriteriaOutputInfo
    {
        public int Number { get; set; }

        public string DivisibleByOutputText { get; set; }

        public CriteriaOutputInfo() { }

        public CriteriaOutputInfo(
            int number,
            string divisibleByOutputText)
        {
            this.Number = number;
            this.DivisibleByOutputText = divisibleByOutputText;
        }
    }
}