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
    public partial class Formconsulta : Form
    {
        public Formconsulta()
        {
            InitializeComponent();
        }

        public void limpar()
        {
            buscaTxt.Clear();
            buscaTxt.Focus();
        }

        cl_ControleContato controle = new cl_ControleContato();

        private void buscarBtn_Click(object sender, EventArgs e)
        {
            if (buscaTxt.Text == "")
            {
                MessageBox.Show("Insira algum dado");
            }
            else
            {


                if (comboBox.SelectedIndex == 0)
                {
                    try
                    {
                        int codigo = Convert.ToInt32(buscaTxt.Text);
                        dataGridView1.DataSource = controle.pesquisaCodigo(codigo);
                    }
                    catch
                    {
                        MessageBox.Show("Digite um valor inteiro para o código");
                        limpar();
                    }
                }
                if (comboBox.SelectedIndex == 1)
                {
                    try
                    {
                        string nome = buscaTxt.Text;
                        dataGridView1.DataSource = controle.pesquisaNome(nome);
                    }
                    catch
                    {
                        MessageBox.Show("Nome inválido");
                        limpar();
                    }
                }
                if (comboBox.SelectedIndex == 2)
                {
                    try
                    {
                        string email = buscaTxt.Text;
                        dataGridView1.DataSource = controle.pesquisaEmail(email);
                    }
                    catch
                    {
                        MessageBox.Show("Email inválido");
                        limpar();
                    }
                }
                if (comboBox.SelectedIndex == 3)
                {
                    try
                    {
                        string telefone = buscaTxt.Text;
                        dataGridView1.DataSource = controle.pesquisaTelefone(telefone);
                    }
                    catch
                    {
                        MessageBox.Show("Telefone inválido");
                        limpar();
                    }
                }
                if (comboBox.SelectedIndex == 4)
                {
                    try
                    {
                        string celular = buscaTxt.Text;
                        dataGridView1.DataSource = controle.pesquisaCelular(celular);
                    }
                    catch
                    {
                        MessageBox.Show("Celular inválido");
                        limpar();
                    }
                }
            }
        }

        private void listarBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controle.PreencherTodos();
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox.SelectedIndex < 0)
            {
                buscaTxt.Enabled = false;
                buscarBtn.Enabled = false;
                lblOpt.Text = "";
            }
            else
            {
                buscaTxt.Enabled = true;
                buscarBtn.Enabled = true;
                lblOpt.Text = "Insira o " + comboBox.Text;
                limpar();
            }
        }
    }
}
