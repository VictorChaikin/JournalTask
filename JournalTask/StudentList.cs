using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalTask
{
    public class StudentList
    {
        int hours;
        public Student[] students { get; }
        public StudentList() { }
        public StudentList(int hours, Student[] students)
        {
            this.hours = hours;
            this.students = students;
        }
        public Student findStudent(string name)
        {
            for(int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    if(name == students[i].name)
                    {
                        return students[i];
                    }
                }
            }
            return null;
        }
        public void Show()
        {
            Console.WriteLine("Hours = " + this.hours);
            for(int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    students[i].Show();
                    Console.WriteLine();
                }
            }
        }
    }
}
