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
    public partial class ExamsControl : UserControl
    {
        public ExamsControl()
        {
            InitializeComponent();
            blank1.BringToFront();

        }



        private void button2_Click(object sender, EventArgs e)
        {
            _11b1.BringToFront();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            _11a1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _12a1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _12b1.BringToFront();
        }

        private void ExamsControl_Load(object sender, EventArgs e)
        {

        }
    }
}
