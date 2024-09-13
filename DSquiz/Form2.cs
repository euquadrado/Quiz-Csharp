using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSquiz
{
    public partial class Form2 : Form
    {
 

        public static class Credenciais
        {
            public static string Email { get; set; }
            public static string Senha { get; set; }
            public static string Nome { get; set; }
        }

        public Form2()
        {
            InitializeComponent();
            txtSenhaLogin.PasswordChar = '*';
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
                Form3 form3 = new Form3();
                form3.Show();
            this.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (txtEmailLogin.Text == Credenciais.Email && txtSenhaLogin.Text == Credenciais.Senha)
            {
                //MessageBox.Show("Login realizado com sucesso!");//
                Resources.Form4 form4 = new Resources.Form4();
                form4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos.");
            }
            }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
