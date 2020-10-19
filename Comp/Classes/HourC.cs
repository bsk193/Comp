using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    public class HourC
    {
        public HourC(Int32 Quarter, DateTime Date, Int32 HourStart, Int32 MinuteStart, Int32 HourEnd, Int32 MinuteEnd)
        {
            quarter = Quarter;
            date = Date.Date;
            hourStart = HourStart;
            minuteStart = MinuteStart;
            hourEnd = HourEnd;
            minuteEnd = MinuteEnd;
        }
        private Int32 quarter;
        public Int32 Quarter { get { return quarter; } set { quarter = value; } }
        private DateTime date;
        public DateTime Date { get { return date; } set { date = value; } }

        private Int32 hourStart;
        public Int32 HourStart { get { return hourStart; } set { hourStart = value; } }

        private Int32 minuteStart;
        public Int32 MinuteStart { get { return minuteStart; } set { minuteStart = value; } }

        private Int32 hourEnd;
        public Int32 HourEnd { get { return hourEnd; } set { hourEnd = value; } }

        private Int32 minuteEnd;
        public Int32 MinuteEnd { get { return minuteEnd; } set { minuteEnd = value; } }

        public Initials Initials { get; set; }
    }
}