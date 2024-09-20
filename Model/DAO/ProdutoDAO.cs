using Hospedagem_em_C_.Model.DATABASE;
using Hospedagem_em_C_.Model.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem_em_C_.Model.DAO
{
    public class ProdutoDAO
    {
        private String mensagem;

        public String getMensagem()
        {
            return mensagem;
        }

        public Boolean adicionarProduto(ProdutoDTO produtoDTO)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "INSERT INTO produto (nome, quantidade, valor) VALUES (@nome, @quantidade, @valor)";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                //substitui os @ do texto e adiciona os valores dentro de clienteDTO como paramentros para serem adicionados
                comando.Parameters.AddWithValue("@nome", produtoDTO.getNome());
                comando.Parameters.AddWithValue("@quantidade", produtoDTO.getQuantidade());
                comando.Parameters.AddWithValue("@valor", produtoDTO.getValor());

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

        public List<ProdutoDTO> selecionarPorNome(String nomeConsulta)
        {
            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "SELECT * FROM produto WHERE nome LIKE @nome";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                comando.Parameters.AddWithValue("@nome", "%" + nomeConsulta + "%");

                using (MySqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {

                        //atribui o resultado a variaveis
                        int id = int.Parse(leitor["idProduto"].ToString());
                        String nome = leitor["nome"].ToString();
                        int quantidade = int.Parse(leitor["quantidade"].ToString());
                        double valor = double.Parse(leitor["valor"].ToString(), CultureInfo.InvariantCulture);

                        //cria um produto baseado nas informacoes resgatadas do banco
                        ProdutoDTO produto = new ProdutoDTO(id, nome, quantidade, valor);

                        // Adiciona o cliente à lista
                        produtos.Add(produto);
                    }
                }
                mensagem = "Seleção realizada com sucesso.";
                return produtos;  // Retorna a lista de clientes
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

        public List<ProdutoDTO> selecionarPorID(int idConsulta)
        {
            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "SELECT * FROM produto WHERE idProduto = @id";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                comando.Parameters.AddWithValue("@id", idConsulta);

                using (MySqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {

                        //atribui o resultado a variaveis
                        int id = int.Parse(leitor["idProduto"].ToString());
                        String nome = leitor["nome"].ToString();
                        int quantidade = int.Parse(leitor["quantidade"].ToString());
                        double valor = double.Parse(leitor["valor"].ToString(), CultureInfo.InvariantCulture);

                        //cria um produto baseado nas informacoes resgatadas do banco
                        ProdutoDTO produto = new ProdutoDTO(id, nome, quantidade, valor);

                        // Adiciona o cliente à lista
                        produtos.Add(produto);
                    }
                }
                mensagem = "Seleção realizada com sucesso.";
                return produtos;  // Retorna a lista de clientes
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

        public Boolean alterarQuantidade(ProdutoDTO produtoDTO, int quantidade)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "UPDATE produto SET quantidade = @quantidade WHERE idProduto = @id";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                //substitui os @ do texto e adiciona os valores dentro de clienteDTO como paramentros para serem adicionados
                comando.Parameters.AddWithValue("@quantidade", quantidade);
                comando.Parameters.AddWithValue("@id", produtoDTO.getIdProduto());

                //executa o comando
                comando.ExecuteNonQuery();
                mensagem = "Atualizado com sucesso.";
                return true;
            }
            catch (Exception ex)
            {
                mensagem = "Nao foi possivel alterar: ";
                mensagem += ex.Message;
                return false;
            }
            finally
            {
                BancoDeDados.fecharConexao();
            }
        }

        public Boolean atualizarProduto(ProdutoDTO produto)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "UPDATE produto SET nome = @nome, quantidade = @quantidade, valor = @valor WHERE idProduto = @id";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                //substitui os @ do texto e adiciona os valores dentro de clienteDTO como paramentros para serem adicionados
                comando.Parameters.AddWithValue("@id", produto.getIdProduto());
                comando.Parameters.AddWithValue("@nome", produto.getNome());
                comando.Parameters.AddWithValue("@quantidade", produto.getQuantidade());
                comando.Parameters.AddWithValue("@valor", produto.getValor());

                //executa o comando
                comando.ExecuteNonQuery();
                mensagem = "Atualizado com sucesso.";
                return true;
            }
            catch (Exception ex)
            {
                mensagem = "Nao foi possivel atualizar: ";
                mensagem += ex.Message;
                return false;
            }
            finally
            {
                BancoDeDados.fecharConexao();
            }
        }

        public Boolean excluirProduto(ProdutoDTO produto)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "DELETE FROM produto WHERE idProduto = @id";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                //substitui os @ do texto e adiciona os valores dentro de clienteDTO como paramentros para serem adicionados
                comando.Parameters.AddWithValue("@id", produto.getIdProduto());

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

        public List<ProdutoDTO> selecionarTodos()
        {
            List<ProdutoDTO> produtos = new List<ProdutoDTO>();
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "SELECT * FROM produto";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                using (MySqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        //atribui o resultado a variaveis
                        int id = int.Parse(leitor["idProduto"].ToString());
                        String nome = leitor["nome"].ToString();
                        int quantidade = int.Parse(leitor["quantidade"].ToString());
                        double valor = double.Parse(leitor["valor"].ToString(), CultureInfo.InvariantCulture);

                        //cria um produto baseado nas informacoes resgatadas do banco
                        ProdutoDTO produto = new ProdutoDTO(id, nome, quantidade, valor);

                        // Adiciona o produto à lista de produtos
                        produtos.Add(produto);
                    }
                }
                mensagem = "Seleção realizada com sucesso.";
                return produtos;  // Retorna a lista de produtos
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

        public ProdutoDTO selecionarProduto(int id)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "SELECT * FROM produto WHERE idProduto = @idProduto";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                comando.Parameters.AddWithValue("@idProduto", id);

                MySqlDataReader leitor = comando.ExecuteReader();

                ProdutoDTO produto = null;

                if (leitor.Read())
                {
                    String nome = leitor["nome"].ToString();
                    int quantidade = int.Parse(leitor["quantidade"].ToString());
                    double valor = double.Parse(leitor["valor"].ToString(), CultureInfo.InvariantCulture);

                    produto = new ProdutoDTO(id, nome, quantidade, valor);
                    mensagem = "Seleção realizada com sucesso.";
                }
                else
                {
                    mensagem = "Nenhum cliente encontrado com o CPF fornecido.";
                }

                mensagem = "Seleção realizada com sucesso.";
                return produto;
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
