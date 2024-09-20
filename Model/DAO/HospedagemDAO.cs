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
    public class HospedagemDAO
    {
        private String mensagem;

        public String getMensagem()
        {
            return mensagem;
        }
        public Boolean adicionarHospedagem(HospedagemDTO hospedagemDTO)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "INSERT INTO hospedagem (fk_cliente, dataEntrada, valor, quarto) VALUES (@fk_cliente, @dataEntrada, @valor, @quarto)";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                //substitui os @ do texto e adiciona os valores dentro de clienteDTO como paramentros para serem adicionados
                comando.Parameters.AddWithValue("@fk_cliente", hospedagemDTO.getCliente());
                comando.Parameters.AddWithValue("@dataEntrada", hospedagemDTO.getDataEntrada());
                comando.Parameters.AddWithValue("@valor", hospedagemDTO.getValor());
                comando.Parameters.AddWithValue("@quarto", hospedagemDTO.getQuarto());

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

        public List<HospedagemDTO> selecionarTodos()
        {
            List<HospedagemDTO> hospedagens = new List<HospedagemDTO>();
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "SELECT * FROM hospedagem";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                using (MySqlDataReader leitor = comando.ExecuteReader())
                {
                    while (leitor.Read())
                    {

                        int idHospedagem = Convert.ToInt32(leitor["idHospedagem"]);
                        String idCliente = leitor["fk_cliente"].ToString();
                        DateTime dataEntrada = Convert.ToDateTime(leitor["dataEntrada"]);
                        DateTime? dataSaida = leitor["dataSaida"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(leitor["dataSaida"]) : null;
                        double valor = Convert.ToDouble(leitor["valor"]);
                        int quarto = Convert.ToInt32(leitor["quarto"]);

                        HospedagemDTO cliente = new HospedagemDTO(idHospedagem, idCliente, dataEntrada, dataSaida, valor, quarto);

                        // Adiciona o cliente à lista
                        hospedagens.Add(cliente);
                    }
                }
                mensagem = "Seleção realizada com sucesso.";
                return hospedagens;  // Retorna a lista de clientes
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

        public HospedagemDTO selecionarHospedagem(int id)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "SELECT * FROM hospedagem WHERE idHospedagem = @id";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                comando.Parameters.AddWithValue("@id", id);

                MySqlDataReader leitor = comando.ExecuteReader();

                HospedagemDTO hospedagem = null;

                if (leitor.Read())
                {
                    int idHospedagem = Convert.ToInt32(leitor["idHospedagem"]);
                    String idCliente = leitor["fk_cliente"].ToString();
                    DateTime dataEntrada = Convert.ToDateTime(leitor["dataEntrada"]);
                    DateTime? dataSaida = leitor["dataSaida"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(leitor["dataSaida"]) : null;
                    double valor = Convert.ToDouble(leitor["valor"]);
                    int quarto = Convert.ToInt32(leitor["quarto"]);

                    hospedagem = new HospedagemDTO(idHospedagem, idCliente, dataEntrada, dataSaida, valor, quarto);
                    mensagem = "Seleção realizada com sucesso.";
                }
                else
                {
                    mensagem = "Nenhuma hospedagem encontrada com o ID fornecido.";
                }

                mensagem = "Seleção realizada com sucesso.";
                return hospedagem;
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

        public Boolean excluirHospedagem(HospedagemDTO hospedagemDTO)
        {
            try
            {
                BancoDeDados.abrirConexao();

                //define o comando a ser enviado ao banco
                String comandoTexto = "DELETE FROM hospedagem WHERE idHospedagem = @id";
                MySqlCommand comando = new MySqlCommand(comandoTexto, BancoDeDados.getConexao());

                //substitui os @ do texto e adiciona os valores dentro de clienteDTO como paramentros para serem adicionados
                comando.Parameters.AddWithValue("@id", hospedagemDTO.getHospedagem());

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
    }
}
