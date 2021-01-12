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
    public partial class Report_DailyRevenue : Form
    {
        public Report_DailyRevenue()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CostCenterMenu costCenterMenu = new CostCenterMenu();
            costCenterMenu.ShowDialog();
            this.Close();
        }
        
    }
}
