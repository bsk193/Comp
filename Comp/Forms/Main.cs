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
            addForm.Show();
        }

        private void registHourToOffsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addToCompensate = new AddHour();
            addToCompensate.Show();
        }

        private void registToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCompensated = new AddHourC();
            addCompensated.Show();
        }
    }
}
