using Hospedagem_em_C_.Controller;
using Hospedagem_em_C_.Model.DTO;
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
    public partial class GerenciarConsumo : Form
    {
        private int idHospedagem;
        private ProdutoController produtoController = new ProdutoController();
        private EntradaController entradaController = new EntradaController();
        private JanelaController janelaController = new JanelaController();
        private ProdutoDTO produtoDTO;

        public GerenciarConsumo(int idHospedagem, int idProduto)
        {
            InitializeComponent();
            this.idHospedagem = idHospedagem;
            this.produtoDTO = produtoController.selecionarProduto(idProduto);
            carregarTabelaProduto();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            ConsumoController consumoController = new ConsumoController();
            if(consumoController.adicionarConsumo(idHospedagem, produtoDTO.getIdProduto(), txtQuantidade.Text))
            {
                this.Close();
            }
        }

        private void carregarTabelaProduto()
        {
            //instancia uma table para configurar a tabela
            DataTable table = new DataTable();

            //adiciona as colunas da tabela
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nome", typeof(String));
            table.Columns.Add("Quantidade", typeof(int));
            table.Columns.Add("Valor", typeof(double));

            //adiciona as linhas de clientes presentes no banco
            if (produtoDTO != null)  // Verifica se a lista não está vazia
            {
                table.Rows.Add(produtoDTO.getIdProduto(), produtoDTO.getNome(), produtoDTO.getQuantidade(), produtoDTO.getValor());
                //por fim, atribui esse modelo de tabela ao gridview
                gvProduto.DataSource = table;
            }
            else
            {
                //se nao houver cadastros, esvazia a tabela
                gvProduto.DataSource = null;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            entradaController.permitirApenasNumero(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Boolean resposta = janelaController.mensagemCancelamento();
            if (resposta)
            {
                Dispose();
            }
        }
    }
}
