using GestaoDeProdutos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Domain.Interfaces
{
    public interface IProdutoRepository
    {
        void Add(Produto produto);
        void Update(Produto produto);
        void Delete(Produto produto);
        Produto Get(string nome);
        List<Produto> GetAll();
    }
}
