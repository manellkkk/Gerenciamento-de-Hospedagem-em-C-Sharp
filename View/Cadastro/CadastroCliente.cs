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

namespace Hospedagem_em_C_.View.Cadastro
{
    public partial class CadastroCliente : Form
    {
        EntradaController entradaController = new EntradaController();
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ClienteController clienteController = new ClienteController();

            //tenta adicionar o cliente. se der certo, fecha a janela
            if (clienteController.adicionarCliente(txtNome.Text, txtCPF.Text, txtTelefone.Text, txtPlacaDoCarro.Text))
            {
                this.Close();
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void txtTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            entradaController.permitirApenasNumero(e);
        }

        private void txtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            entradaController.permitirApenasNumero(e);
        }

        private void chkTelefone_CheckedChanged(object sender, EventArgs e)
        {
            txtTelefone.Text = String.Empty;
            if (chkTelefone.Checked)
            {
                txtTelefone.Enabled = true;
            }
            else
            {
                txtTelefone.Enabled = false;
            }
        }

        private void chkPlacaDoCarro_CheckedChanged(object sender, EventArgs e)
        {
            txtPlacaDoCarro.Text = String.Empty;
            if (chkPlacaDoCarro.Checked)
            {
                txtPlacaDoCarro.Enabled = true;
            }
            else
            {
                txtPlacaDoCarro.Enabled = false;
            }
        }
    }
}
