using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conexaão_BD2
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }

        cl_Contato cont = new cl_Contato();
        cl_ControleContato controle = new cl_ControleContato();

        private void limpar()
        {
            celTxt.Clear();
            codTxt.Clear();
            emailTxt.Clear();
            telTxt.Clear();
            nomeTxt.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nomeTxt.Text == "")
            {
                MessageBox.Show("Nome é obrigatório no cadastro");
            }
            else
            {
                cont.Nome = nomeTxt.Text;
                cont.Email = emailTxt.Text;
                cont.Celular = celTxt.Text;
                cont.Telefone = telTxt.Text;

                MessageBox.Show(controle.cadastrar(cont));

                limpar();
            }
        }

        private void alterarBtn_Click(object sender, EventArgs e)
        {
            cont.Codcontato = int.Parse(codTxt.Text);
            cont.Nome = nomeTxt.Text;
            cont.Email = emailTxt.Text;
            cont.Telefone = telTxt.Text;
            cont.Celular = celTxt.Text;

            MessageBox.Show(controle.alterar(cont));
        }

        private void buscarBtn_Click(object sender, EventArgs e)
        {

            try
            {
                cont = controle.buscar(int.Parse(codTxt.Text));

                if(cont == null)
                {
                    MessageBox.Show("Registro não encontrado!");
                }
                else
                {
                    codTxt.Text = cont.Codcontato.ToString();
                    celTxt.Text = cont.Celular.ToString();
                    telTxt.Text = cont.Telefone.ToString();
                    emailTxt.Text = cont.Email.ToString();
                    nomeTxt.Text = cont.Nome.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
