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

app.MapGet("/livros", async (AppDbContext db) =>
{
    var livros = await db.Livros.ToListAsync();

    return Results.Ok(livros);
});

app.MapGet("/livros/{id:guid}", async (Guid id, AppDbContext db) =>
{
    var livro = await db.Livros.FindAsync(id);

    if (livro is null)
    {
        return Results.NotFound();
    }

    return Results.Ok(livro);
});

app.MapPut("/livros/{id:guid}", async (Guid id, Livro dadosAtualizados, AppDbContext db) =>
{
    var livro = await db.Livros.FindAsync(id);

    if (livro is null)
    {
        return Results.NotFound();
    }

    livro.Titulo = dadosAtualizados.Titulo;
    livro.Autor = dadosAtualizados.Autor;
    livro.Sinopse = dadosAtualizados.Sinopse;
    livro.AnoPublicacao = dadosAtualizados.AnoPublicacao;

    await db.SaveChangesAsync();

    return Results.Ok(livro);
});

app.MapPost("/livros", async (Livro livro, AppDbContext db) =>
{
    livro.Id = Guid.NewGuid();
    livro.DataCadastro = DateTime.UtcNow;

    db.Livros.Add(livro);
    await db.SaveChangesAsync();

    return Results.Created($"/livros/{livro.Id}", livro);
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
