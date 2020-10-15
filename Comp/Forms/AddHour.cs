﻿using System;
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

        public AddHour()
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
                Student[] studs = Program.students.getStudsbyClass(lstData.SelectedItems.ToString());
                lstData.Clear();
                foreach (Student s in studs)
                {
                    lstData.Items.Add(s.Name);
                }

            }
            if (lstType == 2)
            {
                addHourDetails = new AddHourDetails(Convert.ToInt32(lstData.SelectedItems.ToString()));
                addHourDetails.Show();
            }
        }
    }
}
