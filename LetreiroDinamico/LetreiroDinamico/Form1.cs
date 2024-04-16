using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LetreiroDinamico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left < 0 && (Math.Abs(label1.Left) > label1.Width))
                label1.Left = this.Width;

            // if label startsfrom outside part of the form on the left and absolute value of its left cordinate is higher than width of label, moving label to the right part of form right outside of it

            //if (label2.Left < 0 && (Math.Abs(label2.Left) > label2.Width))
            //    label2.Left = this.Width;

            label1.Left -= 1;
            //label2.Left -= 1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 5;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
