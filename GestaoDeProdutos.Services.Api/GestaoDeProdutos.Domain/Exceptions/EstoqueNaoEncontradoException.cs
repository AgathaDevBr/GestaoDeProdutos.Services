using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Domain.Exceptions
{
    public class EstoqueNaoEncontradoException : Exception
    {
        public override string Message
            => "Estoque não encontrado.";
    }
}
