using System;
using System.IO;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            SpeechSynthesizer synth = new SpeechSynthesizer();

            synth.Speak("hello Fattaneh how are you");

            GradeTracker book = CreateGradeBook();

            //book.NameChanged += new NameChangedDelegate(OnNameChanged);
            book.NameChanged += OnNameChanged;


            //book.Name = "fattaneh";

            GetBookName(book);
            AddGrades(book);

            //if a class has dispose method we can use using to .net take care of dispose the object so we don't need to close the file the dot net do it for us.

            SaveGrades(book);




            //book.WriteGrades(Console.Out);

            WriteResult(book);

        }

        private static ThrowAwayGradeBook CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

        private static void WriteResult(GradeTracker book)
        {
            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Lowest", (int)stats.Lowestgrade);
            WriteResult("highest", stats.HighestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
            Console.ReadLine();
        }

        private static void SaveGrades(GradeTracker book)
        {
            using (StreamWriter outputfile = File.CreateText("grades.text"))
            {
                book.WriteGrades(outputfile);
                // outputfile.Close();
            }
        }

        private static void AddGrades(GradeTracker book)
        {
            book.AddGrade(45);
            book.AddGrade(87.9f);
            book.AddGrade(40);
        }

        private static void GetBookName(GradeTracker book)
        {
            try
            {
                Console.WriteLine("Please enter a name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {

            }
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

