using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalTask
{
    public class Journall
    {
        string group;
        int term;
        int year;
        public Subject[] subjects { get; set; }
        public Journall()
        {

        }
        public Journall(string group, int term, int year,Subject []subjects)
        {
            this.group = group;
            this.term = term;
            this.year = year;
            this.subjects = subjects;
        }
        public StudentList getStudentList()
        {
            if (subjects != null)
            {
                return subjects[0].List;
            }
            return null;
        }
        public void Show()
        {
            Console.WriteLine("Group = " + group);
            Console.WriteLine("Term = " + term);
            Console.WriteLine("Year = " + year);
            Console.WriteLine();
            for (int i = 0; i < subjects.Length; i++)
            {
                if (subjects[i] != null)
                {
                    subjects[i].Show();
                    Console.WriteLine();

                }
            }
        }
    }
}
