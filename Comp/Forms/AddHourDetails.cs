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
    public partial class AddHourDetails : Form
    {
        private Int32 Student;
        public AddHourDetails(Student Student)
        {
            InitializeComponent();
            this.Student = Convert.ToInt32(Student.StudentNumber);
            comboSubject.DataSource = Enum.GetValues(typeof(Initials));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(Program.students.validateData(comboSubject.SelectedItem.ToString(), Convert.ToInt32(numericQuarter.Value), Student))
            {
                Student currStud = Program.students.getByNumber(Student);
                Hour toComp = new Hour(Convert.ToInt32(numericQuarter.Value), Convert.ToInt32((Convert.ToInt32(numericH.Value) * 60) + (Convert.ToInt32(numericM.Value))));
                currStud.HoursToCompensate.Adicionar(toComp);
                this.Close();
            }
            else
            {
                string message = "Repeated !";
                string title = "Error!";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
