using Hospedagem_em_C_.Controller;
using Hospedagem_em_C_.Model.DTO;
using Hospedagem_em_C_.View.Gerenciar;
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
    public partial class ConsultaHospedagem : Form
    {
        EntradaController entradaController = new EntradaController();
        HospedagemController hospedagemController = new HospedagemController();
        GerenciarHospedagem genHospedagem = null;
        public ConsultaHospedagem()
        {
            InitializeComponent();
            inicializarSelecionarPor();
            carregarTabelaHospedagem();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Dispose();
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
                return "Quarto";
            }
        }
        private void inicializarSelecionarPor()
        {

            //inicia a combo box com o campo nome selecionado
            cbSelecionar.SelectedIndex = 0;
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

        private void tpbEditar_Click(object sender, EventArgs e)
        {
            //seleciona o id da hospedagem, da linha selecionada
            int id = idLinhaSelecionada();

            //verifica se tem linha selecionada
            if (id == 0)
            {
                MessageBox.Show("Nao ha linha selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //abre a janela para editar cliente
            genHospedagem = new GerenciarHospedagem(id);

            genHospedagem.FormClosed += gerenciarFechado;

            genHospedagem.Show();
        }
        private void gerenciarFechado(object sender, FormClosedEventArgs e)
        {
            carregarTabelaHospedagem();
        }

        private void carregarTabelaHospedagem()
        {
            List<HospedagemDTO> hospedagens = hospedagemController.selecionarTodos();
            carregarTabela(hospedagens);
        }

        private void carregarTabela(List<HospedagemDTO> hospedagens)
        {
            //instancia uma table para configurar a tabela
            DataTable table = new DataTable();

            //adiciona as colunas da tabela
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Cliente", typeof(String));
            table.Columns.Add("Data de entrada", typeof(DateTime));
            table.Columns.Add("Data de saida", typeof(DateTime));
            table.Columns.Add("Quarto", typeof(int));
            table.Columns.Add("Valor", typeof(double));

            //adiciona as linhas de hospedagens presentes no banco
            if (hospedagens != null && hospedagens.Count > 0)  // Verifica se a lista não está vazia
            {
                foreach (HospedagemDTO hospedagem in hospedagens) //percorre a lista de clientes
                {
                    //adiciona cada hospedagem a tabela
                    table.Rows.Add(hospedagem.getHospedagem(), hospedagem.getCliente(), hospedagem.getDataEntrada(), hospedagem.getDataSaida(), hospedagem.getQuarto(), hospedagem.getValor());
                }
                //por fim, atribui esse modelo de tabela ao gridview
                gvHospedagem.DataSource = table;
            }
            else
            {
                //se nao houver hospedagens, esvazia a tabela
                gvHospedagem.DataSource = null;
            }
        }

        private void tpExcluir_Click(object sender, EventArgs e)
        {
            //seleciona o id da hospedage, da linha selecionada
            int id = idLinhaSelecionada();

            //verifica se tem linha selecionada
            if (id == 0)
            {
                MessageBox.Show("Nao ha linha selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //se der tudo certo ao excluir, atualiza a tabela
            if (hospedagemController.excluirCliente(id))
            {
                carregarTabelaHospedagem();
            }
        }

        private int idLinhaSelecionada()
        {
            // Verifica se há uma linha selecionada
            if (gvHospedagem.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = gvHospedagem.SelectedRows[0];

                // seleciona o que estiver no cpf da linha
                int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                gvHospedagem.ClearSelection();
                return id;
            }
            gvHospedagem.ClearSelection();
            return 0;
        }

        private void rdTodos_CheckedChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void rdAberto_CheckedChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void filtrar()
        {
            if (rdTodos.Checked)
            {
                carregarTabelaHospedagem();
            }
            else
            {
                List<HospedagemDTO> hospedagens = hospedagemController.selecionarEmAberto();
                carregarTabela(hospedagens);
            }
        }
    }
}
