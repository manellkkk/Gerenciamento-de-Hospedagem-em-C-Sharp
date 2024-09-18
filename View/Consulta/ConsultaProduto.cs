using Hospedagem_em_C_.Controller;
using Hospedagem_em_C_.View.Cadastro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedagem_em_C_.View.Consulta
{
    public partial class ConsultaProduto : Form
    {
        EntradaController entradaController = new EntradaController();
        public ConsultaProduto()
        {
            InitializeComponent();
            inicializarSelecionarPor();
        }
        private void inicializarSelecionarPor()
        {

            //inicia a combo box com o campo nome selecionado
            cbSelecionar.SelectedIndex = 0;
        }

        private String verificarSelecao()
        {
            //verifica o campo selecionado
            if (cbSelecionar.SelectedItem.ToString() == "Nome")
            {
                return "Nome";
            }
            else
            {
                return "ID";
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (verificarSelecao() == "Nome")
            {

            }
            else
            {

            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void tpbNovo_Click(object sender, EventArgs e)
        {
            //abre janela de cadastro de produto
            CadastroProduto cadProduto = new CadastroProduto();
            cadProduto.Show();
        }

        private void txtConsulta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (verificarSelecao() == "Nome")
            {
                entradaController.permitirApenasLetras(e);
            }
            else
            {
                entradaController.permitirApenasNumero(e);
            }
        }
    }
}
