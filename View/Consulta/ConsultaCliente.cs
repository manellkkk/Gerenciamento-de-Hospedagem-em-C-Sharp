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
using Hospedagem_em_C_.Controller;
using Hospedagem_em_C_.View.Gerenciar;

namespace Hospedagem_em_C_.View.Consulta
{
    public partial class ConsultaCliente : Form
    {
        ClienteController clienteController = new ClienteController();
        EntradaController entradaController = new EntradaController();

        private String janelaOrigem;
        public ConsultaCliente(String janelaOrigem)
        {
            InitializeComponent();
            this.janelaOrigem = janelaOrigem;
            inicializarSelecionarPor();
            inicializarBotaoSelecionar();
        }

        private void tpbNovo_Click(object sender, EventArgs e)
        {
            //abre janela de cadastro de cliente
            CadastroCliente cadCliente = new CadastroCliente();
            cadCliente.Show();
        }

        private void cbSelecionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (verificarSelecao() == "Nome")
            {
                //se for selecionado por nome, define o formato para nenhum
                txtConsulta.Text = String.Empty;
                txtConsulta.Mask = null;
            }
            else
            {
                //se for selecionado por cpf, aplica o formato do cpf
                txtConsulta.Text = String.Empty;
                txtConsulta.Mask = "000\\.000\\.000-00";
            }
        }

        private void inicializarSelecionarPor()
        {

            //inicia a combo box com o campo nome selecionado
            cbSelecionar.SelectedIndex = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (isSelecionar())
            {

            }
            else
            {
                Dispose();
            }
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
                return "CPF";
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

        private void inicializarBotaoSelecionar()
        {

            if (!isSelecionar())
            {
                btnSelecionar.Text = "Fechar";
            }
        }

        private Boolean isSelecionar()
        {
            //verifica a janela que abriu a consulta de cliente
            if (janelaOrigem == "Consulta")
            {
                //se é para consulta, significa que o botão não é de selecionar
                return false;
            }
            return true;
        }

        private void tpbEditar_Click(object sender, EventArgs e)
        {
            //abre a janela para editar cliente
            GerenciarCliente genCliente = new GerenciarCliente();
            genCliente.Show();
        }
    }
}
