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
    public partial class Form12 : Form
    {
        private int score;
        public Form12()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                int PontuacaoAtual = ScoreManager.Score;
                ScoreManager.Score += 10;

            }
            else
            {
            }
            Resources.Form13 form12 = new Resources.Form13();
            form12.Show();
            this.Hide();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            label1.Text = "Quem paga em pirulitos";
        }
    }
}
