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
        private Int32 lstType = 0;
        private List<Student> studentsAdd;
        private Int32 currentStudent;

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
                lstStudents(lstData.SelectedItems.ToString());
            if (lstType == 2)
            {
                addHourDetails = new AddHourDetails(Convert.ToInt32(lstData.SelectedItems.ToString()));
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

        private void lstStudents(String ClassCode)
        {
            lstData.Clear();
            foreach (Student st in Program.students)
            {
                if (st.ClassCode == ClassCode)
                {
                    lstData.Items.Add(st.Name);
                    studentsAdd.Add(st);
                }
            }
            lstType = 2;
        }
    }
}
