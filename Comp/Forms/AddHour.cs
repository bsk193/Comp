using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp
{
    public partial class AddHour : Form
    {
        Students students = new Students();
        public AddHour(Students students)
        {
            InitializeComponent();
            this.students = students;
        }

        private void AddHour_Load(object sender, EventArgs e)
        {
            foreach(Student st in students)
            {
                
                foreach(ListViewItem lv in lstData.Items)
                {
                    if (st.ClassCode == lv.Text)
                        continue;
                    else
                        lstData.Items.Add(st.ClassCode);

                }
            }
        }
    }
}
