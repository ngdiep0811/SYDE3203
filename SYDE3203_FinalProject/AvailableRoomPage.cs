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
    public partial class AvailableRoomPage : Form
    {
        public AvailableRoomPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AvailablePhysician availablePhysician = new AvailablePhysician();
            availablePhysician.ShowDialog();
            this.Close();
        }
        
    }
}
