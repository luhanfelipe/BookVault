
namespace BookVault.API.Models;

public class Livro
{
    public Guid Id { get; set; }

    public string Titulo { get; set; } = string.Empty;

    public string Autor { get; set; } = string.Empty;

    public string? Descricao { get; set; }

    public string? CapaUrl { get; set; }

    public int? AnoPublicacao { get; set; }

    public decimal? Nota { get; set; }

    public StatusLeitura StatusLeitura { get; set; }

    public string? Observacoes { get; set; }

    public Guid BibliotecaId { get; set; }

    public ICollection<LivroCategoria> Categorias { get; set; }
        = new List<LivroCategoria>();
}

public enum StatusLeitura
{
    QueroLer,
    Lendo,
    Lido,
    Abandonado
}
