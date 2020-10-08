using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    public class Hour
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

        private Int32 quantity;
        public Int32 Quantity { get { return quantity; } set { quantity = value; } }
    }
}
