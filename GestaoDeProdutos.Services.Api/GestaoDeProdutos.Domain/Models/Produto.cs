﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Domain.Models
{
    public  class Produto
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set;}
        public string? Descricao { get; set;}
        public decimal Preco { get; set;}
        public int Quantidade { get; set;}
        public Guid EstoqueId { get; set;}
        public Guid CategoriaId { get; set;}
        public Estoque Estoque { get; set;}
        public Categoria Categoria { get; set;}
    }
}
