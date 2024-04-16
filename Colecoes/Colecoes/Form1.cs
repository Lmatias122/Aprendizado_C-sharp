using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string[] nomes = new string[3];


            List<string> nomes2 = new List<string>();

            nomes2.Add("lucas");
            nomes2.Add("leo");
            nomes2.Add("matias");

            foreach (string nome in nomes2)
            {
                Lista.Items.Add(nome);
            }
        }

        private void BtnSortedList_Click(object sender, EventArgs e)
        {
            Lista.Items.Clear();

            SortedList<int, string> alunos = new SortedList<int, string>()
            {
                {27,"Danny"},
                {10,"Gabriel"},
                {17,"Arthur"}
            };

            alunos.Add(14, "Gloria");

       

            foreach (KeyValuePair<int,string> aluno in alunos)
            {
                Lista.Items.Add(aluno.Key + " " + aluno.Value);
            }
        }
    }
}
