using BookVault.Models;
using BookVault.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=bookvault.db"));

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapGet("/health", () =>
{
    return Results.Ok(new
    {
        status = "healthy"
    });
});

app.MapGet("/livro-exemplo", () =>
{
    return Results.Ok(new Livro
    {
        Id = Guid.NewGuid(),
        Titulo = "Anne de Green Gables",
        Autor = "L. M. Montgomery",
        Sinopse = "A história de Anne Shirley, uma jovem órfã enviada por engano para Green Gables.",
        AnoPublicacao = 1908,
        DataCadastro = DateTime.UtcNow
    });
});

app.Run();
