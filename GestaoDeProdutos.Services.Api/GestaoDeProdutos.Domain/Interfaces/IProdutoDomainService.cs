using GestaoDeProdutos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Domain.Interfaces
{
    public interface IProdutoDomainService
    {
        void CriarProduto(Produto produto);
        Produto AtualizarProduto(Produto produto);
        void DeletarProduto(Produto produto);
        List<Produto> ListaDeProdutos(List<Produto> produtos);
        Produto Get(string produto);
    }
}
