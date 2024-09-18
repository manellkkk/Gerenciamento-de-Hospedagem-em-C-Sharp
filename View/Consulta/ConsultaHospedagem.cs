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

namespace Hospedagem_em_C_.View.Consulta
{
    public partial class ConsultaHospedagem : Form
    {
        EntradaController entradaController = new EntradaController();
        public ConsultaHospedagem()
        {
            InitializeComponent();
            inicializarSelecionarPor();
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

        }
    }
}
