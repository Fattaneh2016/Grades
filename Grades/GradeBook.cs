﻿using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {

        public GradeBook()
        {
            grades = new List<float>();
        }

        public string Name { get; set; }
        public GradeStatistics ComputeStatistics()
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


        private List<float> grades;
    }
}
