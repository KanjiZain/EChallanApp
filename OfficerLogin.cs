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
    public partial class OfficerLogin : Form
    {
        public OfficerLogin()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            OfficerScreen form3 = new OfficerScreen();

            form3.Show();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox4.PasswordChar = '*';
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainScreen screen = new MainScreen();
            screen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
