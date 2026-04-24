using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Box_House
{
    internal class Produto
    {
        public string NomeProduto { get; set; }
        public double ValorProduto { get; set; }
        public int QtdProduto { get; set; }



        public Produto(string nomeProduto, double valorProduto, int qtdProduto)
        {
            NomeProduto = nomeProduto;
            ValorProduto = valorProduto;
            QtdProduto = qtdProduto;
        }

        public void fnMsgAddProduto()
        {
            if (QtdProduto == 1){

                MessageBox.Show($"O produto {NomeProduto} foi adicionado com sucesso!", "Messagem de Aviso");
            }else
            {
                MessageBox.Show($"O produto {NomeProduto} foi adicionado {QtdProduto} vezes no sistema", "Mensagem de Aviso");
            }
        }

    }
}
