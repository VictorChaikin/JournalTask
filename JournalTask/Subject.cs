using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalTask
{
    public class Subject
    {
        public string name { get; }
        public SubjectProgram program { get; }
        public StudentList List { get; }
        public Subject() { }
        public Subject(string name, SubjectProgram program, StudentList list)
        {
            this.name = name;
            this.program = program;
            this.List = list;
        }
        public void Show()
        {
            Console.WriteLine("Subject Name = " + this.name);
            this.program.Show();
            Console.WriteLine();
            this.List.Show();
        }
    }
}
