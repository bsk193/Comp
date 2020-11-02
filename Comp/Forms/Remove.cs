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
    public partial class Remove : Form
    {
        private Int32 lstType = 0;
        private Student[] studs = new Student[Program.students.Count];
        private List<Student> studsL = new List<Student>();

        public Remove()
        {
            InitializeComponent();
        }

        private void AddHour_Load(object sender, EventArgs e)
        {
            String[] classes = Program.students.getClasses();
            lstData.Clear();
            foreach(String s in classes)
            {
                lstData.Items.Add(s);
            }
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstType == 0)
            {
                studs = Program.students.getStudsbyClass(lstData.SelectedItems[0].Text);
                lstData.Clear();
                foreach (Student s in studs)
                {
                    if (s == null)
                        break;
                    else
                    {
                        lstData.Items.Add(s.Name);
                        studsL.Add(s);
                    }

                }
                lstType = 2;
                return;

            }
            if (lstType == 2)
            {
                Program.students.Retirar(studsL[lstData.SelectedIndices[0]]);
                this.Close();
            }
        }
    }
}
