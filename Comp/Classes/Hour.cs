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
        Int32 Quarter { get; set; }
        Int32 Quantity { get; set; }
    }
}
