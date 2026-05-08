using System.Collections.Generic;

namespace ULMSWinFormsAppClient
{
    public class Student
    {
        public string StudentNumber { get; set; }
        public string FullName { get; set; }

        public List<string> Courses = new List<string>();

        public List<double> Marks = new List<double>();

        public double CalculateAverage()
        {
            if (Marks.Count == 0)
                return 0;

            double total = 0;

            foreach (double mark in Marks)
            {
                total += mark;
            }

            return total / Marks.Count;
        }
    }
}