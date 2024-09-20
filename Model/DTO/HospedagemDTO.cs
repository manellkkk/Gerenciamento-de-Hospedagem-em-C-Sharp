using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem_em_C_.Model.DTO
{
    public class HospedagemDTO
    {
        private int idHospedagem;
        private String idCliente;
        private DateTime dataEntrada;
        private DateTime? dataSaida;
        private double valor;
        private int quarto;

        public HospedagemDTO(int idHospedagem, String idCliente, DateTime dataEntrada, DateTime? dataSaida, double valor, int quarto)
        {
            this.idHospedagem = idHospedagem;
            this.idCliente = idCliente;
            this.dataEntrada = dataEntrada;
            this.dataSaida = dataSaida;
            this.valor = valor;
            this.quarto = quarto;
        }

        public DateTime getDataEntrada()
        {
            return dataEntrada;
        }
        public DateTime? getDataSaida()
        {
            return dataSaida;
        }
        public void setDataSaida(DateTime? dataSaida)
        {
            this.dataSaida = dataSaida;
        }
        public double getValor()
        {
            return valor;
        }
        public int getQuarto()
        {
            return quarto;
        }
        public String getCliente()
        {
            return idCliente;
        }
        public int getHospedagem()
        {
            return idHospedagem;
        }
    }
}
