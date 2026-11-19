namespace BookVault.API.DTOs.Livros;

public class LivroRespostaDto
{
    public Guid Id { get; set; }

    public string Titulo { get; set; } = string.Empty;

    public string Autor { get; set; } = string.Empty;

    public string? Descricao { get; set; }

    public string? CapaUrl { get; set; }

    public int? AnoPublicacao { get; set; }

    public decimal? Nota { get; set; }

    public string StatusLeitura { get; set; } = string.Empty;

    public string? Observacoes { get; set; }

    public List<CategoriaLivroDto> Categorias { get; set; } = new();
}

public class CategoriaLivroDto
{
    public Guid Id { get; set; }

    public string Nome { get; set; } = string.Empty;

    public bool Principal { get; set; }
}
