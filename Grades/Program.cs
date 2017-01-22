using System;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.Speak("hello fattaneh how are you");

            GradeBook book = new GradeBook();
            book.AddGrade(45);
            book.AddGrade(87.9f);
            book.AddGrade(40);

            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.Lowestgrade);
            Console.WriteLine(stats.HighestGrade);
            Console.ReadLine();
        }
    }
}
