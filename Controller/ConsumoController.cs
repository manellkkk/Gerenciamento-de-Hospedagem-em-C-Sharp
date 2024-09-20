using Hospedagem_em_C_.Model.DAO;
using Hospedagem_em_C_.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospedagem_em_C_.Controller
{
    public class ConsumoController
    {
        public List<ConsumoDTO> selecionarPorHospedagem(int id)
        {
            ConsumoDAO consumoDAO = new ConsumoDAO();
            List<ConsumoDTO> consumos = consumoDAO.selecionarPorHospedagem(id);

            if (consumos == null)
            {
                MessageBox.Show(consumoDAO.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return consumos;
        }

        public Boolean adicionarConsumo(int idHospedagem, int idProduto, String qtd)
        {
            int quantidade = int.Parse(qtd);
            ProdutoController produtoController = new ProdutoController();
            ProdutoDTO produtoDTO = produtoController.selecionarProduto(idProduto);

            if (quantidade == 0)
            {
                MessageBox.Show("Campo invalido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (quantidade > produtoDTO.getQuantidade())
            {
                MessageBox.Show("Quantidade maior que o estoque.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            ConsumoDAO consumoDAO = new ConsumoDAO();
            ConsumoDTO consumoDTO = new ConsumoDTO(0, idProduto, idHospedagem, quantidade, DateTime.Today);

            if (consumoDAO.adicionarConsumo(consumoDTO))
            {
                produtoController.alterarQuantidade(produtoDTO, produtoDTO.getQuantidade() - quantidade);

                MessageBox.Show(consumoDAO.getMensagem(), "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show(consumoDAO.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public Boolean excluirConsumo(int id)
        {
            ConsumoDAO consumoDAO = new ConsumoDAO();
            ConsumoDTO consumoDTO = consumoDAO.selecionarConsumo(id);

            if (consumoDAO.excluirCliente(consumoDTO.getConsumo()))
            {
                ProdutoController produtoController = new ProdutoController();
                ProdutoDTO produtoDTO = produtoController.selecionarProduto(consumoDTO.getProduto());
                produtoController.alterarQuantidade(produtoDTO, produtoDTO.getQuantidade() + consumoDTO.getQuantidade());
                MessageBox.Show(consumoDAO.getMensagem(), "Concluido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show(consumoDAO.getMensagem(), "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
