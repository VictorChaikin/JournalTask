using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JournalTask
{
    public class Mark
    {
        int mark;
        Date date;
        public Mark() { }
        public Mark(int mark, Date date)
        {
            this.mark = mark;
            this.date = date;
        }
        public void Show()
        {
            Console.WriteLine("Mark = " + this.mark);
            this.date.Show();
        }
    }
}
