using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalTask
{
    public class Student
    {
        int number;
        public string name { get; }
        string surname;
        public Mark[] marks { get; }
        public Student() { }
        public Student(int number, string name, string surname, Mark[] marks)
        {
            this.number = number;
            this.name = name;
            this.surname = surname;
            this.marks = marks;
        }
        public void Show()
        {
            Console.WriteLine("Number ="+this.number);
            Console.WriteLine("Name =" + this.name);
            Console.WriteLine("Surname =" + this.surname);
            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] != null)
                {
                    marks[i].Show();
                    Console.WriteLine();
                }
            }
        }
    }
}
