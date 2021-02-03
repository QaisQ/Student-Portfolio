using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class _11a : UserControl
    {
        public _11a()
        {
            InitializeComponent();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
            pictureBox8.Hide();
            pictureBox9.Hide();
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox9.Show();
            pictureBox9.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox8.Show();
            pictureBox8.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox7.Show();
            pictureBox7.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox6.Show();
            pictureBox6.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pictureBox5.Show();
            pictureBox5.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pictureBox4.Show();
            pictureBox4.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            pictureBox3.Show();
            pictureBox3.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox2.Show();
            pictureBox2.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            pictureBox1.Show();
            pictureBox1.BringToFront();
        }
    }
}
