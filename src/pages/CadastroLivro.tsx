import type { FormEvent } from 'react'

function CadastroLivro() {
  function handleSubmit(event: FormEvent<HTMLFormElement>) {
    event.preventDefault()
  }

  return (
    <main>
      <h1>Cadastrar livro</h1>

      <form onSubmit={handleSubmit}>
        <div>
          <label htmlFor="titulo">Título</label>
          <input id="titulo" name="titulo" type="text" required />
        </div>

        <div>
          <label htmlFor="autor">Autor</label>
          <input id="autor" name="autor" type="text" required />
        </div>

        <div>
          <label htmlFor="capa">Capa (URL da imagem)</label>
          <input id="capa" name="capa" type="url" />
        </div>

        <div>
          <label htmlFor="nota">Nota</label>
          <input
            id="nota"
            name="nota"
            type="number"
            min="0"
            max="5"
            step="0.5"
          />
        </div>

        <div>
          <label htmlFor="status">Status de leitura</label>
          <select id="status" name="status" defaultValue="Quero ler" required>
            <option value="Quero ler">Quero ler</option>
            <option value="Lendo">Lendo</option>
            <option value="Lido">Lido</option>
            <option value="Em pausa">Em pausa</option>
            <option value="Abandonado">Abandonado</option>
          </select>
        </div>

        <div>
          <label htmlFor="observacoes">Observações</label>
          <textarea id="observacoes" name="observacoes" rows={4} />
        </div>

        <button type="submit">Cadastrar livro</button>
      </form>
    </main>
  )
}

export default CadastroLivro
