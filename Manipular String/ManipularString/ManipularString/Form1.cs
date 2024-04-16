using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipularString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //decimal valor = 19.95m;
            //int temp = 23;
            //string s = String.Format("O valor do produto é {0:C2} e a temp {1}", valor,temp);

            

            string s = String.Format("Hoje é {0:d} e são {0:t}",DateTime.Now);
            label1.Text = s;
        }
    }
}
