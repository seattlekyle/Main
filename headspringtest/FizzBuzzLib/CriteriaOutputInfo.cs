namespace FizzBuzzLib
{
    public class CriteriaOutputInfo
    {
        public int FirstNum { get; set; }

        public int SecondNum { get; set; }
        
        public string DivisibleByFirstNumOutputText { get; set; }

        public string DivisibleBySecondNumOutputText { get; set; }

        public CriteriaOutputInfo() { }

        public CriteriaOutputInfo(
            int firstNum,
            int secondNum,
            string firstNumOutputText,
            string secondNumOutputText)
        {
            this.FirstNum = firstNum;
            this.SecondNum = secondNum;
            this.DivisibleByFirstNumOutputText = firstNumOutputText;
            this.DivisibleBySecondNumOutputText = secondNumOutputText;
        }

        public string GetResultText(int value)
        {
            if (value % FirstNum == 0 && value % SecondNum == 0)
            {
                return DivisibleByFirstNumOutputText + DivisibleBySecondNumOutputText;
            }
            else if (value % FirstNum == 0)
            {
                return DivisibleByFirstNumOutputText;
            }
            else if (value % SecondNum == 0)
            {
                return DivisibleBySecondNumOutputText;
            }
            else
            {
                return value.ToString();
            }
        }
    }
}