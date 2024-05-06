import { IEmojiAnswers, ISong, ISongResult } from "../Interfaces/interfaces";

const BASE_URL = "https://localhost:7194"

export const songResult = async (emojiAnswers : IEmojiAnswers) : Promise<ISongResult>  => {
try {
    const response = await fetch(`${BASE_URL}/music/emojis?firstEmoji=${emojiAnswers.firstEmoji}&secondEmoji=${emojiAnswers.secondEmoji}&thirdEmoji=${emojiAnswers.thirdEmoji}`, {
      method: 'GET',
      headers: {
          'Accept': 'application/json',
      },
  });
   if (response.ok) {
       return response.json();
   }
   else {
       const defaultSongs : ISongResult = { music: getSongs() }
       return defaultSongs;
   }
  }
  catch {
    const defaultSongs : ISongResult = { music: getSongs() }
    return defaultSongs;
  }
}

const getSongs = () : ISong[] => {
  return [
      {id: "1", songName: "Music", artist: "123 artist", emoji: "🍭"},
      {id: "2", songName: "Song", artist: "Artist", emoji: "🦓"},
      {id: "3", songName: "Hello", artist: "okay", emoji: "📺"},
      {id: "4", songName: "My Song", artist: "windows-xp", emoji: "👑"},
      {id: "5", songName: "A song", artist: "lil", emoji: "⚡️💭"},
  ]
}