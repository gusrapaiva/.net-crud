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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void sairBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Cl_Login lgn = new Cl_Login();
        Form1 main = new Form1();

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            if(loginTxt.Text == "" || senhaTxt.Text == "")
            {
                MessageBox.Show("Digite Login e Senha para acessar o sistema!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    bool logar = lgn.Login(loginTxt.Text, senhaTxt.Text);

                    if (logar == true) 
                    { 
                        this.Hide();
                        main.Show();
                    }
                    else
                    { 
                        MessageBox.Show("Usuário ou senha incorretos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error );
                        senhaTxt.Clear();
                        loginTxt.Focus();  
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
