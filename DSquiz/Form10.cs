using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DSquiz.Resources.Form5;

namespace DSquiz.Resources
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                int PontuacaoAtual = ScoreManager.Score;
                ScoreManager.Score += 10;

            }
            else
            {
            }
            Resources.Form11 form10 = new Resources.Form11();
            form10.Show();
            this.Hide();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            label1.Text = "Quem foi o Primeiro amor de Mordecai";
        }
    }
}
