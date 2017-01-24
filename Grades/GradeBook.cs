using System;
using System.Collections.Generic;
using System.IO;

namespace Grades
{
    public class GradeBook : object
    {

        public GradeBook()
        {
            _name = "empty";
            grades = new List<float>();
        }


        public virtual GradeStatistics ComputeStatistics()
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
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    if (_name != value && NameChanged != null)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = _name;
                        args.NewName = value;

                        NameChanged(this, args);
                    }
                    _name = value;
                }
            }
        }

        public event NameChangedDelegate NameChanged;

        private string _name;

        protected List<float> grades;

        public void WriteGrades(TextWriter destination)
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
