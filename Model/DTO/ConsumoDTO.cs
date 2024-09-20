using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem_em_C_.Model.DTO
{
    public class ConsumoDTO
    {
        private int idConsumo;
        private int idProduto;
        private int idHospedagem;
        private int quantidade;
        private DateTime dataConsumo;

        public ConsumoDTO(int idConsumo, int idProduto, int idHospedagem, int quantidade, DateTime dataConsumo)
        {
            this.idConsumo = idConsumo;
            this.idProduto = idProduto;
            this.idHospedagem = idHospedagem;
            this.quantidade = quantidade;
            this.dataConsumo = dataConsumo;
        }

        public int getConsumo()
        {
            return idConsumo;
        }
        public int getProduto()
        {
            return idProduto;
        }
        public int getHospedagem()
        {
            return idHospedagem;
        }
        public int getQuantidade()
        {
            return quantidade;
        }
        public DateTime getDataConsumo()
        {
            return dataConsumo;
        }
    }
}
