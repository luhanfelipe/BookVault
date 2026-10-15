import type { Livro } from '../types/Livro'
import './LivroCard.css'

interface LivroCardProps {
  livro: Livro
}

function LivroCard({ livro }: LivroCardProps) {
  return (
    <article className="livro-card">
      <img
        className="livro-card__capa"
        src={livro.capa}
        alt={`Capa do livro ${livro.titulo}`}
      />

      <div className="livro-card__conteudo">
        <span className={`livro-card__status livro-card__status--${livro.status
          .toLowerCase()
          .replaceAll(' ', '-')
          .replaceAll('ã', 'a')}`}
        >
          {livro.status}
        </span>

        <h2 className="livro-card__titulo">{livro.titulo}</h2>
        <p className="livro-card__autor">{livro.autor}</p>
      </div>
    </article>
  )
}

export default LivroCard
