export type StatusLeitura =
  | 'Quero ler'
  | 'Lendo'
  | 'Lido'
  | 'Em pausa'
  | 'Abandonado'

export interface Livro {
  id: string
  titulo: string
  autor: string
  capa: string
  status: StatusLeitura
}
