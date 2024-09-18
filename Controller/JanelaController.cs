using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem_em_C_.Controller
{
    public class JanelaController
    {
        //classe que serve para configurações de janelas
        public Boolean mensagemCancelamento()
        {
            //exibe mensagem para confirmar cancelamento
            DialogResult resposta = MessageBox.Show("Tem certeza que desejar cancelar?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resposta == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
    }
}
