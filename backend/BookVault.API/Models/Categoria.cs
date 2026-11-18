
namespace BookVault.API.Models;

public class Categoria
{
    public Guid Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public Guid BibliotecaId { get; set; }

    public Biblioteca Biblioteca { get; set; } = null!;

    public ICollection<LivroCategoria> Livros { get; set; }
        = new List<LivroCategoria>();
}
