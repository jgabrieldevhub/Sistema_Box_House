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

        BindingList<Produto> listaProdutos = new BindingList<Produto>();
        BindingList<Produto> estoqueProdutos = new BindingList<Produto>();

        double valorTotal = 0;

        public FormVendas()
        {
            InitializeComponent();

            Produto p1 = new Produto("Ração de Gato", 13.99, 1);
            Produto p2 = new Produto("Coleira Guia", 16.99, 1);
            Produto p3 = new Produto("Osso Grande", 19.99, 1);
            Produto p4 = new Produto("Roupinha inverno", 21.99, 1);

            estoqueProdutos.Add(p1);
            estoqueProdutos.Add(p2);
            estoqueProdutos.Add(p3);
            estoqueProdutos.Add(p4);

            dgvExibirItens.DataSource = listaProdutos;

            cbSelecaoProdutos.Items.Add("Ração de Gato");
            cbSelecaoProdutos.Items.Add("Coleira Guia");
            cbSelecaoProdutos.Items.Add("Osso Grande");
            cbSelecaoProdutos.Items.Add("Roupinha inverno");
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nomeProduto = cbSelecaoProdutos.Text;
            int qtdProduto = (int)numQuantidade.Value;

            if (nomeProduto != string.Empty && qtdProduto > 0) {

                var statusProduto = estoqueProdutos.FirstOrDefault(p => p.NomeProduto == nomeProduto);
                double valorProduto = statusProduto.ValorProduto;

                Produto produtoAdicionado = new Produto(nomeProduto, valorProduto, qtdProduto);

                listaProdutos.Add(produtoAdicionado);

                valorTotal = valorTotal + (valorProduto * qtdProduto);

                lbPreco.Text = $"R${valorTotal.ToString("F2")}";

                fnLimpar();

                dgvExibirItens.Refresh();

                produtoAdicionado.fnMsgAddProduto();

            }else
            {
                MessageBox.Show("Preencha os dados corretamente", "Mensagem de Aviso");
            }
            
        }

        private void fnLimpar()
        {
            cbSelecaoProdutos.SelectedIndex = -1;
            numQuantidade.Value = 1;
            cbSelecaoProdutos.Focus();
        }

        private void dgvExibirItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvExibirItens.Columns["NomeProduto"].HeaderText = "Nome do Produto";
            dgvExibirItens.Columns["ValorProduto"].HeaderText = "Valor do Produto";
            dgvExibirItens.Columns["QtdProduto"].HeaderText = "Quantidade do Produto";
        }
    }
}
