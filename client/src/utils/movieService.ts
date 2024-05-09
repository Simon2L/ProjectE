import { IEmojiAnswers, IMovie, IMovieResult } from "../Interfaces/interfaces";

const BASE_URL = "https://localhost:7194"

export const movieResult = async (emojiAnswers : IEmojiAnswers) : Promise<IMovieResult>  => {
try {
    const response = await fetch(`${BASE_URL}/movies/emojis?firstEmoji=${emojiAnswers.firstEmoji}&secondEmoji=${emojiAnswers.secondEmoji}&thirdEmoji=${emojiAnswers.thirdEmoji}`, {
      method: 'GET',
      headers: {
          'Accept': 'application/json',
      },
  });
   if (response.ok) {
       return response.json();
   }
   else {
       const defaultSongs : IMovieResult = { movies: getMovies() }
       return defaultSongs;
   }
  }
  catch {
    const defaultSongs : IMovieResult = {  movies: getMovies() }
    return defaultSongs;
  }
}

const getMovies = () : IMovie[] => {
  return [
      {id: "1", title: "Movie", rating: 5, emoji: "🍭"},
      {id: "2", title: "Num 2", rating: 9, emoji: "🦓"},
      {id: "3", title: "This is a movie", rating: 3, emoji: "📺"},
      {id: "4", title: "Something", rating: 2, emoji: "👑"},
      {id: "5", title: "Hello movie", rating: 1, emoji: "⚡️💭"},
  ]
}