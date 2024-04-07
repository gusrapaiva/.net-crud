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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        cl_ControleContato contato = new cl_ControleContato();

        private void inserirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastro cadastro = new FormCadastro();
            cadastro.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cl_Conexao conexao = new cl_Conexao();

            MessageBox.Show(conexao.conectar());

            conexao.desconectar();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formconsulta consulta = new Formconsulta();
            consulta.Show();
        }

        private void backuoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(contato.Backup("C:/Backup"), "Backup do Banco de Dados", MessageBoxButtons.OK);
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManuak_ manual = new FormManuak_();
            manual.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.ShowDialog();
        }

        private void restauraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "sql files (*.sql)|* .sql|All files(*.*)|*.*";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string caminhoBackup = openFileDialog1.FileName;
                MessageBox.Show(contato.Restore(caminhoBackup), "Restauração do BD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
