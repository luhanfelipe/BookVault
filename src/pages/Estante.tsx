
import { useState } from 'react'
import LivroCard from '../components/LivroCard'
import type { Livro } from '../types/Livro'
import './Estante.css'

const livrosExemplo: Livro[] = [
  {
    id: '1',
    titulo: 'Anne de Green Gables',
    autor: 'L. M. Montgomery',
    capa: 'https://covers.openlibrary.org/b/title/Anne%20of%20Green%20Gables-L.jpg',
    status: 'Lido',
    nota: 4.5,
    observacoes: 'Uma aventura fantástica.',
  },
  {
    id: '2',
    titulo: 'O Hobbit',
    autor: 'J. R. R. Tolkien',
    capa: 'https://covers.openlibrary.org/b/title/The%20Hobbit-L.jpg',
    status: 'Lendo',
    nota: 4.5,
    observacoes: 'Uma aventura fantástica.',
  },
  {
    id: '3',
    titulo: 'Orgulho e Preconceito',
    autor: 'Jane Austen',
    capa: 'https://covers.openlibrary.org/b/title/Pride%20and%20Prejudice-L.jpg',
    status: 'Quero ler',
    nota: 4.5,
    observacoes: 'Uma aventura fantástica.',
  },
  {
    id: '4',
    titulo: 'Dom Casmurro',
    autor: 'Machado de Assis',
    capa: 'https://covers.openlibrary.org/b/title/Dom%20Casmurro-L.jpg',
    status: 'Em pausa',
    nota: 4.5,
    observacoes: 'Uma aventura fantástica.',
  },
  {
    id: '5',
    titulo: 'Frankenstein',
    autor: 'Mary Shelley',
    capa: 'https://covers.openlibrary.org/b/title/Frankenstein-L.jpg',
    status: 'Abandonado',
    nota: 4.5,
    observacoes: 'Uma aventura fantástica.',
  },
]

function Estante() {
  const [termoPesquisa, setTermoPesquisa] = useState('')

  return (
    <main className="estante">
      <header className="estante__cabecalho">
        <h1>Minha estante</h1>
        <p>Todos os seus livros em um só lugar.</p>
      </header>

      <div className="estante__pesquisa">
        <label htmlFor="pesquisa-livros">Pesquisar livros</label>
        <input
          id="pesquisa-livros"
          type="search"
          placeholder="Buscar por título ou autor..."
          value={termoPesquisa}
          onChange={(event) => setTermoPesquisa(event.target.value)}
        />
      </div>

      <section className="estante__grade" aria-label="Lista de livros">
        {livrosExemplo.map((livro) => (
          <LivroCard key={livro.id} livro={livro} />
        ))}
      </section>
    </main>
  )
}

export default Estante
