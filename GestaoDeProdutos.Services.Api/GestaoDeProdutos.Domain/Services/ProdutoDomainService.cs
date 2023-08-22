using GestaoDeProdutos.Domain.Exceptions;
using GestaoDeProdutos.Domain.Interfaces;
using GestaoDeProdutos.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Domain.Services
{
    partial class ProdutoDomainService : IProdutoDomainService
    {
        private readonly IProdutoRepository? _produtoRepository;

        public ProdutoDomainService(IProdutoRepository? produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Produto AtualizarProduto(Produto produto)
        {
            var produtos = _produtoRepository?.Get(produto.Nome);

            if (produtos == null)
                throw new ProdutoNaoEncontradoException();

            var isUpdate = false;

            if(produto != null)
            {
                //Inserir automapper
                produtos.Nome = produto.Nome;
                produtos.Preco = produto.Preco;
                produtos.Descricao = produto.Descricao;
                produtos.Estoque = produto.Estoque;
                produtos.Categoria  = produto.Categoria;
                produtos.Quantidade = produto.Quantidade;
                
               isUpdate = true;
            }
            if (isUpdate == true)
                _produtoRepository?.Update(produtos);

            return produtos;
        }

        public  void CriarProduto(Produto produto)
        {
            if (_produtoRepository?.Get(produto.Nome) != null)
                throw new ProdutoJaCadastradoException();

            //Inserir automapper
            produto.Id = Guid.NewGuid();
            produto.CategoriaId = Guid.NewGuid();
            produto.EstoqueId = Guid.NewGuid();
            
            _produtoRepository?.Add(produto);
        }

        public void DeletarProduto(Produto produto)
        {
            if(produto != null)
                _produtoRepository?.Delete(produto);
        }


        public Produto Get(string nome)
        {
            var produto = _produtoRepository?.Get(nome);
            return produto;
        }

        public List<Produto> ListaDeProdutos(List<Produto> produtos)
        {
            var lista = _produtoRepository?.GetAll().ToList();
            return lista;
        }
    }
}
