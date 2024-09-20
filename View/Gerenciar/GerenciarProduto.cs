using Hospedagem_em_C_.Controller;
using Hospedagem_em_C_.Model.DTO;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedagem_em_C_.View.Gerenciar
{
    public partial class GerenciarProduto : Form
    {
        JanelaController janelaController = new JanelaController();
        EntradaController entradaController = new EntradaController();
        ProdutoController produtoController = new ProdutoController();

        ProdutoDTO produto;
        public GerenciarProduto(int idProduto)
        {
            InitializeComponent();
            this.produto = produtoController.selecionarProduto(idProduto);
            inicializarProduto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Boolean resposta = janelaController.mensagemCancelamento();

            if (resposta)
            {
                Dispose();
            }
        }

        private void inicializarProduto()
        {
            txtNome.Text = produto.getNome();
            txtQuantidade.Text = produto.getQuantidade().ToString();
            txtValor.Text = produto.getValor().ToString();
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            entradaController.permitirApenasNumero(e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (produtoController.atualizarProduto(produto.getIdProduto(), txtNome.Text, txtQuantidade.Text, txtValor.Text))
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
