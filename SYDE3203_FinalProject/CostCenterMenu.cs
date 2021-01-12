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
    public partial class CostCenterMenu : Form
    {
        public CostCenterMenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report_DailyRevenue dailyRevenue = new Report_DailyRevenue();
            dailyRevenue.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report_RevenueAnalysis revenueAnalysis = new Report_RevenueAnalysis ();
            revenueAnalysis.ShowDialog();
            this.Close();
        }
    }
}
