using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EChallanApp
{
    public partial class OfficerScreen : Form
    {
        public OfficerScreen()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfficerLogin login = new OfficerLogin();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChallanHistoryOfficer screen = new ChallanHistoryOfficer();
            screen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ScanFace screen = new ScanFace();
            screen.Show();
        }
    }
    
}
