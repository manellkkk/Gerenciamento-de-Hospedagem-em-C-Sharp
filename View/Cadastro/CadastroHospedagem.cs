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

namespace Hospedagem_em_C_.View.Cadastro
{
    public partial class CadastroHospedagem : Form
    {
        JanelaController janelaController = new JanelaController();
        EntradaController entradaController = new EntradaController();
        public CadastroHospedagem()
        {
            InitializeComponent();
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
