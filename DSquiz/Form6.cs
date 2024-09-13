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
    public partial class Form6 : Form
    {

        public Form6()
        {
            InitializeComponent();
           
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            label1.Text = "Que é o irmão do Rigby";
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
            Resources.Form7 form6 = new Resources.Form7();
            form6.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
