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

        public void formatoPreco(KeyPressEventArgs e, TextBox txtPreco)
        {
            // permite o backspace
            if (char.IsControl(e.KeyChar))
            {
                return;
            }

            // permite somente 1 ponto e digitos
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
                return;
            }

            // permite somente 1 ponto
            if (e.KeyChar == ',' && txtPreco.Text.Contains(','))
            {
                e.Handled = true;
                return;
            }

            // permite apenas duas casas apos o ponto
            int decimalIndex = txtPreco.Text.IndexOf(',');
            if (decimalIndex != -1)
            {
                int decimalPlaces = txtPreco.Text.Length - decimalIndex - 1;
                if (decimalPlaces >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }
        }
    }
}
