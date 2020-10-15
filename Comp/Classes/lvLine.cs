using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    public class lvLine
    {
        public lvLine(Student Student, HourC compensatedHour)
        {
            this.Student = Student;
            this.compensatedHour = compensatedHour;
        }

        Student Student;
        HourC compensatedHour;
        Int32 Remains;

        public String[] generateLine()
        {
            String[] line = { Student.Name, compensatedHour.Quarter.ToString(), compensatedHour.Initials.ToString(), (compensatedHour.HourStart.ToString() + ":" + compensatedHour.MinuteStart.ToString()), (compensatedHour.HourEnd.ToString() + ":" + compensatedHour.MinuteEnd.ToString()), ((compensatedHour.HourEnd * 60) + compensatedHour.MinuteEnd)) -((compensatedHour.HourEnd * 60) + compensatedHour.MinuteEnd).ToString()};
            ((compensatedHour.HourEnd * 60) + compensatedHour.MinuteEnd)) -((compensatedHour.HourEnd * 60) + compensatedHour.MinuteEnd).ToString();
            String[0] = Student.Name;
        }
    }
}
