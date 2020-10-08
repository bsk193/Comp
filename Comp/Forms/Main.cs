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
        private Form addOffset;
        Students students;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            students = new Students();
        }

        private void createToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addForm = new Add(students);
            addForm.Show();
        }

        private void registHourToOffsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addOffset = new AddHour(students);
            addOffset.Show();
        }
    }
}
