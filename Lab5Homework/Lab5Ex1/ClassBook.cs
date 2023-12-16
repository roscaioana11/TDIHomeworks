using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5Ex1
{
    public class ClassBook
    {
        private string className;
        private List<Student> students;

        public ClassBook(string className, List<Student> students)
        {
            this.className = className;
            this.students = students;
        }

        public string GetClassNameWithStudents()
        {
            StringBuilder classNameWithStudents = new StringBuilder($"{className} has the following students: ");

            foreach (Student student in students)
            {
                classNameWithStudents.Append($"{student.GetFullName()}, ");
            }
            return classNameWithStudents.ToString();
        }

        public string GetPremiantul()
        {
            double highestGrade = 0;
            string studentName = "";

            foreach (Student student in students)
            {
                if (highestGrade < student.CalculateAverage())
                {
                    highestGrade = student.CalculateAverage();
                    studentName = student.GetFullName();
                }
            }
            
            return $"{studentName} has the highest grade: {Math.Round(highestGrade, 2)}";
        }
    }
}