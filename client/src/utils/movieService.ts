import { IEmojiAnswers, IMovie, IMovieResult } from "../interfaces/interfaces";

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
      {id: "1", title: "Don't stop the Music", rating: 5, emoji: "🍭"},
      {id: "2", title: "Levels", rating: 9, emoji: "🦓"},
      {id: "3", title: "Poop", rating: 3, emoji: "📺"},
      {id: "4", title: "Valorant", rating: 2, emoji: "👑"},
      {id: "5", title: "What am I even typing", rating: 1, emoji: "⚡️💭"},
  ]
}