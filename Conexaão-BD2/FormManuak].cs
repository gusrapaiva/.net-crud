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
    public partial class FormManuak_ : Form
    {
        public FormManuak_()
        {
            InitializeComponent();
        }

        private void FormManuak__Load(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("manual.pdf");
        }
    }
}
