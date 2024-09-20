using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem_em_C_.Model.DTO
{
    public class ClienteDTO
    {
        private String nome;
        private String cpf;
        private String telefone;
        private String placaDoCarro;

        public ClienteDTO(string nome, string cpf, string telefone, string placaDoCarro)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.telefone = telefone;
            this.placaDoCarro = placaDoCarro;
        }

        public String getNome()
        {
            return nome;
        }

        public String getCPF()
        {
            return cpf;
        }

        public String getTelefone()
        {
            return telefone;
        }

        public String getPlacaDoCarro()
        {
            return placaDoCarro;
        }

        public void setNome(String nome)
        {
            this.nome = nome;
        }

        public void setCpf(String cpf)
        {
            this.cpf = cpf;
        }

        public void setTelefone(String telefone)
        {
            this.telefone = telefone;
        }

        public void setPlacaDoCarro(String placaDoCarro)
        {
            this.placaDoCarro = placaDoCarro;
        }
    }
}
