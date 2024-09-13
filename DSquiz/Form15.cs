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

namespace DSquiz
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
                if (radioButton1.Checked)
                {
                    int PontuacaoAtual = ScoreManager.Score;
                    ScoreManager.Score += 10;

                }
                else
                {
                }
                Resources.Form14 form15 = new Resources.Form14();
                form15.Show();
                this.Hide();
            }

            private void Form15_Load(object sender, EventArgs e)
            {
                label1.Text = "10.Qual é o nome do personagem que é um fantasma e tem a habilidade de se teleportar?";
            }

        
    }
    }
    

