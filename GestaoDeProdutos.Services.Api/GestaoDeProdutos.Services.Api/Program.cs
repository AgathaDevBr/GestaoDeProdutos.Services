using GestaoDeProdutos.Services.Api.Extensions;
using GestaoDeProdutos.Services.Api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddSwaggerDoc();

var app = builder.Build();


app.UseSwaggerDoc();
app.UseAuthorization();
app.MapControllers();
app.UseMiddleware<ExceptionMiddleware>();

app.Run();

public partial class Program { }