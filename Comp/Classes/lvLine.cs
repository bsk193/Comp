using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Comp
{
    public class lvLine
    {
        public lvLine(Student Student, HourC compensatedHour)
        {
            this.Student = Student;
            this.compensatedHour = compensatedHour;
        }

        public lvLine(Student Student, Hour toCompensateHour)
        {
            this.Student = Student;
            this.toCompensateHour = toCompensateHour;
        }

        Student Student;
        HourC compensatedHour;
        Hour toCompensateHour;

        public ListViewItem generateLine(HourC hc )
        {
            var item = new ListViewItem(new[] { Student.Name, compensatedHour.Quarter.ToString(), compensatedHour.Initials.ToString(), (compensatedHour.HourStart.ToString() + ":" + compensatedHour.MinuteStart.ToString()), (compensatedHour.HourEnd.ToString() + ":" + compensatedHour.MinuteEnd.ToString()), (((compensatedHour.HourEnd * 60) + compensatedHour.MinuteEnd) - ((compensatedHour.HourStart * 60) + compensatedHour.MinuteEnd)).ToString() });
            return item;
        }


        public ListViewItem generateLine(Hour h)
        {
            var item = new ListViewItem(new[] { Student.Name, toCompensateHour.Quarter.ToString(), toCompensateHour.Initials.ToString(), "", "", "", (toCompensateHour.Quantity / 60).ToString() });

            return item;
        }
    }
}
