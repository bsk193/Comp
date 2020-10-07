using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    public class Student
    {
        Int64 StudentNumber { get; set; }
        String Name { get; set; }
        String ClassCode { get; set; }

        ToOffset HoursToOffset = new ToOffset();
        Compensated CompensatedHours = new Compensated();
    }
}
