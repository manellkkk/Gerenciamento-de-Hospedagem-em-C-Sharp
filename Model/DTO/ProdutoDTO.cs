using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem_em_C_.Model.DTO
{
    public class ProdutoDTO
    {
        private int idProduto;
        private String nome;
        private int quantidade;
        private double valor;

        public ProdutoDTO(int idProduto, String nome, int quantidade, double valor)
        {
            this.idProduto = idProduto;
            this.nome = nome;
            this.quantidade = quantidade;
            this.valor = valor;
        }

        public int getIdProduto()
        {
            return idProduto;
        }
        public String getNome()
        {
            return nome;
        }
        public int getQuantidade()
        {
            return quantidade;
        }
        public double getValor()
        {
            return valor;
        }
    }
}
