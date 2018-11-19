using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalTask
{
    class Program
    {
        static  void Menu(Journall journal)
        {
            Console.WriteLine("Menu :");
            Console.WriteLine("1 - Add new student" );
            Console.WriteLine("2 - Add new subject");
            Console.WriteLine("3 - Show Student Marks");
            Console.WriteLine("4 - Add mark");
            Console.WriteLine("5 - Add new Lesson");
            Console.WriteLine("6 - Show all lessons");
            Console.WriteLine("0 - Exit");
            char input = Console.ReadKey().KeyChar;
            switch (input)
            {
                case '0': return;
                case '1':
                    Console.WriteLine("Enter name");
                    string studentName = Console.ReadLine();
                    Console.WriteLine("Enter surname");
                    string studentSurname = Console.ReadLine();
                    Console.WriteLine("Enter number in the List");
                    int numberInList = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("Amuont of Marks");
                    int amountOfMarks = Int32.Parse(Console.ReadLine());
                    Mark []marks = new Mark[15];
                    for (int i = 0; i < amountOfMarks; i++)
                    {
                        Console.Write("Mark = ");
                        int mark = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("This mark date");
                        Console.WriteLine("Enter day");
                        int day = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter month");
                        int month = Int32.Parse(Console.ReadLine());
                        Console.WriteLine("Enter year");
                        int year = Int32.Parse(Console.ReadLine());
                        Date date = new Date(day, month, year);
                        marks[i] = new Mark(mark, date);
                    }
                    bool addedStudent = false;
                    for (int j = 0; j < journal.subjects[0].List.students.Length && addedStudent==false; j++)
                    {
                        
                        if (journal.subjects[0].List.students[j] == null)
                        {
                            addedStudent = true;
                            journal.subjects[0].List.students[j] = new Student(numberInList,studentName,studentSurname,marks);
                            Console.WriteLine(" User successfuly added");
                        }
                    }

                    break;
                case '2':
                    Console.WriteLine("Enter subject name");
                    string subjectName = Console.ReadLine();
                    bool exist = false;
                    bool added = false;
                    for(int i = 0; i < journal.subjects.Length && exist!=true && added ==false; i++)
                    {
                        if (journal.subjects[i] != null)
                        {
                            if (journal.subjects[i].name == subjectName)
                            {
                                exist = true;
                                Console.WriteLine("Subject with such name already exist.");
                            }
                        }
                        else
                        {
                            added = true;
                            SubjectProgram prog = new SubjectProgram();
                            StudentList list = new StudentList();
                            journal.subjects[i] = new Subject(subjectName, prog,list);
                            Console.WriteLine(" Successfuly added");
                        }
                       
                    }
                    break;
                case '3':
                    Console.WriteLine("Enter Student Name");
                    string studName = Console.ReadLine();
                    StudentList ourStudentList = journal.getStudentList();
                    if (ourStudentList != null)
                    {
                        Student ourStudent = ourStudentList.findStudent(studName);
                        if (ourStudent != null)
                        {
                            ourStudent.Show();
                        }
                        else
                        {
                            Console.WriteLine("This student does not exist in your journal");
                        }
                    }
                    else
                    {
                        Console.WriteLine(" No students. Add some for your future operations");
                    }
                    break;
                case '4':
                    Console.WriteLine("Enter Student Name");
                    string name = Console.ReadLine();
                    StudentList List = journal.getStudentList();
                    if (List != null)
                    {
                        Student ourStudent = List.findStudent(name);
                        if (ourStudent != null)
                        {
                            Console.Write("Mark = ");
                            int mark = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("This mark date");
                            Console.WriteLine("Enter day");
                            int day = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter month");
                            int month = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter year");
                            int year = Int32.Parse(Console.ReadLine());
                            Date date = new Date(day, month, year);
                            int iterator = 0;
                            do
                            {
                                if (ourStudent.marks[iterator] == null)
                                {
                                    ourStudent.marks[iterator] = new Mark(mark, date);
                                    iterator = 10000;
                                    Console.WriteLine(" Mark successfuly added");
                                }
                                iterator++;

                            } while (iterator != 10001);
                        }
                        else
                        {
                            Console.WriteLine("This student does not exist in your journal");
                        }
                    }
                    else
                    {
                        Console.WriteLine(" No students. Add some for your future operations");
                    }
                    break;
                case '5':
                    if (journal.subjects[0].program.lessons == null)
                    {
                        Console.WriteLine(" No lessons. Add some for your future operations");
                    }
                    else
                    {
                        bool end = false;
                        for (int i = 0; i < journal.subjects[0].program.lessons.Length && end == false; i++)
                        {
                            if (journal.subjects[0].program.lessons[i] == null)
                            {
                                Console.WriteLine("Enter lessons number");
                                int number = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Enter lessons time");
                                int time = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Enter lessons topic");
                                string topic = Console.ReadLine();
                                Console.WriteLine("Enter lessons homeTask");
                                string homeTask = Console.ReadLine();
                                Console.WriteLine("This lesson date");
                                Console.WriteLine("Enter day");
                                int day = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Enter month");
                                int month = Int32.Parse(Console.ReadLine());
                                Console.WriteLine("Enter year");
                                int year = Int32.Parse(Console.ReadLine());
                                Date date = new Date(day, month, year);
                                journal.subjects[0].program.lessons[i] = new Lesson(number, time, topic, homeTask, date);
                                Console.WriteLine("Lesson successfuly added");
                                end = true;
                            }
                        }
                    }
                    break;
                case '6':
                    if (journal.subjects[0].program.lessons[0] == null)
                    {
                        Console.WriteLine(" No lessons. Add some for your future operations");
                    }
                    else
                    {
                        bool end = false;
                        for (int i = 0; i < journal.subjects[0].program.lessons.Length && end == false; i++)
                        {
                            if (journal.subjects[0].program.lessons[i] != null)
                            {
                                Console.WriteLine("Lessons :");
                                journal.subjects[0].program.lessons[i].Show();
                            }
                            else
                            {
                                end = true;
                            }
                        }
                    }
                    break;
                default: Console.WriteLine("Wrong Input"); break;
            }
            Console.ReadKey();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            Lesson[] lessons = new Lesson[20];
            SubjectProgram program = new SubjectProgram("Lusyak Petro Grugorovitch",lessons);
            Student []students = new Student[38];
            StudentList studList = new StudentList(130,students);
            Subject []subjects = new Subject[15];
            subjects[0] = new Subject("OOP",program,studList);
            Journall journal = new Journall("RPZ-415",4,2018,subjects);
            while (true)
            {
                Menu(journal);
            }
        }
    }
}