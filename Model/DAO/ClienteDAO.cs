using Hospedagem_em_C_.Model.DATABASE;
using Hospedagem_em_C_.Model.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem_em_C_.Model.DAO
{
    public class ClienteDAO
    {
        private String mensagem;

        public String getMensagem()
        {
            return mensagem;
        }

        public Boolean adicionarCliente(ClienteDTO clienteDTO)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "INSERT INTO cliente (nome, cpf, telefone, placaDoCarro) VALUES (@nome, @cpf, @telefone, @placaDoCarro)";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                //substitui os @ do texto e adiciona os valores dentro de clienteDTO como paramentros para serem adicionados
                comando.Parameters.AddWithValue("@nome", clienteDTO.getNome());
                comando.Parameters.AddWithValue("@cpf", clienteDTO.getCPF());
                comando.Parameters.AddWithValue("@telefone", clienteDTO.getTelefone());
                comando.Parameters.AddWithValue("@placaDoCarro", clienteDTO.getPlacaDoCarro());

                //executa o comando
                comando.ExecuteNonQuery();
                mensagem = "Adicionado com sucesso.";
                return true;
            }
            catch (Exception ex)
            {
                mensagem = "Nao foi possivel inserir: ";
                mensagem += ex.Message;
                return false;
            }
            finally
            {
                BancoDeDados.fecharConexao();
            }
        }

        public Boolean excluirCliente(ClienteDTO clienteDTO)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "DELETE FROM cliente WHERE cpf = @cpf";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                //substitui os @ do texto e adiciona os valores dentro de clienteDTO como paramentros para serem adicionados
                comando.Parameters.AddWithValue("@cpf", clienteDTO.getCPF());

                //executa o comando
                comando.ExecuteNonQuery();
                mensagem = "Excluido com sucesso.";
                return true;
            }
            catch (Exception ex)
            {
                mensagem = "Nao foi possivel excluir: ";
                mensagem += ex.Message;
                return false;
            }
            finally
            {
                BancoDeDados.fecharConexao();
            }
        }

        public Boolean atualizarCliente(String cpf, ClienteDTO clienteDTO)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "UPDATE cliente SET nome = @nome, cpf = @novocpf, telefone = @telefone, placaDoCarro = @placaDoCarro WHERE cpf = @cpf";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                //substitui os @ do texto e adiciona os valores dentro de clienteDTO como paramentros para serem adicionados
                comando.Parameters.AddWithValue("@nome", clienteDTO.getNome());
                comando.Parameters.AddWithValue("@novocpf", clienteDTO.getCPF());
                comando.Parameters.AddWithValue("@telefone", clienteDTO.getTelefone());
                comando.Parameters.AddWithValue("@placaDoCarro", clienteDTO.getPlacaDoCarro());
                comando.Parameters.AddWithValue("@cpf", cpf);

                //executa o comando
                comando.ExecuteNonQuery();
                mensagem = "Atualizado com sucesso.";
                return true;
            }
            catch (Exception ex)
            {
                mensagem = "Nao foi possivel inserir: ";
                mensagem += ex.Message;
                return false;
            }
            finally
            {
                BancoDeDados.fecharConexao();
            }
        }

        public List<ClienteDTO> selecionarTodos()
        {
            List<ClienteDTO> clientes = new List<ClienteDTO>();
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "SELECT * FROM cliente";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                using (MySqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {

                        // Supondo que você tenha esses métodos de get/set na classe ClienteDTO
                        String nome = leitor["nome"].ToString();
                        String cpf = leitor["cpf"].ToString();
                        String telefone = leitor["telefone"].ToString();
                        String placaDoCarro = leitor["placaDoCarro"].ToString();

                        ClienteDTO cliente = new ClienteDTO(nome, cpf, telefone, placaDoCarro);

                        // Adiciona o cliente à lista
                        clientes.Add(cliente);
                    }
                }
                mensagem = "Seleção realizada com sucesso.";
                return clientes;  // Retorna a lista de clientes
            }
            catch (Exception ex)
            {
                mensagem = "Nao foi possivel inserir: ";
                mensagem += ex.Message;
                return null;
            }
            finally
            {
                BancoDeDados.fecharConexao();
            }
        }

        public ClienteDTO selecionarCliente(String cpf)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "SELECT * FROM cliente WHERE cpf = @cpf";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                comando.Parameters.AddWithValue("@cpf", cpf);

                MySqlDataReader leitor = comando.ExecuteReader();

                ClienteDTO cliente = null;

                if (leitor.Read())
                {
                    String nome = leitor["nome"].ToString();
                    String telefone = leitor["telefone"].ToString();
                    String placaDoCarro = leitor["placaDoCarro"].ToString();

                    cliente = new ClienteDTO(nome, cpf, telefone, placaDoCarro);
                    mensagem = "Seleção realizada com sucesso.";
                }
                else
                {
                    mensagem = "Nenhum cliente encontrado com o CPF fornecido.";
                }

                mensagem = "Seleção realizada com sucesso.";
                return cliente;
            }
            catch (Exception ex)
            {
                mensagem = "Nao foi possivel selecionar: ";
                mensagem += ex.Message;
                return null;
            }
            finally
            {
                BancoDeDados.fecharConexao();
            }
        }
    }
}
