
import type { Livro } from '../types/Livro'
import './DetalhesLivro.css'

const livro: Livro = {
  id: '1',
  titulo: 'O Hobbit',
  autor: 'J. R. R. Tolkien',
  capa: 'https://covers.openlibrary.org/b/title/The%20Hobbit-L.jpg',
  nota: 4.5,
  status: 'Lido',
  observacoes:
    'Uma aventura envolvente, com personagens marcantes e um universo fantástico.',
}

function DetalhesLivro() {
  return (
    <main className="detalhes-livro">
      <button
        className="detalhes-livro__voltar"
        type="button"
        onClick={() => window.history.back()}
      >
        Voltar
      </button>

      <article className="detalhes-livro__conteudo">
        <img
          className="detalhes-livro__capa"
          src={livro.capa}
          alt={`Capa do livro ${livro.titulo}`}
        />

        <div className="detalhes-livro__informacoes">
          <span className="detalhes-livro__status">
            {livro.status}
          </span>

          <h1>{livro.titulo}</h1>
          <p className="detalhes-livro__autor">{livro.autor}</p>

          <section className="detalhes-livro__secao">
            <h2>Minha avaliação</h2>
            <p>
              {livro.nota !== null
                ? `${livro.nota.toLocaleString('pt-BR')} / 5`
                : 'Ainda não avaliado'}
            </p>
          </section>

          <section className="detalhes-livro__secao">
            <h2>Observações</h2>
            <p>{livro.observacoes || 'Nenhuma observação adicionada.'}</p>
          </section>
        </div>
      </article>
    </main>
  )
}

export default DetalhesLivro
