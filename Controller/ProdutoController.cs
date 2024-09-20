using Hospedagem_em_C_.Model.DAO;
using Hospedagem_em_C_.Model.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Hospedagem_em_C_.Controller
{
    public class ProdutoController
    {
        private String mensagem;

        public Boolean adicionarProduto(String nome, String qtd, String strValor)
        {
            //passa o valor quantidade em string para int
            int quantidade;
            double valor;
            try
            {
                quantidade = int.Parse(qtd);
                valor = double.Parse(strValor);
            }
            catch (Exception ex)
            {
                quantidade = 0;
                valor = 0;
            }

            //verifica se os campos sao validos
            if (verificarCampos(nome, quantidade, valor))
            {
                MessageBox.Show("Campos invalidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //instancia um objeto do tipo produto com as informacoes obtidas
            ProdutoDTO produtoDTO = new ProdutoDTO(0, nome, quantidade, valor);

            ProdutoDAO produtoDAO = new ProdutoDAO();


            if (produtoDAO.adicionarProduto(produtoDTO))
            {
                MessageBox.Show(produtoDAO.getMensagem(), "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show(produtoDAO.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public List<ProdutoDTO> selecionarPorNome(String nome)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            List<ProdutoDTO> produtos = produtoDAO.selecionarPorNome(nome);
            return produtos;
        }

        public List<ProdutoDTO> selecionarPorID(String id)
        {
            int idProduto = int.Parse(id);

            ProdutoDAO produtoDAO = new ProdutoDAO();
            List<ProdutoDTO> produtos = produtoDAO.selecionarPorID(idProduto);
            return produtos;
        }

        public Boolean alterarQuantidade(ProdutoDTO produtoDTO, int quantidade)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            return produtoDAO.alterarQuantidade(produtoDTO, quantidade);
        }

        public Boolean atualizarProduto(int id, String nome, String qtd, String strValor)
        {
            //passa os valores para os formatos certos
            int quantidade = int.Parse(qtd);
            double valor = double.Parse(strValor);

            //verifica se o nome esta vazio ou o cpf e menor que o esperado
            if (verificarCampoVazio(nome) || quantidade == 0 || valor == 0)
            {
                MessageBox.Show("Campos invalidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //instancia um objeto do tipo cliente com as informacoes obtidas
            ProdutoDTO produtoDTO = new ProdutoDTO(id, nome, quantidade, valor);

            ProdutoDAO produtoDAO = new ProdutoDAO();


            if (produtoDAO.atualizarProduto(produtoDTO))
            {
                MessageBox.Show(produtoDAO.getMensagem(), "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show(produtoDAO.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private Boolean verificarCampos(String nome, int quantidade, double valor)
        {
            return nome == String.Empty || quantidade == 0 || valor == 0;
        }

        public Boolean excluirProduto(int id)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            ProdutoDTO produtoDTO = produtoDAO.selecionarProduto(id);


            if (produtoDAO.excluirProduto(produtoDTO))
            {
                MessageBox.Show(produtoDAO.getMensagem(), "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show(produtoDAO.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<ProdutoDTO> selecionarTodos()
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            List<ProdutoDTO> produtos = produtoDAO.selecionarTodos();
            return produtos;
        }

        public ProdutoDTO selecionarProduto(int id)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            ProdutoDTO produto = produtoDAO.selecionarProduto(id);

            if (produto == null)
            {
                MessageBox.Show(produtoDAO.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return produto;
        }
    }
}
