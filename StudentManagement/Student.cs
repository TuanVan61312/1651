using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        // attributes: name, age, grade
        private string name;
        private int age;
        private double grade;
        private int id;
        public int ID
        {
            get {return id;}
        }
        public string Name
        {
            get { return name;}
            set
            {
                if (value == "") name = "No name";
                else name = value;
            }
        }
        public int Age
        {
            get {return age;}
            set
            {
                if (value < 0 || value > 100) age = 0;
                else age = value;
            }
        }
        public double Grade
        {
            get {return grade;}
            set
            {
                if (value < 0) grade = 0;
                else if (value > 10)grade = 10;
                else grade = value;
            }
        }

        // ID base count
        private static int count = 0;

        // default constructor
        public Student()
        {
            Name = "No name";
            Age = 0;
            Grade = 0;
            id = ++count; 
        }

        // parameter constructor
        public Student(string name, int age, double grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
            id = ++count;
        }

        // show info
        public void ShowInfo()
        {
            Console.WriteLine("ID: " + ID + ", Name: " + Name + ", Age: " + Age + ", Grade: " + Grade);
        }
    }
}