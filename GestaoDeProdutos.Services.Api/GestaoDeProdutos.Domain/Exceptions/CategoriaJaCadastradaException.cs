
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeProdutos.Domain.Exceptions
{
    public class CategoriaJaCadastradaException : Exception
    {
        public override string Message => "Categoria já cadastrada, tente outro.";
    }
}
