using BookVault.API.Models;

namespace BookVault.API.DTOs.Livros;

public class CriarLivroDto
{
    public string Titulo { get; set; } = string.Empty;

    public string Autor { get; set; } = string.Empty;

    public string? Descricao { get; set; }

    public string? CapaUrl { get; set; }

    public int? AnoPublicacao { get; set; }

    public decimal? Nota { get; set; }

    public StatusLeitura StatusLeitura { get; set; }

    public string? Observacoes { get; set; }

    public Guid BibliotecaId { get; set; }

    public List<Guid> CategoriasIds { get; set; } = new();
}
