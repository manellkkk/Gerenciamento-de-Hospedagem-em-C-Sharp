using Hospedagem_em_C_.Controller;
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
using Hospedagem_em_C_.Model.DTO;
using Hospedagem_em_C_.View.Consulta;

namespace Hospedagem_em_C_.View.Gerenciar
{
    public partial class GerenciarCliente : Form
    {
        JanelaController janelaController = new JanelaController();
        EntradaController entradaController = new EntradaController();
        ClienteController clienteController = new ClienteController();

        ClienteDTO cliente;
        public GerenciarCliente(String cpfCliente)
        {
            InitializeComponent();
            this.cliente = clienteController.selecionarCliente(cpfCliente);
            inicializarCliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Boolean resposta = janelaController.mensagemCancelamento();
            if (resposta)
            {
                this.Close();
            }
        }

        private void inicializarCliente()
        {
            txtNome.Text = cliente.getNome();
            txtCPF.Text = cliente.getCPF();
            txtTelefone.Text = cliente.getTelefone();
            txtPlacaDoCarro.Text = cliente.getPlacaDoCarro();
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            entradaController.permitirApenasLetras(e);
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            entradaController.permitirApenasNumero(e);
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            entradaController.permitirApenasNumero(e);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (clienteController.atualizarCliente(cliente.getCPF(), txtNome.Text, txtCPF.Text, txtTelefone.Text, txtPlacaDoCarro.Text))
            {
                this.Close();
            }
        }
    }
}
