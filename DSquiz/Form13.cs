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
    public partial class Form13 : Form

    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int PontuacaoAtual = ScoreManager.Score;
                ScoreManager.Score += 10;

            }
            else
            {
            }
            Resources.Form14 form13 = new Resources.Form14();
            form13.Show();
            this.Hide();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            label1.Text = "Quem é conhecido por ser forte sem musculos";
        }
    }
}
