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
    public partial class Form1 : Form
    {
        private Form addForm;
        private Form addToCompensate;
        private Form addCompensated;
        private Form remove;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm = new Add();
            addForm.ShowDialog();
        }

        private void registHourToOffsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addToCompensate = new AddHour();
            addToCompensate.ShowDialog();
            updateLv();
        }

        private void registToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCompensated = new AddHourC();
            addCompensated.ShowDialog();
            updateLv();
        }

        public void updateLv()
        {
            foreach(Student s in Program.students)
            {
                foreach(Hour h in s.HoursToCompensate)
                {
                    lvLine line = new lvLine(s, h);
                    lvData.Items.Add(line.generateLine(h));
                }
                foreach(HourC hc in s.CompensatedHours)
                {
                    lvLine line = new lvLine(s, hc);
                    lvData.Items.Add(line.generateLine(hc));
                }
            }
        }

        private void lvData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ferramentasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void totalsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Program.students.getTotals();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            remove = new Remove();
            remove.ShowDialog();
            updateLv();
        }
    }
}
