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
    public partial class _18PlusForm : Form
    {
        public _18PlusForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PrintScreenAbove screen = new PrintScreenAbove();
            screen.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
           ScanFace screen = new ScanFace();
            screen.Show();
        }
    }
}
