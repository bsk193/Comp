using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    public class HourC
    {
        private Int32 quarter;
        public Int32 Quarter { get { return quarter; } set { quarter = value; } }
        private DateTime date;
        public DateTime Date { get { return date; } set { date = value; } }

        private DateTime hourStart;
        public DateTime HourStart { get { return hourStart; } set { hourStart = value; } }

        private DateTime hourEnd;
        public DateTime HourEnd { get { return hourEnd; } set { hourEnd = value; } }

        private enumInitials Initials { get; set; }
    }
}
