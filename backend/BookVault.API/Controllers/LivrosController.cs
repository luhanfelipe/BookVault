using BookVault.API.Data;
using BookVault.API.DTOs.Livros;
using BookVault.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookVault.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LivrosController : ControllerBase
{
    private readonly AppDbContext _context;

    public LivrosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpPost]
    public async Task<IActionResult> Criar(CriarLivroDto dto)
    {
        if (string.IsNullOrWhiteSpace(dto.Titulo) ||
            string.IsNullOrWhiteSpace(dto.Autor))
        {
            return BadRequest("Título e autor são obrigatórios.");
        }

        var biblioteca = await _context.Bibliotecas
            .FirstOrDefaultAsync(b => b.Id == dto.BibliotecaId);

        if (biblioteca is null)
        {
            return NotFound("Biblioteca não encontrada.");
        }

        var categorias = await _context.Categorias
            .Where(c => c.BibliotecaId == dto.BibliotecaId &&
                        dto.CategoriasIds.Contains(c.Id))
            .ToListAsync();

        if (categorias.Count != dto.CategoriasIds.Distinct().Count())
        {
            return BadRequest("Uma ou mais categorias não foram encontradas.");
        }

        var livro = new Livro
        {
            Id = Guid.NewGuid(),
            Titulo = dto.Titulo,
            Autor = dto.Autor,
            Descricao = dto.Descricao,
            CapaUrl = dto.CapaUrl,
            AnoPublicacao = dto.AnoPublicacao,
            Nota = dto.Nota,
            StatusLeitura = dto.StatusLeitura,
            Observacoes = dto.Observacoes,
            BibliotecaId = dto.BibliotecaId,
            Categorias = categorias.Select(c => new LivroCategoria
            {
                CategoriaId = c.Id,
                Principal = false
            }).ToList()
        };

        _context.Livros.Add(livro);
        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(ObterPorId),
            new { id = livro.Id },
            livro
        );
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> ObterPorId(Guid id)
    {
        var livro = await _context.Livros
            .Include(l => l.Categorias)
            .FirstOrDefaultAsync(l => l.Id == id);

        if (livro is null)
        {
            return NotFound();
        }

        return Ok(livro);
    }
}
