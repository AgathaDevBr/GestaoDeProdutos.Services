using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Domain.Exceptions
{
    public class ProdutoNaoEncontradoException : Exception
    {
        public override string Message 
            => "Produto não encontrado.";
    }
}
