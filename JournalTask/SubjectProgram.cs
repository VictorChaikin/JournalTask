using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalTask
{
    public class SubjectProgram
    {
        string teacher;
        public Lesson[] lessons { get; }
        public SubjectProgram() { }
        public SubjectProgram(string teacher, Lesson[] lessons)
        {
            this.teacher = teacher;
            this.lessons = lessons;
        }
        public void Show()
        {
            Console.WriteLine("Teacher = " + this.teacher);
            for(int i = 0; i < lessons.Length; i++)
            {
                if (lessons[i] != null)
                {
                    lessons[i].Show();
                    Console.WriteLine();

                }
            }
        }
    }
}
