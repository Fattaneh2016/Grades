namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(45);
            book.AddGrade(87.9f);
            book.AddGrade(6.8f);
            book.AddGrade(9.8f);
        }
    }
}
