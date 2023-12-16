using System;
using System.Collections.Generic;

namespace Lab5Ex1
{
    class Program
    {
        /**
         * Un catalog contine:
         * - numele clasei
         * - lista elevilor
         * - O functie care va returna un string continand numele clasei si al fiecarui elev in parte
         * - O functie "GetPremiantul" care va determina elevul cu media cea mai mare.
         *
         * Elevii vor avea:
         * - nume, prenume
         * - o lista de note specifica fiecarui elev.
         * - O functie care va calcula media elevului
         * - O functie care va returna un string sub forma:
         * -- nume, prenume
         * -- nota 0 nota 1 nota 2 …. Nota m
         *
         * In functia "Main":
         * - Initializati 3 elevi
         * - Initializati un catalog adaugandu I elevii
         * - Acordati note elevilor
         * - Apelati metoda GetPremiantul a catalogului si afisati elevul cu media cea mai mare
         * - Apelati metoedele care returneaza descrierile obiectelor si afisati le rezultatele
         */
        public static void Main(string[] args)
        {
            List<int> student1Grades = new List<int>();
            student1Grades.Add(10);
            student1Grades.Add(3);
            student1Grades.Add(5);
            
            List<int> student2Grades = new List<int>();
            student2Grades.Add(10);
            student2Grades.Add(9);
            student2Grades.Add(6);
            
            List<int> student3Grades = new List<int>();
            student3Grades.Add(7);
            student3Grades.Add(8);
            student3Grades.Add(5);

            Student student1 = new Student("Rosca", "Ioana", student1Grades);
            Student student2 = new Student("Rosca", "Adriana", student2Grades);
            Student student3 = new Student("Rosca", "Adrian", student3Grades);

            List<Student> students = new List<Student>();
            students.Add(student1);
            students.Add(student2);
            students.Add(student3);

            ClassBook classBook = new ClassBook("10D", students);
            
            Console.WriteLine(classBook.GetPremiantul());
            
            Console.WriteLine(classBook.GetClassNameWithStudents());
            
            Console.WriteLine(student1.GetStudentWithGrades());
            Console.WriteLine(student2.GetStudentWithGrades());
            Console.WriteLine(student3.GetStudentWithGrades());
        }
    }
}