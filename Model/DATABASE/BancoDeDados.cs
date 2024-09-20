using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem_em_C_.Model.DATABASE
{
    public class BancoDeDados
    {
        private static String strConexao = "datasource=localhost;username=root;password=;database=hospedagemulysses";

        private static MySqlConnection conexao = new MySqlConnection(strConexao);
        public static void abrirConexao()
        {
            BancoDeDados.conexao.Open();
        }
        public static void fecharConexao()
        {
            BancoDeDados.conexao.Close();
        }

        public static MySqlConnection getConexao()
        {
            return conexao;
        }
    }
}