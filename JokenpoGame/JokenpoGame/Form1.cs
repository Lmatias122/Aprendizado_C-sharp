using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokenpoGame
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<int, string> Escolha = new Dictionary<int, string>
        {
            {1,"Pedra" },
            {2,"Papel"},
            {3,"Tesoura" }

        };

        private void BtnRock_Click(object sender, EventArgs e)
        {
            Picbox1.BackgroundImage = BtnRock.BackgroundImage;
            Picbox1.BackgroundImageLayout = BtnRock.BackgroundImageLayout;
            var ValorPc = Operacao.Calculo(1);
            var Result = Operacao.Resultado(1, ValorPc);

            if (ValorPc == 1) 
            {
                PicBox2.BackgroundImage = JokenpoGame.Properties.Resources.Pedra1;
                PicBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if(ValorPc ==2)
            {
                PicBox2.BackgroundImage = JokenpoGame.Properties.Resources.Papel;
                PicBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (ValorPc == 3)
            {
                PicBox2.BackgroundImage = JokenpoGame.Properties.Resources.Tesoura;
                PicBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }

          
        }

        private void BtnPaper_Click(object sender, EventArgs e)
        {
            Picbox1.BackgroundImage = BtnPaper.BackgroundImage;
            Picbox1.BackgroundImageLayout = BtnPaper.BackgroundImageLayout;
           var ValorPc = Operacao.Calculo(2);
            if (ValorPc == 1)
            {
                PicBox2.BackgroundImage = JokenpoGame.Properties.Resources.Pedra1;
                PicBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (ValorPc == 2)
            {
                PicBox2.BackgroundImage = JokenpoGame.Properties.Resources.Papel;
                PicBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (ValorPc == 3)
            {
                PicBox2.BackgroundImage = JokenpoGame.Properties.Resources.Tesoura;
                PicBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void BtnTesoura_Click(object sender, EventArgs e)
        {
            Picbox1.BackgroundImage = BtnTesoura.BackgroundImage;
            Picbox1.BackgroundImageLayout = BtnTesoura.BackgroundImageLayout;
            var ValorPc = Operacao.Calculo(3);
            if (ValorPc == 1)
            {
                PicBox2.BackgroundImage = JokenpoGame.Properties.Resources.Pedra1;
                PicBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (ValorPc == 2)
            {
                PicBox2.BackgroundImage = JokenpoGame.Properties.Resources.Papel;
                PicBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (ValorPc == 3)
            {
                PicBox2.BackgroundImage = JokenpoGame.Properties.Resources.Tesoura;
                PicBox2.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
