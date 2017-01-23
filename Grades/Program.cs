using System;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.Speak("hello Farah how are you");

            GradeBook book = new GradeBook();
            book.AddGrade(45);
            book.AddGrade(87.9f);
            book.AddGrade(40);

            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Lowest", (int)stats.Lowestgrade);
            WriteResult("highest", stats.HighestGrade);
            Console.ReadLine();

        }
        static void WriteResult(string description, int result)
        {
            Console.WriteLine("{0}: {1}", description, result);

        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}", description, result);
        }

    }

}

