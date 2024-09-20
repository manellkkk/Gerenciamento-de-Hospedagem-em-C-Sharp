using Hospedagem_em_C_.Model.DAO;
using Hospedagem_em_C_.Model.DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedagem_em_C_.Controller
{
    public class ClienteController
    {
        public Boolean adicionarCliente(String nome, String cpf, String telefone, String placaDoCarro)
        {
            //reconfigura a string, deixando apenas os numeros do telefone
            String somenteNumeroTelefone = Regex.Replace(telefone, @"\D", "");

            //verifica se o nome esta vazio ou o cpf e menor que o esperado
            if (verificarCampoVazio(nome) || cpfInvalido(cpf) || telefoneInvalido(somenteNumeroTelefone))
            {
                MessageBox.Show("Campos invalidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //instancia um objeto do tipo cliente com as informacoes obtidas
            ClienteDTO clienteDTO = new ClienteDTO(nome, cpf, telefone, placaDoCarro);

            ClienteDAO clienteDAO = new ClienteDAO();


            if (clienteDAO.adicionarCliente(clienteDTO))
            {
                MessageBox.Show(clienteDAO.getMensagem(), "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            } else
            {
                MessageBox.Show(clienteDAO.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean atualizarCliente(String cpfAntigo, String nome, String cpf, String telefone, String placaDoCarro)
        {
            //reconfigura a string, deixando apenas os numeros do telefone
            String somenteNumeroTelefone = Regex.Replace(telefone, @"\D", "");

            //verifica se o nome esta vazio ou o cpf e menor que o esperado
            if (verificarCampoVazio(nome) || cpfInvalido(cpf) || telefoneInvalido(somenteNumeroTelefone))
            {
                MessageBox.Show("Campos invalidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //instancia um objeto do tipo cliente com as informacoes obtidas
            ClienteDTO clienteDTO = new ClienteDTO(nome, cpf, telefone, placaDoCarro);

            ClienteDAO clienteDAO = new ClienteDAO();


            if (clienteDAO.atualizarCliente(cpfAntigo, clienteDTO))
            {
                MessageBox.Show(clienteDAO.getMensagem(), "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show(clienteDAO.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private Boolean verificarCampoVazio(String campo)
        {
            if (campo == String.Empty)
            {
                return true;
            }
            return false;
        }

        private Boolean cpfInvalido(String cpf)
        {
            if (cpf.Length < 14)
            {
                return true;
            }
            return false;
        }

        private Boolean telefoneInvalido(String telefone)
        {
            return telefone != String.Empty && telefone.Length < 11;
        }

        public Boolean excluirCliente(String cpf)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            ClienteDTO clienteDTO = clienteDAO.selecionarCliente(cpf);
            

            if (clienteDAO.excluirCliente(clienteDTO))
            {
                MessageBox.Show(clienteDAO.getMensagem(), "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show(clienteDAO.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<ClienteDTO> selecionarTodos()
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            List<ClienteDTO> clientes = clienteDAO.selecionarTodos();
            return clientes;
        }

        public ClienteDTO selecionarCliente(String cpf)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            ClienteDTO cliente = clienteDAO.selecionarCliente(cpf);

            if (cliente == null)
            {
                MessageBox.Show(clienteDAO.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return cliente;
        }
    }
}
