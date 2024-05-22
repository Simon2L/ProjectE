import { IEmojiAnswers, IGame, IGameResult } from "../Interfaces/interfaces";

const BASE_URL = "https://localhost:7194"

interface IAddGameToFavoritesRequest {
  id: string
  name: string
  rating: number //its publish year too lazy to fix
  emoji: string
}


export const gameResult = async (emojiAnswers : IEmojiAnswers) : Promise<IGameResult>  => {
try {
    const response = await fetch(`${BASE_URL}/games/emojis?firstEmoji=${emojiAnswers.firstEmoji}&secondEmoji=${emojiAnswers.secondEmoji}&thirdEmoji=${emojiAnswers.thirdEmoji}`, {
      method: 'GET',
      headers: {
          'Accept': 'application/json',
      },
  });
   if (response.ok) {
       return response.json();
   }
   else {
       const defaultGames : IGameResult = { games: getMovies() }
       return defaultGames;
   }
  }
  catch {
    const defaultGames : IGameResult = {  games: getMovies() }
    return defaultGames;
  }
}

export const addGameToFavorites = async (game : IAddGameToFavoritesRequest) => {
  try {
    const response = await fetch(`${BASE_URL}/favorites/game`, {
      method: 'POST',
      headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json',
        'Authorization': `Bearer ${sessionStorage.getItem("token")}`
      },
      body: JSON.stringify(game)
    })
    if(response) {
    }
    else {
    }
  }
  catch {
  }
}

export const removeGameFromFavorites = async (gameId : string) => {
  try {
    const response = await fetch(`${BASE_URL}/favorites/game/${gameId}`, {
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

const getMovies = () : IGame[] => {
  return [
      {id: "1", name: "Game", rating: 2024, emoji: "🍭"},
      {id: "2", name: "Mario", rating: 2021, emoji: "🦓"},
      {id: "3", name: "Game 3", rating: 2018, emoji: "📺"},
      {id: "4", name: "Something game", rating: 1999, emoji: "👑"},
      {id: "5", name: "My Game", rating: 2005, emoji: "⚡️"},
  ]
}