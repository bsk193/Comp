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
        private Form addHourDetails;
        private int lstType = 0;
        private List<Student> studentsAdd;

        public AddHour()
        {
            InitializeComponent();
        }

        private void AddHour_Load(object sender, EventArgs e)
        {
            lstClasses();
        }

        private void lstData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstType == 0)
                lstClasses();
            if (lstType == 1)
                lstStudents()
                lstType = 3;
                foreach(Student s in Program.students)
                {
                    if(s.Name ==
                }
                addHourDetails = new AddHour();
                addHourDetails.Show();
            }
        }

        private void lstClasses()
        {
            lstData.Clear();
            
            if (Program.students.Count > 0)
            {
                foreach (Student st in Program.students)
                {
                    if (lstData.Items.Count > 0)
                    {
                        lstData.View = View.Details;
                        foreach (ListViewItem lv in lstData.Items)
                        {
                            if (st.ClassCode == lv.Text)
                                break;
                            else
                                lstData.Items.Add(st.ClassCode);
                        }
                    }
                    else
                        lstData.Items.Add(st.ClassCode);
                }
                lstType = 1;
            }
            else
            {
                string message = "There is no students registered !";
                string title = "Error!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
                lstType = 1;
            }
        }

        private void lstStudents()
        {
            lstData.Clear();
            if(lstType == 2)
            {

            }
            if (lstType == 1)
            {
                foreach (Student st in Program.students)
                {
                    if (lstData.Items.Count > 0)
                    {
                        lstData.Items.Add(st.Name);
                        studentsAdd.Add(st);
                    }
                    else
                    {
                        if (st.ClassCode == lstData.SelectedIndices.ToString())
                        {
                            lstData.Items.Add(st.Name);
                            studentsAdd.Add(st);
                        }
                    }
                }
                lstType = 2;
            }
        }
    }
}
