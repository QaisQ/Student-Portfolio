using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            userControl11.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl11.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            examsControl1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            homework1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            userControl21.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userControl41.BringToFront();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            userControl61.BringToFront();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            userControl71.BringToFront();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            userControl81.BringToFront();          
        }

        private void button10_Click(object sender, EventArgs e)
        {
            userControl101.BringToFront();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            userControl111.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            userControl51.BringToFront();
        }
    }
}
