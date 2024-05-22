import { IEmojiAnswers, IMovie, IMovieResult } from "../Interfaces/interfaces";

const BASE_URL = "https://localhost:7194"

interface IAddMovieToFavoritesRequest {
  id: string
  title: string
  rating: number
  emoji: string
}


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
       const defaultMovies : IMovieResult = { movies: getMovies() }
       return defaultMovies;
   }
  }
  catch {
    const defaultMovies : IMovieResult = {  movies: getMovies() }
    return defaultMovies;
  }
}

export const addMovieToFavorites = async (movie : IAddMovieToFavoritesRequest) => {
  try {
    const response = await fetch(`${BASE_URL}/favorites/movie`, {
      method: 'POST',
      headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json',
        'Authorization': `Bearer ${sessionStorage.getItem("token")}`
      },
      body: JSON.stringify(movie)
    });
    if(response) {
    }
    else {
    }
  }
  catch (e) {
  }
}

export const removeMovieFromFavorites = async (movieId : string) => {
  try {
    const response = await fetch(`${BASE_URL}/favorites/movie/${movieId}`, {
      method: 'DELETE',
      headers: {
        'Accept': 'application/json',
        'Authorization': `Bearer ${sessionStorage.getItem("token")}`
      }
    })
    if (response.status === 204) {
    }
    else {
      console.log("Oooops something went wrong")
      console.log(await response.json())
    }
  }
  catch {
    console.log("Server down")
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