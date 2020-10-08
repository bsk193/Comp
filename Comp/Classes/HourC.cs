using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    public class HourC
    {
        enum Initials
        {
            PT,
            ING,
            TIC,
            EF,
            AI,
            FQ,
            MAT,
            PSI,
            SO,
            AC,
            RC
        }
        private Int32 quarter;
        public Int32 Quarter { get { return quarter; } set { quarter = value; } }
        private DateTime date;
        public DateTime Date { get { return date; } set { date = value; } }

        DateTime HourStart;
        DateTime HourEnd;
    }
}
