using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Exit();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Boolean resposta = fechar();
            if (!resposta)
            {
                e.Cancel = true;
            }
        }

        private Boolean fechar()
        {
            DialogResult resposta = MessageBox.Show("Tem certeza que desejar sair?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cadCliente = new CadastroCliente();
        }
    }
}
