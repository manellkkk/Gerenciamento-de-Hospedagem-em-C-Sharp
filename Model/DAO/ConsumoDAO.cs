using Hospedagem_em_C_.Model.DATABASE;
using Hospedagem_em_C_.Model.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospedagem_em_C_.Model.DAO
{
    public class ConsumoDAO
    {
        private String mensagem;

        public String getMensagem()
        {
            return mensagem;
        }

        public List<ConsumoDTO> selecionarPorHospedagem(int id)
        {
            List<ConsumoDTO> consumos = new List<ConsumoDTO>();
            try
            {
                BancoDeDados.abrirConexao();

                // Define o comando a ser enviado ao banco
                string comandoTexto = "SELECT * FROM consumo WHERE fk_hospedagem = @id";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                comando.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {
                        int idConsumo = leitor.GetInt32("idConsumo");
                        int idProduto = leitor.GetInt32("fk_produto");
                        int quantidade = leitor.GetInt32("quantidade");
                        DateTime dataConsumo = leitor.GetDateTime("dataConsumo");

                        // Cria o objeto ConsumoDTO com os dados do banco
                        ConsumoDTO consumo = new ConsumoDTO(idConsumo, idProduto, id, quantidade, dataConsumo);

                        // Adiciona o consumo à lista
                        consumos.Add(consumo);
                    }
                }
                mensagem = "Seleção realizada com sucesso.";
                return consumos;
            }
            catch (Exception ex)
            {
                mensagem = "Não foi possível realizar a seleção: " + ex.Message;
                return null;
            }
            finally
            {
                BancoDeDados.fecharConexao();
            }
        }

        public Boolean adicionarConsumo(ConsumoDTO consumoDTO)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "INSERT INTO consumo (fk_hospedagem, fk_produto, dataConsumo, quantidade) VALUES (@idHospedagem, @idProduto, @dataConsumo, @quantidade)";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                //substitui os @ do texto e adiciona os valores dentro de clienteDTO como paramentros para serem adicionados
                comando.Parameters.AddWithValue("@idHospedagem", consumoDTO.getHospedagem());
                comando.Parameters.AddWithValue("@idProduto", consumoDTO.getProduto());
                comando.Parameters.AddWithValue("@dataConsumo", consumoDTO.getDataConsumo());
                comando.Parameters.AddWithValue("@quantidade", consumoDTO.getQuantidade());

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

        public Boolean excluirCliente(int id)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "DELETE FROM consumo WHERE idConsumo = @id";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                //substitui os @ do texto e adiciona os valores dentro de clienteDTO como paramentros para serem adicionados
                comando.Parameters.AddWithValue("@id", id);

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

        public ConsumoDTO selecionarConsumo(int id)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "SELECT * FROM consumo WHERE idConsumo = @id";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                comando.Parameters.AddWithValue("@id", id);

                MySqlDataReader leitor = comando.ExecuteReader();

                ConsumoDTO consumo = null;

                if (leitor.Read())
                {
                    int idConsumo = leitor.GetInt32("idConsumo");
                    int idProduto = leitor.GetInt32("fk_produto");
                    int quantidade = leitor.GetInt32("quantidade");
                    DateTime dataConsumo = leitor.GetDateTime("dataConsumo");

                    consumo = new ConsumoDTO(idConsumo, idProduto, id, quantidade, dataConsumo);
                    mensagem = "Seleção realizada com sucesso.";
                }
                else
                {
                    mensagem = "Nenhum cliente encontrado com o CPF fornecido.";
                }

                mensagem = "Seleção realizada com sucesso.";
                return consumo;
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
