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
    public partial class AddHourCDetails : Form
    {
        private Int32 Student;
        public AddHourCDetails(Student Student)
        {
            InitializeComponent();
            this.Student = Convert.ToInt32(Student.StudentNumber);
            comboSubject.DataSource = Enum.GetValues(typeof(Initials));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Program.students.validateData(comboSubject.SelectedItem.ToString(), Convert.ToInt32(numericQuarter.Value), Student, datePicker.Value.Date, Convert.ToInt32(numericHStart), Convert.ToInt32(numericMStart), Convert.ToInt32(numericHEnding), Convert.ToInt32(numericMEnding)))
            {
                Student currStud = Program.students.getByNumber(Student);
                HourC Comp = new HourC(Convert.ToInt32(numericQuarter.Value), datePicker.Value.Date, Convert.ToInt32(numericHStart), Convert.ToInt32(numericMStart), Convert.ToInt32(numericHEnding), Convert.ToInt32(numericMEnding));
                currStud.CompensatedHours.Adicionar(Comp);
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

        private void AddHourCDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
