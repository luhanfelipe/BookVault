
export const generosLiterarios = {
  Fantasia: [
    'Alta fantasia',
    'Fantasia épica',
    'Fantasia urbana',
    'Fantasia sombria',
  ],
  Romance: [
    'Romance histórico',
    'Romance contemporâneo',
    'Romance de época',
    'Romance policial',
  ],
  'Ficção científica': [
    'Distopia',
    'Space opera',
    'Cyberpunk',
    'Viagem no tempo',
  ],
  Terror: [
    'Terror psicológico',
    'Terror sobrenatural',
    'Gótico',
  ],
  Mistério: [
    'Investigação criminal',
    'Enigma',
    'Suspense psicológico',
  ],
  Aventura: [
    'Exploração',
    'Sobrevivência',
    'Jornada',
  ],
  Drama: [
    'Drama psicológico',
    'Drama familiar',
    'Tragédia',
  ],
  Biografia: [
    'Autobiografia',
    'Memórias',
    'Biografia histórica',
  ],
  História: [
    'História antiga',
    'História medieval',
    'História moderna',
  ],
  Poesia: [
    'Poesia lírica',
    'Poesia épica',
    'Poesia contemporânea',
  ],
  'Não ficção': [
    'Filosofia',
    'Ciência',
    'Desenvolvimento pessoal',
    'Ensaios',
  ],
} as const

export type GeneroPrincipal = keyof typeof generosLiterarios

export type Subgenero =
  (typeof generosLiterarios)[GeneroPrincipal][number]

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
  nota: number | null
  status: StatusLeitura
  observacoes: string
  generoPrincipal: GeneroPrincipal
  subgeneros: Subgenero[]
}
