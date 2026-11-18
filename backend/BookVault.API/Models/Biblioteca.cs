
namespace BookVault.API.Models;

public class Biblioteca
{
    public Guid Id { get; set; }

    public string Nome { get; set; } = "Minha Biblioteca";

    public Guid UsuarioId { get; set; }

    public ICollection<Livro> Livros { get; set; } = new List<Livro>();
}
