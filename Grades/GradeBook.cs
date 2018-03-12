using System;
using System.Collections.Generic;
using System.Text;

namespace Grades
{
    class GradeBook
    {
        // Each member inside a class is either a State or Behavior
        // State: Information or Variable
        // Behavior: Function

        public GradeBook()
        {
            grades = new List<float>();
        }

        public GradeStatistics ComputeStatistics() // Get the GPA for this GradeBook
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach(float grade in grades)
            {
                // Check if this is the highest grade
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);

                // Check if this is the lowest grade
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);

                // Sum up the grades
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }

        public void AddGrade(float grade) // Function which takes parameters
        {
            grades.Add(grade); // This will add the grade passed into the grades list
        }

        List<float> grades = new List<float>(); // List of floating point numbers
    }
}
