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
    public partial class FormVendas : Form
    {

        BindingList<Produto> listaProduto = new BindingList<Produto>(); 

        public FormVendas()
        {
            InitializeComponent();

            Produto p1 = new Produto();

            cbSelecaoProdutos.Items.Add("Ração");
            cbSelecaoProdutos.Items.Add("Brinquedo");
            cbSelecaoProdutos.Items.Add("Coleira");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
           if(dgvExibirItens.CurrentRow != null)
            {
               Produto produto = new Produto();
               Produto Quantidade = new Produto();
            }

            
        }
    }
}
