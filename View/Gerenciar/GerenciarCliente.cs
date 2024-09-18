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

namespace Hospedagem_em_C_.View.Gerenciar
{
    public partial class GerenciarCliente : Form
    {
        JanelaController janelaController = new JanelaController();
        EntradaController entradaController = new EntradaController();
        public GerenciarCliente()
        {
            InitializeComponent();
            inicializarCliente();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Boolean resposta = janelaController.mensagemCancelamento();
            if (resposta)
            {
                Dispose();
            }
        }

        private void inicializarCliente()
        {

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
    }
}
