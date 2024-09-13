using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSquiz.Resources
{
    public partial class Form5 : Form
    {
        public static class ScoreManager
        {
            public static int Score { get; set; }
           
        }
        public Form5()
        {
            InitializeComponent();
            
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Text = "Nome do Fortão que saltita";
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

            Resources.Form6 form4 = new Resources.Form6();
            form4.Show();
            this.Hide();
        }
    }
}
