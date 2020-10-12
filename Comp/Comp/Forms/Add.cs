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
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();        
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private bool validateNumber(Int64 StudentNumber)
        {
            foreach (Student st in Program.students)
            {
                if (st.StudentNumber == StudentNumber)
                    return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Program.students.Count > 0)
            {
                if (validateNumber(Convert.ToInt64(txtNumber.Text)))
                {
                    Student st = new Student(Convert.ToInt64(txtNumber.Text), txtName.Text, txtClass.Text);
                    Program.students.Adicionar(st);
                    this.Close();
                }
            }
            else
            {
                Student st = new Student(Convert.ToInt64(txtNumber.Text), txtName.Text, txtClass.Text);
                Program.students.Adicionar(st);
                this.Close();
            }
        }
    }
}
