
import type { FormEvent } from 'react'
import './CadastroLivro.css'

function CadastroLivro() {
  function handleSubmit(event: FormEvent<HTMLFormElement>) {
    event.preventDefault()
  }

  return (
    <main className="cadastro-livro">
      <header className="cadastro-livro__cabecalho">
        <h1>Cadastrar livro</h1>
        <p>Adicione um novo livro à sua biblioteca pessoal.</p>
      </header>

      <form
        className="cadastro-livro__formulario"
        onSubmit={handleSubmit}
      >
        <div className="cadastro-livro__campo">
          <label htmlFor="titulo">Título</label>
          <input
            id="titulo"
            name="titulo"
            type="text"
            placeholder="Ex.: O Hobbit"
            required
          />
        </div>

        <div className="cadastro-livro__campo">
          <label htmlFor="autor">Autor</label>
          <input
            id="autor"
            name="autor"
            type="text"
            placeholder="Ex.: J. R. R. Tolkien"
            required
          />
        </div>

        <div className="cadastro-livro__campo">
          <label htmlFor="capa">Capa (URL da imagem)</label>
          <input
            id="capa"
            name="capa"
            type="url"
            placeholder="https://exemplo.com/capa.jpg"
          />
          <span className="cadastro-livro__ajuda">
            Informe um link para a imagem da capa, se tiver.
          </span>
        </div>

        <div className="cadastro-livro__campo">
          <label htmlFor="nota">Nota</label>
          <input
            id="nota"
            name="nota"
            type="number"
            min="0"
            max="5"
            step="0.5"
            placeholder="De 0 a 5"
          />
        </div>

        <div className="cadastro-livro__campo">
          <label htmlFor="status">Status de leitura</label>
          <select
            id="status"
            name="status"
            defaultValue="Quero ler"
            required
          >
            <option value="Quero ler">Quero ler</option>
            <option value="Lendo">Lendo</option>
            <option value="Lido">Lido</option>
            <option value="Em pausa">Em pausa</option>
            <option value="Abandonado">Abandonado</option>
          </select>
        </div>

        <div className="cadastro-livro__campo">
          <label htmlFor="observacoes">Observações</label>
          <textarea
            id="observacoes"
            name="observacoes"
            rows={4}
            placeholder="Anotações pessoais sobre o livro..."
          />
        </div>

        <button className="cadastro-livro__botao" type="submit">
          Cadastrar livro
        </button>
      </form>
    </main>
  )
}

export default CadastroLivro
