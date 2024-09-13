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

namespace DSquiz
{
    public partial class Form3 : Form
    {
  
        public Form3()
        {
            

            InitializeComponent();
            txtSenha.PasswordChar = '*';
            textBox4.PasswordChar = '*';
        }

       
        private void Button1_Click(object sender, EventArgs e)
        {
            {
                Credenciais.Email = txtEmail.Text;
                Credenciais.Senha = txtSenha.Text;
                Credenciais.Nome = txtNome.Text;
               // MessageBox.Show("Cadastro realizado com sucesso!"+ Credenciais.Nome);//


                if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtSenha.Text) ||
                    string.IsNullOrWhiteSpace(textBox4.Text))
                {
                    MessageBox.Show("Por favor, preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

               
                if (txtSenha.Text != textBox4.Text)
                {
                    MessageBox.Show("As senhas não coincidem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Form2 form2 = new Form2();
                    this.Hide();
                    form2.Show();
                }
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

