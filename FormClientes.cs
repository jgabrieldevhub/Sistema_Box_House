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
    public partial class FormClientes : Form
    {

        BindingList<cliente> clientesCadastrados = new BindingList<cliente>();

        public FormClientes()
        {
            InitializeComponent();

            dgvClientesCadastrados.DataSource = clientesCadastrados;

            txtNome.Focus();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string nomeCliente = txtNome.Text;
            string telefoneCliente = txtTelefone.Text;
            string nomePetCliente = txtNomePet.Text;

            bool clienteCadastrado = clientesCadastrados.Any(p => p.NomeCliente.ToLower() == nomeCliente.ToLower());
            bool telefoneCadastrado = clientesCadastrados.Any(p => p.Telefone == telefoneCliente);

            if (nomeCliente != string.Empty && telefoneCliente.Length == 15 && nomePetCliente != string.Empty)
            {
                if (clienteCadastrado == false && telefoneCadastrado == false){

                    cliente novoClienteCadastrado = new cliente(nomeCliente, telefoneCliente, nomePetCliente);

                    clienteCadastrado.Add(novoClienteCadastrado);

                }else
                {

                }

            } else
            {

            }
        }

        private void limparCampos()
        {
            txtNome.Text = "";
            txtTelefone.Text = "";
            txtNomePet.Text = "";

            txtNome.Focus();
        }
    }
}
