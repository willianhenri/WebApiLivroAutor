using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Services.Autor;
using WebApi.Services.Livro;

var builder = WebApplication.CreateBuilder(args);

// Forçar uso da porta do ambiente (ex: Railway usa a 3000)
var port = Environment.GetEnvironmentVariable("PORT") ?? "3000";
builder.WebHost.UseUrls($"http://*:{port}");

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options => {
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IAutorInterface, AutorServices>();
builder.Services.AddScoped<ILivroInterface, LivroServices>();

var app = builder.Build();

// Adiciona rota de teste simples no "/"
app.MapGet("/", () => "?? API Web rodando com sucesso!");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment() || app.Environment.IsProduction()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
