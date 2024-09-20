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
using System.Collections;
using Hospedagem_em_C_.Model.DTO;
using MySqlX.XDevAPI.Relational;

namespace Hospedagem_em_C_.View.Consulta
{
    public partial class ConsultaCliente : Form
    {
        ClienteController clienteController = new ClienteController();
        EntradaController entradaController = new EntradaController();

        private String janelaOrigem;
        private GerenciarCliente genCliente;
        private CadastroCliente cadCliente;
        private CadastroHospedagem cadHospedagem;
        
        public ConsultaCliente(String janelaOrigem)
        {
            InitializeComponent();
            this.janelaOrigem = janelaOrigem;
            inicializarSelecionarPor();
            inicializarBotaoSelecionar();
            carregarTabelaCliente();
        }

        private void tpbNovo_Click(object sender, EventArgs e)
        {
            //abre janela de cadastro de cliente
            cadCliente = new CadastroCliente();

            //assim que a janela cadastro for fechada, executa o gerenciarFechado e atualiza a tabela
            cadCliente.FormClosed += gerenciarFechado;

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
                //seleciona o cpf da linha selecionada
                String cpf = cpfLinhaSelecionada();

                //verifica se tem linha selecionada
                if (cpf == null)
                {
                    MessageBox.Show("Nao ha linha selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //abre a janela para editar cliente
                cadHospedagem = new CadastroHospedagem(cpf);
                cadHospedagem.Show();
                Dispose();
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
            //configuracao de entrada do txtConsulta
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
            //se nao for aberta da janela cadastro hospedagem, esse botao vai executar o fechar da janela (texto do botao muda para "fechar")
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
            //seleciona o cpf da linha selecionada
            String cpf = cpfLinhaSelecionada();

            //verifica se tem linha selecionada
            if (cpf == null)
            {
                MessageBox.Show("Nao ha linha selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //abre a janela para editar cliente
            genCliente = new GerenciarCliente(cpf);


            //assim que a janela gerenciar for fechada, executa o gerenciarFechado e atualiza a tabela
            genCliente.FormClosed += gerenciarFechado;

            genCliente.Show();
        }

        private void gerenciarFechado(object sender, FormClosedEventArgs e)
        {
            carregarTabelaCliente();
        }

        private void carregarTabelaCliente()
        {
            List<ClienteDTO> clientes = clienteController.selecionarTodos();
            carregarTabela(clientes);
        }

        private void carregarTabela(List<ClienteDTO> clientes)
        {
            //instancia uma table para configurar a tabela
            DataTable table = new DataTable();

            //adiciona as colunas da tabela
            table.Columns.Add("Nome", typeof(String));
            table.Columns.Add("CPF", typeof(String));
            table.Columns.Add("Telefone", typeof(String));
            table.Columns.Add("Placa do carro", typeof(String));

            //adiciona as linhas de clientes presentes no banco
            if (clientes != null && clientes.Count > 0)  // Verifica se a lista não está vazia
            {
                foreach (ClienteDTO cliente in clientes) //percorre a lista de clientes
                {
                    //adiciona cada cliente a tabela
                    table.Rows.Add(cliente.getNome(), cliente.getCPF(), cliente.getTelefone(), cliente.getPlacaDoCarro());
                }
                //por fim, atribui esse modelo de tabela ao gridview
                gvCliente.DataSource = table;
            }
            else
            {
                //se nao houver cadastros, esvazia a tabela
                gvCliente.DataSource= null;
            }
        }

        private String cpfLinhaSelecionada()
        {
            // Verifica se há uma linha selecionada
            if (gvCliente.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = gvCliente.SelectedRows[0];

                // seleciona o que estiver no cpf da linha
                String cpf = selectedRow.Cells[1].Value.ToString();
                gvCliente.ClearSelection();
                return cpf;
            }
            gvCliente.ClearSelection();
            return null;
        }

        private void tpExcluir_Click(object sender, EventArgs e)
        {
            //seleciona o cpf da linha selecionada
            String cpf = cpfLinhaSelecionada();

            //verifica se tem linha selecionada
            if (cpf == null)
            {
                MessageBox.Show("Nao ha linha selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //se der tudo certo ao excluir, atualiza a tabela
            if(clienteController.excluirCliente(cpf))
            {
                carregarTabelaCliente();
            }
        }
    }
}
