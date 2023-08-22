using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Domain.Models
{
    public class Categoria
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public ICollection<Produto>? Produtos { get; set; }
    }
}
