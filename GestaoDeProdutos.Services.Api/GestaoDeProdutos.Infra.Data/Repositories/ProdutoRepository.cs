using GestaoDeProdutos.Domain.Interfaces;
using GestaoDeProdutos.Domain.Models;
using GestaoDeProdutos.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Infra.Data.Repositories
{
    public abstract class ProdutoRepository : IProdutoRepository
    {
        public void Add(Produto produto)
        {
            using (var context = new DataContext())
            {
                context.Produtos.Add(produto);
                context.SaveChanges();
            }
        }

        public void Update(Produto produto)
        {
            using (var context = new DataContext())
            {
                context.Produtos.Update(produto);
                context.SaveChanges();
            }
        }

        public void Delete(Produto produto)
        {
            using (var context = new DataContext())
            {
                context.Produtos.Remove(produto);
                context.SaveChanges();
            }
        }

        public Produto Get(string nome)
        {
            using (var context = new DataContext())
            {
                return context.Produtos.FirstOrDefault();
            }
        }

        List<Produto> IProdutoRepository.GetAll()
        {
            using (var context = new DataContext())
            {
                return context.Produtos.ToList();
            }
        }
    }
}
