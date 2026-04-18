using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Box_House
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            FormVendas form = new FormVendas();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            FormEntrega form = new FormEntrega();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
