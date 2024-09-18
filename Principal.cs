using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospedagem_em_C_.View.Cadastro;
using Hospedagem_em_C_.View.Consulta;

namespace Hospedagem_em_C_
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //tenta fechar aplicação
            Application.Exit();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //verifica a resposta para decidir se cancela a operação de fechar
            Boolean resposta = fechar();
            if (!resposta)
            {
                e.Cancel = true;
            }
        }

        private Boolean fechar()
        {
            //exibe mensagem para confirmar encerramento do programa
            DialogResult resposta = MessageBox.Show("Tem certeza que desejar sair?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        public Principal getPrincipal()
        {
            return this;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abre janela de cadastro de cliente
            CadastroCliente cadCliente = new CadastroCliente();
            cadCliente.MdiParent = this;
            cadCliente.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abre janela de cadastro de produto
            CadastroProduto cadProduto = new CadastroProduto();
            cadProduto.MdiParent = this;
            cadProduto.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //abre janela de consulta de cliente
            ConsultaCliente conCliente = new ConsultaCliente("Consulta");
            conCliente.MdiParent = this;
            conCliente.Show();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //abre janela de consulta de produto
            ConsultaProduto conProduto = new ConsultaProduto();
            conProduto.MdiParent = this;
            conProduto.Show();
        }

        private void hospedagemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //abre janela de consulta de hospedagem
            ConsultaHospedagem conHospedagem = new ConsultaHospedagem();
            conHospedagem.MdiParent = this;
            conHospedagem.Show();
        }

        private void hospedagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abre janela de consulta de cliente
            ConsultaCliente conCliente = new ConsultaCliente("Cadastro");
            conCliente.MdiParent = this;
            conCliente.Show();
        }
    }
}