using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoStrategy
{
    public interface ISorttable
    {
        public bool Compare(Student a, Student b);
        
        public void Sort(List<Student> students)
        {
            for(int i = 0; i < students.Count; i++)
            {
                for(int j = i + 1; j < students.Count; j++)
                {
                    if(Compare(students[i], students[j]))
                    {
                        Student temp = students[i];
                        students[i] = students[j];
                        students[j] = temp;
                    }
                }
            }
        }
    }
    public class SortByName : ISorttable
    {
        public bool Compare(Student a, Student b)
        {
            return a.Name.CompareTo(b.Name) > 0;
        }
    }
    public class SortByAge : ISorttable
    {
        public bool Compare(Student a, Student b)
        {
            return a.Age > b.Age;
        }
    }
    public class SortByGPA : ISorttable
    {
        public bool Compare(Student a, Student b)
        {
            return a.GPA > b.GPA;
        }
    }
}