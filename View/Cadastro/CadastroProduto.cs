using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospedagem_em_C_.Controller;

namespace Hospedagem_em_C_.View.Cadastro
{
    public partial class CadastroProduto : Form
    {
        EntradaController entradaController = new EntradaController();
        public CadastroProduto()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            entradaController.permitirApenasNumero(e);
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ProdutoController produtoController = new ProdutoController();

            //se adicionar, janela fecha
            if (produtoController.adicionarProduto(txtNome.Text, txtQuantidade.Text, txtValor.Text))
            {
                this.Close();
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            entradaController.formatoPreco(e, txtValor);
        }
    }
}
