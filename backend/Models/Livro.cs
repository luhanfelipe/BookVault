namespace BookVault.Models;

public class Livro
{
    public Guid Id { get; set; }

    public string Titulo { get; set; } = string.Empty;

    public string Autor { get; set; } = string.Empty;

    public string? Sinopse { get; set; }

    public int AnoPublicacao { get; set; }

    public DateTime DataCadastro { get; set; }
}
