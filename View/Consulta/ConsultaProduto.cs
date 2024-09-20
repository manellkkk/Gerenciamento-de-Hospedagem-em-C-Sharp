using Hospedagem_em_C_.Controller;
using Hospedagem_em_C_.Model.DTO;
using Hospedagem_em_C_.View.Cadastro;
using Hospedagem_em_C_.View.Gerenciar;
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
using System.Windows.Forms.VisualStyles;

namespace Hospedagem_em_C_.View.Consulta
{
    public partial class ConsultaProduto : Form
    {
        EntradaController entradaController = new EntradaController();
        ProdutoController produtoController = new ProdutoController();
        int idHospedagem = 0;

        GerenciarProduto genProduto = null;
        public ConsultaProduto(int idHospedagem)
        {
            InitializeComponent();
            this.idHospedagem = idHospedagem;
            inicializarComponentes();
            carregarTabelaProduto();
        }
        private void inicializarComponentes()
        {
            //inicia a combo box com o campo nome selecionado
            cbSelecionar.SelectedIndex = 0;

            if (verificarOrigem())
            {
                btnFechar.Text = "Selecionar";
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
                return "ID";
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (verificarSelecao() == "Nome")
            {
                carregarTabela(produtoController.selecionarPorNome(txtConsulta.Text));
            }
            else
            {
                carregarTabela(produtoController.selecionarPorID(txtConsulta.Text));
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            if (verificarOrigem())
            {
                //seleciona o cpf da linha selecionada
                int id = idLinhaSelecionada();

                //verifica se tem linha selecionada
                if (id == 0)
                {
                    MessageBox.Show("Nao ha linha selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                GerenciarConsumo gerenciarConsumo = new GerenciarConsumo(idHospedagem, id);
                gerenciarConsumo.FormClosed += consumoFechado;
                gerenciarConsumo.Show();
            }
            else
            {
                Dispose();
            }
        }

        private void consumoFechado(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }


        private Boolean verificarOrigem()
        {
            return idHospedagem != 0;
        }

        private void tpbNovo_Click(object sender, EventArgs e)
        {
            //abre janela de cadastro de produto
            CadastroProduto cadProduto = new CadastroProduto();

            //assim que a janela cadastro for fechada, executa o gerenciarFechado e atualiza a tabela
            cadProduto.FormClosed += gerenciarFechado;

            cadProduto.Show();
        }
        private void gerenciarFechado(object sender, FormClosedEventArgs e)
        {
            carregarTabelaProduto();
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

        private void tpbEditar_Click(object sender, EventArgs e)
        {
            //seleciona o cpf da linha selecionada
            int id = idLinhaSelecionada();

            //verifica se tem linha selecionada
            if (id == 0)
            {
                MessageBox.Show("Nao ha linha selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //abre a janela para editar cliente
            genProduto = new GerenciarProduto(id);


            //assim que a janela gerenciar for fechada, executa o gerenciarFechado e atualiza a tabela
            genProduto.FormClosed += gerenciarFechado;

            genProduto.Show();
        }

        private int idLinhaSelecionada()
        {
            // Verifica se há uma linha selecionada
            if (gvProduto.SelectedRows.Count > 0)
            {
                // Obtém a linha selecionada
                DataGridViewRow selectedRow = gvProduto.SelectedRows[0];

                // seleciona o que estiver no cpf da linha
                int id = int.Parse(selectedRow.Cells[0].Value.ToString());
                gvProduto.ClearSelection();
                return id;
            }
            gvProduto.ClearSelection();
            return 0;
        }
        private void carregarTabelaProduto()
        {
            List<ProdutoDTO> produtos = produtoController.selecionarTodos();
            carregarTabela(produtos);
        }

        private void carregarTabela(List<ProdutoDTO> produtos)
        {
            //instancia uma table para configurar a tabela
            DataTable table = new DataTable();

            //adiciona as colunas da tabela
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(String));
            table.Columns.Add("Quantidade", typeof(int));
            table.Columns.Add("Valor", typeof(double));

            //adiciona as linhas de clientes presentes no banco
            if (produtos != null && produtos.Count > 0)  // Verifica se a lista não está vazia
            {
                foreach (ProdutoDTO produto in produtos) //percorre a lista de clientes
                {
                    //adiciona cada cliente a tabela
                    table.Rows.Add(produto.getIdProduto(), produto.getNome(), produto.getQuantidade(), produto.getValor());
                }
                //por fim, atribui esse modelo de tabela ao gridview
                gvProduto.DataSource = table;
            }
            else
            {
                //se nao houver cadastros, esvazia a tabela
                gvProduto.DataSource = null;
            }
        }

        private void tpExcluir_Click(object sender, EventArgs e)
        {
            //seleciona o cpf da linha selecionada
            int id = idLinhaSelecionada();

            //verifica se tem linha selecionada
            if (id == 0)
            {
                MessageBox.Show("Nao ha linha selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //se der tudo certo ao excluir, atualiza a tabela
            if (produtoController.excluirProduto(id))
            {
                carregarTabelaProduto();
            }
        }
    }
}
