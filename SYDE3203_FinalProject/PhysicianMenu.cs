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
    public partial class PhysicianMenu : Form
    {
        public PhysicianMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhysicianRegister physicianRegister = new PhysicianRegister();
            physicianRegister.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report_Physician_Patient report_Physician = new Report_Physician_Patient();
            report_Physician.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Physician_DisplayInfo physician_DisplayInfo = new Physician_DisplayInfo();
            physician_DisplayInfo.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhysicianUpdate physicianUpdate = new PhysicianUpdate();
            physicianUpdate.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            PhysicianSchedule physicianSchedule = new PhysicianSchedule();
            physicianSchedule.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }
    }
}
