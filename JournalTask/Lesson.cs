using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalTask
{
    public class Lesson
    {
        int number;
        int time;
        string topic;
        string homeTask;
        Date date;
        public Lesson() { }
        public Lesson(int number, int time, string topic, string homeTask, Date date)
        {
            this.number = number;
            this.time = time;
            this.topic = topic;
            this.homeTask = homeTask;
            this.date = date;
        }
        public void Show()
        {
            Console.WriteLine("Number = "+this.number);
            Console.WriteLine("Time = " + this.time);
            Console.WriteLine("Topic = " + this.topic);
            Console.WriteLine("Home Task = " + this.homeTask);
            this.date.Show();
        }

    }

}
