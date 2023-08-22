using GestaoDeProdutos.Domain.Exceptions;
using Newtonsoft.Json;
using System.Net;

namespace GestaoDeProdutos.Services.Api.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate? _requestDelegate;

        public ExceptionMiddleware(RequestDelegate? requestDelegate)
        {
            _requestDelegate = requestDelegate;
        }
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _requestDelegate(context);
            }
            catch (ProdutoJaCadastradoException e)
            {
                 await HandleException(context, e);
            }
            catch (CategoriaJaCadastradaException e)
            {
                await HandleException(context, e);
            }
            catch (EstoqueJaCadastradoException e)
            {
                await HandleException(context, e);
            }
            catch (ProdutoNaoEncontradoException e)
            {
                await HandleException(context, e);
            }
            catch (EstoqueNaoEncontradoException e)
            {
                await HandleException(context, e);
            }
            catch (CategoriaNaoEncontradaException e)
            {
                await HandleException(context, e);
            }
        }

        //Método para fazer o tratamento das exceções
        private async Task HandleException(HttpContext context, Exception e)
        {
            switch (e)
            {
                case ProdutoJaCadastradoException:
                    //HTTP 400 BAD REQUEST
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;

                case CategoriaJaCadastradaException:
                    //HTTP 400 BAD REQUEST
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;

                case EstoqueJaCadastradoException:
                    //HTTP 400 BAD REQUEST
                    context.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                    break;

                case ProdutoNaoEncontradoException:
                    //HTTP 404 NOT FOUND
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;

                case EstoqueNaoEncontradoException:
                    //HTTP 404 NOT FOUND
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;

                case CategoriaNaoEncontradaException:
                    //HTTP 404 NOT FOUND
                    context.Response.StatusCode = (int)HttpStatusCode.NotFound;
                    break;

                case Exception:
                    //HTTP 500 INTERNAL SERVER ERROR
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    break;
            }

            //retornando o conteúdo do erro..
            context.Response.ContentType = "application/json";

            var result = new ErrorResult
            {
                StatusCode = context.Response.StatusCode,
                Message = e.Message,
            };

            await context.Response.WriteAsync(JsonConvert.SerializeObject(result));
        }
    }

    /// <summary>
    /// Modelo de dados para retornar o conteudo dos erros
    /// </summary>
    public class ErrorResult
    {
        public int StatusCode { get; set; }
        public string? Message { get; set; }
    }
}

