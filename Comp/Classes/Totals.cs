using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp
{
    class totals
    {
        private Student selectedStudent;
        private Int32 compTotal;
        public Int32 CompTotal { get { return compTotal; } set { compTotal = value; } }

        private Int32 total;
        public Int32 Total { get { return total; } set { total = value;  } }

        private String subject;
        public String Subject { get { return subject; } set { subject = value; } }

        public totals(Student st, Int32 CompTotal, Int32 Total, String Subject)
        {
            selectedStudent = st;
            this.CompTotal = compTotal;
            this.Total = total;
            this.Subject = subject;
        }        
    }
}
