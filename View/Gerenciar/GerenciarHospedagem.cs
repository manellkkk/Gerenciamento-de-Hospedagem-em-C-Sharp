using Hospedagem_em_C_.Controller;
using Hospedagem_em_C_.Model.DAO;
using Hospedagem_em_C_.Model.DTO;
using Hospedagem_em_C_.View.Consulta;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedagem_em_C_.View.Gerenciar
{
    public partial class GerenciarHospedagem : Form
    {
        HospedagemController hospedagemController = new HospedagemController();
        ConsumoController consumoController = new ConsumoController();
        HospedagemDTO hospedagemDTO;
        public GerenciarHospedagem(int id)
        {
            InitializeComponent();
            this.hospedagemDTO = hospedagemController.selecionarHospedagem(id);
            carregarTabelaHospedagem();
            carregarTabelaConsumo();
            verificarFinalizar();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void verificarFinalizar()
        {
            if (hospedagemDTO.getDataSaida() != null)
            {
                btnFinalizar.Enabled = false;
                btnAdicionar.Enabled = false;
                btnRemover.Enabled = false;
            }
        }

        private void carregarTabelaHospedagem()
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

            //adiciona as linhas de clientes presentes no banco
            if (hospedagemDTO != null)  // Verifica se a lista não está vazia
            {
                table.Rows.Add(hospedagemDTO.getHospedagem(), hospedagemDTO.getCliente(), hospedagemDTO.getDataEntrada(), hospedagemDTO.getDataSaida(), hospedagemDTO.getQuarto(), hospedagemDTO.getValor());
                gvHospedagem.DataSource = table;
            }
            else
            {
                //se nao houver cadastros, esvazia a tabela
                gvHospedagem.DataSource = null;
            }
        }

        private void carregarTabelaConsumo()
        {
            List<ConsumoDTO> consumos = consumoController.selecionarPorHospedagem(hospedagemDTO.getHospedagem());
            //instancia uma table para configurar a tabela
            DataTable table = new DataTable();

            //adiciona as colunas da tabela
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Produto", typeof(String));
            table.Columns.Add("Hospedagem", typeof(int));
            table.Columns.Add("Data do consumo", typeof(DateTime));
            table.Columns.Add("Quantidade", typeof(int));
            table.Columns.Add("Valor total", typeof(double));

            ProdutoController produtoController = new ProdutoController();

            //adiciona as linhas de clientes presentes no banco
            if (consumos != null && consumos.Count > 0)  // Verifica se a lista não está vazia
            {
                foreach (ConsumoDTO consumo in consumos) //percorre a lista de clientes
                {
                    ProdutoDTO produtoDTO = produtoController.selecionarProduto(consumo.getProduto());
                    //adiciona cada cliente a tabela
                    table.Rows.Add(consumo.getConsumo(), produtoDTO.getNome(), consumo.getHospedagem(), consumo.getDataConsumo(), consumo.getQuantidade(), consumo.getQuantidade() * produtoDTO.getValor());
                }
                //por fim, atribui esse modelo de tabela ao gridview
                gvConsumo.DataSource = table;
            }
            else
            {
                //se nao houver cadastros, esvazia a tabela
                gvConsumo.DataSource = null;
            }
        }
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            hospedagemDTO.setDataSaida(DateTime.Today);
            hospedagemController.finalizarHospedagem(hospedagemDTO);
            carregarTabelaHospedagem();
            btnFinalizar.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ConsultaProduto consultaProduto = new ConsultaProduto(hospedagemDTO.getHospedagem());
            consultaProduto.FormClosed += consultaFechada;
            consultaProduto.Show();
        }
        private void consultaFechada(object sender, FormClosedEventArgs e)
        {
            carregarTabelaConsumo();
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            //seleciona o cpf da linha selecionada
            int idConsumo = idLinhaSelecionada();

            //verifica se tem linha selecionada
            if (idConsumo == 0)
            {
                MessageBox.Show("Nao ha linha selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //se der tudo certo ao excluir, atualiza a tabela
            if (consumoController.excluirConsumo(idConsumo))
            {
                carregarTabelaConsumo();
            }
        }

        private int idLinhaSelecionada()
        {
            // Verifica se há uma linha selecionada
            if (gvConsumo.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = gvConsumo.SelectedRows[0];

                // seleciona o que estiver no cpf da linha
                int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                gvConsumo.ClearSelection();
                return id;
            }
            gvConsumo.ClearSelection();
            return 0;
        }
    }
}
