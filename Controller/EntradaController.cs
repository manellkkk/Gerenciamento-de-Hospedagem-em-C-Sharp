using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem_em_C_.Controller
{
    public class EntradaController
    {
        //classe que serve para configurações de entradas em textbox
        public void permitirApenasLetras(KeyPressEventArgs e)
        {
            // Permite apenas letras e controle (como backspace)
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloqueia o caractere
            }
        }
        public void permitirApenasNumero(KeyPressEventArgs e)
        {
            // Permite apenas números e Backspace
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloqueia o caractere
            }
        }
    }
}
