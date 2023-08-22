using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Domain.Exceptions
{
    public class ProdutoJaCadastradoException : Exception
    {
        public override string Message => "Produto já cadastrado, tente outro.";
    }
}
