using GestaoDeProdutos.Application.Interfaces;
using GestaoDeProdutos.Application.Models.Request.Produtos;
using GestaoDeProdutos.Application.Models.Response.Produtos;
using GestaoDeProdutos.Services.Api.Middlewares;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GestaoDeProdutos.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {

        [HttpPost]
        [Route("CriarProduto")]
        public IActionResult CriarProduto()
        {
            return Ok();
        }

        [HttpPost]
        [Route("AtualizarProduto")]
        public IActionResult AtualizarProduto()
        {
            return Ok();
        }

        [HttpDelete]
        [Route("DeletarProduto")]
        public IActionResult DeletarProduto()
        {
            return Ok();
        }
        [HttpGet]
        [Route("ListarTodosProdutos")]
        public IActionResult ListarTodosProdutos()
        {
            return Ok();
        }
    }
}
