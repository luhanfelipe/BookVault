namespace BookVault.API.Models;

public class LivroCategoria
{
    public Guid LivroId { get; set; }

    public Livro Livro { get; set; } = null!;

    public Guid CategoriaId { get; set; }

    public Categoria Categoria { get; set; } = null!;

    public bool Principal { get; set; }
}
