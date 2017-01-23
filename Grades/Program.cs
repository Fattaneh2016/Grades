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

            //book.NameChanged += new NameChangedDelegate(OnNameChanged);
            book.NameChanged += OnNameChanged;


            book.Name = "fattaneh";

            book.AddGrade(45);
            book.AddGrade(87.9f);
            book.AddGrade(40);
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Lowest", (int)stats.Lowestgrade);
            WriteResult("highest", stats.HighestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
            Console.ReadLine();

        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

        static void WriteResult(string description, int result)
        {
            Console.WriteLine("{0}: {1}", description, result);

        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}", description, result);
        }
        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}", description, result);
        }
    }

}

