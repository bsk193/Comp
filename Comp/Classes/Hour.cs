﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    public class Hour
    {
        public Hour(Int32 Quarter, Int32 Quantity)
        {
            quarter = Quarter;
            quantity = Quantity;

        }
        private Int32 quarter;
        public Int32 Quarter { get { return quarter; } set { quarter = value; } }

        private Int32 quantity;
        public Int32 Quantity { get { return quantity; } set { quantity = value; } }

        public Initials Initials { get; set; }
        //public enumInitials Initials { get { return initials.ToString; } set { initials = value; } }
    }
}
