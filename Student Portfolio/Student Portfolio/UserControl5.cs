using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UserControl5 : UserControl
    {
        public UserControl5()
        {
            InitializeComponent();
            blank1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox4.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox5.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox3.BringToFront();
        }
    }
}
