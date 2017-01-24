using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public class GradeBook : GradeTracker
    {

        public GradeBook()
        {
            _name = "empty";
            grades = new List<float>();
        }


        public override GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.Lowestgrade = Math.Min(grade, stats.Lowestgrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;

            return stats;
        }
        public override void AddGrade(float grade)
        {
            grades.Add(grade);
        }



        protected List<float> grades;

        public override void WriteGrades(TextWriter destination)
        {
            //foreach (int i in grades)
            //{
            //    destination.WriteLine(i);
            //}

            for (int i = 0; i < grades.Count; i++)
            {
                destination.WriteLine(grades[i]);
            }

            //increment 
            //for (int i = grades.Count; i > 0; i--)
            //{
            //    destination.WriteLine(grades[i - 1]);
            //}
        }
    }
}
