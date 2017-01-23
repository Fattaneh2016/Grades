namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            Lowestgrade = float.MaxValue;
        }

        public string LetterGrade
        {
            get
            {
                string result;
                if (AverageGrade >= 90)
                {
                    result = "A";
                }
                else if (AverageGrade >= 80)
                {
                    result = "B";
                }
                else if (AverageGrade >= 70)
                {
                    result = "C";
                }
                else if (AverageGrade >= 60)
                {
                    result = "D";
                }
                else
                {
                    result = "F";
                }
                return result;
            }
        }

        public string Description
        {

            get
            {
                string result;
                switch (LetterGrade)
                {
                    case "A":
                        result = "Exellent";
                        break;
                    case "B":
                        result = "Good";
                        break;
                    case "C":
                        result = "Average";
                        break;
                    case "D":
                        result = "below Average";
                        break;
                    default:
                        result = "Failing";
                        break;
                }
                return result;
            }

        }
        public float AverageGrade;
        public float Lowestgrade;
        public float HighestGrade;

    }
}
