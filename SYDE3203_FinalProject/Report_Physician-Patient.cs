﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SYDE3203_FinalProject
{
    public partial class Report_Physician_Patient : Form
    {
        public Report_Physician_Patient()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhysicianMenu physicianMenu = new PhysicianMenu();
            physicianMenu.ShowDialog();
            this.Close();
        }
    }
}
