using Hospedagem_em_C_.Model.DAO;
using Hospedagem_em_C_.Model.DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hospedagem_em_C_.Controller
{
    public class HospedagemController
    {
        public Boolean adicionarHospedagem(String cpf, String data, String diaria, String quarto)
        {
            String somenteNumeroData = "";
            double valor = 0;
            int numeroQuarto = 0;
            DateTime dataConvertida = DateTime.Today;
            //reconfigura os campos para os formatos corretos
            try
            {
                somenteNumeroData = Regex.Replace(data, @"\D", "");
                valor = double.Parse(diaria);
                numeroQuarto = int.Parse(quarto);
                dataConvertida = DateTime.Parse(data);
            } catch (Exception ex)
            {
                MessageBox.Show("Campos invalidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //verifica se o nome esta vazio ou o cpf e menor que o esperado
            if (verificarCampos(somenteNumeroData, valor, numeroQuarto))
            {
                MessageBox.Show("Campos invalidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //instancia um objeto do tipo hospedagem com as informacoes obtidas
            HospedagemDTO hospedagemDTO = new HospedagemDTO(0, cpf, dataConvertida, null, valor, numeroQuarto);

            HospedagemDAO hospedagemDAO = new HospedagemDAO();


            if (hospedagemDAO.adicionarHospedagem(hospedagemDTO))
            {
                MessageBox.Show(hospedagemDAO.getMensagem(), "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show(hospedagemDAO.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean excluirCliente(int id)
        {
            HospedagemDAO hospedagemDAO = new HospedagemDAO();
            HospedagemDTO hospedagemDTO = hospedagemDAO.selecionarHospedagem(id);


            if (hospedagemDAO.excluirHospedagem(hospedagemDTO))
            {
                MessageBox.Show(hospedagemDAO.getMensagem(), "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show(hospedagemDAO.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public HospedagemDTO selecionarHospedagem(int id)
        {
            HospedagemDAO hospedagemDAO = new HospedagemDAO();
            HospedagemDTO hospedagem = hospedagemDAO.selecionarHospedagem(id);

            if (hospedagem == null)
            {
                MessageBox.Show(hospedagemDAO.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hospedagem;
        }
        public List<HospedagemDTO> selecionarTodos()
        {
            HospedagemDAO hospedagemDAO = new HospedagemDAO();
            List<HospedagemDTO> produtos = hospedagemDAO.selecionarTodos();
            return produtos;
        }

        private Boolean verificarCampos(String data, double valor, int quarto)
        {
            return data.Length < 8 || valor == 0 || verificarCampoVazio(quarto.ToString());
        }

        private Boolean verificarCampoVazio(String campo)
        {
            if (campo == String.Empty)
            {
                return true;
            }
            return false;
        }
    }
}
