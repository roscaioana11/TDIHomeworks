using System.Collections.Generic;
using System.Text;

namespace Lab5Ex1
{
    public class Student
    {
        private string lastName;
        private string firstName;
        private List<int> grades;

        public Student(string lastName, string firstName, List<int> grades)
        {
            this.lastName = lastName;
            this.firstName = firstName;
            this.grades = grades;
        }

        public string GetFullName()
        {
            return $"{lastName} {firstName}";
        }

        public double CalculateAverage()
        {
            double result = 0;

            foreach (int grade in grades)
            {
                result += grade;
            }
            
            return result / grades.Count;
        }

        public string GetStudentWithGrades()
        {
            StringBuilder studentWithGrades = new StringBuilder($"{GetFullName()}`s grades: ");

            foreach (int grade in grades)
            {
                studentWithGrades.Append($"{grade}, ");
            }
            
            return studentWithGrades.ToString();
        }
    }
}