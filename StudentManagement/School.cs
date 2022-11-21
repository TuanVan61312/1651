using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class School
    {
        // attribute: List<Student> students
        private List<Student> students;

        // default constructor
        public School()
        {
            students = new List<Student>();
        }

        // Enroll(): enroll student
        public void Enroll()
        {
            System.Console.WriteLine("Enter student name: ");
            string name = Console.ReadLine();

            System.Console.WriteLine("Enter student age: ");
            int age = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Enter student grade: ");
            double grade = double.Parse(Console.ReadLine());

            Student s = new Student(name, age, grade);
            students.Add(s);
        }

        //Student FindByID
        public Student FindByID(int ID)
        {
            foreach(Student s in students)
            {
                if (s.ID == ID) return s;
            }
            return null;
        }

        // DropOupt(): drop out student
        public void DropOut()
        {
            System.Console.WriteLine("Enter student ID: ");
            int ID = int.Parse(Console.ReadLine());

            Student s = FindByID(ID);

            if (s == null) System.Console.WriteLine("Student not found");
            else
            {
                students.Remove(s);
                System.Console.WriteLine("Student Removed");
            }
        }

        // ShowStudents(): show all students
        public void ShowStudents()
        {
            System.Console.WriteLine("All student in school");
            foreach(Student s in students)
            {
                s.ShowInfo();
            }
        }      
    }
}