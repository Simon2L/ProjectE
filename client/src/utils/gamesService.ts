import { IEmojiAnswers, IGame, IGameResult } from "../Interfaces/interfaces";

const BASE_URL = "https://localhost:7194"

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
       const defaultSongs : IGameResult = { games: getMovies() }
       return defaultSongs;
   }
  }
  catch {
    const defaultSongs : IGameResult = {  games: getMovies() }
    return defaultSongs;
  }
}

const getMovies = () : IGame[] => {
  return [
      {id: "1", name: "Game", publishYear: 2024, emoji: "🍭"},
      {id: "2", name: "Mario", publishYear: 2021, emoji: "🦓"},
      {id: "3", name: "Game 3", publishYear: 2018, emoji: "📺"},
      {id: "4", name: "Something game", publishYear: 1999, emoji: "👑"},
      {id: "5", name: "My Game", publishYear: 2005, emoji: "⚡️"},
  ]
}