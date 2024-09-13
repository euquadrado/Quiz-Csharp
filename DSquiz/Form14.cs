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
using static DSquiz.Resources.Form5;

namespace DSquiz.Resources
{
    public partial class Form14 : Form
    {
        public int Score { get; private set; }
        public int Erro { get; private set; }

        public Form14()
        {
            InitializeComponent();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            
            Erro = 100 - ScoreManager.Score;

            label1.Text = Credenciais.Nome + " Seu Resultado foi:";
            labelScore.Text = "Pontuação: " + ScoreManager.Score.ToString()+"%";
            label2.Text = "Erros: " + Erro+"%";

        }

        
    }
}
