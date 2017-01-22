using System.Collections.Generic;

namespace Grades
{
    class GradeBook
    {
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public void Removegrade(int id)
        {
            grades.Remove(id);
        }

        List<float> grades = new List<float>();
    }
}
