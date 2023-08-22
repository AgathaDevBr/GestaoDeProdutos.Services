using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Domain.Exceptions
{
    public class EstoqueJaCadastradoException : Exception
    {
        public override string Message => "Estoque já cadastrado, tente outro.";
    }
}
