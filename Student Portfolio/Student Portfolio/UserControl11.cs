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
    public partial class UserControl11 : UserControl
    {
        public UserControl11()
        {
            InitializeComponent();
            blank1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl121.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userControl131.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            userControl141.BringToFront();
        }
    }
}
