using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalTask
{
    public class Date
    {
        int day;
        int month;
        int year;
        public Date() { }
        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }
        public void Show()
        {
            Console.WriteLine("Day =" + this.day + " Month = " + this.month + " Year = " + this.year);
        }
    }
}
