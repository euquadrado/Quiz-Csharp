using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DSquiz.Form2;

namespace DSquiz.Resources
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Olá " + Credenciais.Nome + "\n"+" Seja Bem vindo ao Quiz de Apenas Um Show";
            label2.Text = "\"Apenas um Show\" é uma série animada de televisão criada por\n"+" J.G. Quintel para o Cartoon Network.\n" +
                " A série segue as aventuras de dois amigos, Mordecai (um gaio-azul) \n"+"e Rigby (um guaxinim), que trabalham como jardineiros em um parque.\n" +
                " A trama é conhecida por sua mistura de humor surreal\n"+" e situações bizarras que os personagens enfrentam.";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Resources.Form5 form4 = new Resources.Form5();
            form4.Show();
            this.Hide();
        }
    }
}
