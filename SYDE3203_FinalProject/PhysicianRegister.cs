using System;
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
    public partial class PhysicianRegister : Form
    {
        public PhysicianRegister()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhysicianMenu physicianMenu = new PhysicianMenu();
            physicianMenu.ShowDialog();
            this.Close();
        }
    }
}
