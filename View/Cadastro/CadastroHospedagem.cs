using Hospedagem_em_C_.Controller;
using Hospedagem_em_C_.Model.DAO;
using Hospedagem_em_C_.Model.DTO;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedagem_em_C_.View.Cadastro
{
    public partial class CadastroHospedagem : Form
    {
        JanelaController janelaController = new JanelaController();
        EntradaController entradaController = new EntradaController();
        ClienteController clienteController = new ClienteController();
        ClienteDTO cliente;

        public CadastroHospedagem(String cpf)
        {
            InitializeComponent();
            this.cliente = clienteController.selecionarCliente(cpf);
            carregarTabela();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Boolean resposta = janelaController.mensagemCancelamento();

            if (resposta)
            {
                Dispose();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            HospedagemController hospedagemController = new HospedagemController();
            if(hospedagemController.adicionarHospedagem(cliente.getCPF(), txtDataEntrada.Text, txtValor.Text, txtQuarto.Text))
            {
                Dispose();
            }
        }

        private void carregarTabela()
        {
            //instancia uma table para configurar a tabela
            DataTable table = new DataTable();

            //adiciona as colunas da tabela
            table.Columns.Add("Nome", typeof(String));
            table.Columns.Add("CPF", typeof(String));
            table.Columns.Add("Telefone", typeof(String));
            table.Columns.Add("Placa do carro", typeof(String));

            if (cliente != null)  // Verifica se o cliente não está vazio
            {
                table.Rows.Add(cliente.getNome(), cliente.getCPF(), cliente.getTelefone(), cliente.getPlacaDoCarro());
                gvCliente.DataSource = table;
            }
            else
            {
                //se nao houver cliente, esvazia a tabela
                gvCliente.DataSource = null;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            entradaController.formatoPreco(e, txtValor);
        }

        private void txtQuarto_KeyPress(object sender, KeyPressEventArgs e)
        {
            entradaController.permitirApenasNumero(e);
        }

        private void txtDataEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            entradaController.permitirApenasNumero(e);
        }
    }
}
