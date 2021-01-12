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
    public partial class AvailablePhysician : Form
    {
        public AvailablePhysician()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PatientMenu patientMenu = new PatientMenu();
            patientMenu.ShowDialog();
            this.Close();
        }
    }
}
