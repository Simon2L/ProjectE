export interface IEmojiAnswers {
  firstEmoji: string
  secondEmoji: string
  thirdEmoji: string
}

export interface ISongResult {
  music: ISong[]
}
export interface ISong {
  id: string
  songName: string
  artist: string
  emoji: string
}

export interface IQuiz {
  topic: string
  questions: IQuestion[]
}
export interface IQuestion {
  question: string
  choices: string[]
}

export interface IMovieResult {
  movies: IMovie[]
}
export interface IMovie {
  id: string
  title: string
  rating: number
  emoji: string
}

export interface IGame {
  id: string,
  name: string,
  rating: number, //its publish year
  emoji: string
}

export interface IGameResult {
  games: IGame[]
}
