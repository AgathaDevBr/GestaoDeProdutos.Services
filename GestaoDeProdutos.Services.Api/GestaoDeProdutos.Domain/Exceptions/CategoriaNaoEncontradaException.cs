using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Domain.Exceptions
{
    public class CategoriaNaoEncontradaException : Exception
    {
        public override string Message
            => "Categoria não encontrado.";
    }
}
