using BookVault.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookVault.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Biblioteca> Bibliotecas => Set<Biblioteca>();

    public DbSet<Livro> Livros => Set<Livro>();

    public DbSet<Categoria> Categorias => Set<Categoria>();

    public DbSet<LivroCategoria> LivroCategorias => Set<LivroCategoria>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<LivroCategoria>()
            .HasKey(lc => new { lc.LivroId, lc.CategoriaId });

        modelBuilder.Entity<LivroCategoria>()
            .HasOne(lc => lc.Livro)
            .WithMany(l => l.Categorias)
            .HasForeignKey(lc => lc.LivroId);

        modelBuilder.Entity<LivroCategoria>()
            .HasOne(lc => lc.Categoria)
            .WithMany(c => c.Livros)
            .HasForeignKey(lc => lc.CategoriaId);
    }
}
