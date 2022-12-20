using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public class Class
    {
        private List<Student> students;
        private ISorttable sorter;
        public Class(ISorttable sorter)
        {
            students = new List<Student>();
            this.sorter = sorter;
        }
        public void ChangeSorter(ISorttable sorter)
        {
            this.sorter = sorter;
        }
        public void Show()
        {
            sorter.Sort(students);
            foreach(Student s in students)
            {
                Console.WriteLine(s);
            }
        }
        public void AddStudent(Student s)
        {
            students.Add(s);
        }
    }
}