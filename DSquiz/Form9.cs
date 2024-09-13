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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                int PontuacaoAtual = ScoreManager.Score;
                ScoreManager.Score += 10;

            }
            else
            {
            }
            Resources.Form10 form9 = new Resources.Form10();
            form9.Show();
            this.Hide();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            label1.Text = "Oque Mordecai Rigby fazem para ganha dinheiro";
        }
    }
}
