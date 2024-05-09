import { IMovie, ISong } from "../Interfaces/interfaces"

const BASE_URL = "https://localhost:7194"

export interface IFavorites {
    movies: IMovie[],
    music: ISong[]
}

// const emptyFavorites : IFavorites = {movies: [], music: []}
const sampleFavorites : IFavorites = {
    music: [
        {id: "1", songName: "Music", artist: "123 artist", emoji: "🍭"},
        {id: "2", songName: "Song", artist: "Artist", emoji: "🦓"},
        {id: "3", songName: "Hello", artist: "okay", emoji: "📺"}
    ],
    movies: [
        {id: "1", title: "Movie", rating: 5, emoji: "🍭"},
        {id: "2", title: "Num 2", rating: 9, emoji: "🦓"},
        {id: "3", title: "This is a movie", rating: 3, emoji: "📺"},
        {id: "4", title: "Something", rating: 2, emoji: "👑"},
        {id: "5", title: "Hello movie", rating: 1, emoji: "⚡️💭"}
    ]
}

export const getAllFavorites = async () : Promise<IFavorites> => {
    try {
        const response = await fetch(`${BASE_URL}/favorites`, {
          method: 'GET',
          headers: {
            'Accept': 'application/json',
            'Authorization': `Bearer ${sessionStorage.getItem("token")}`
          },
        })
        if(response) {
          const favorites : IFavorites = await response.json()
          return favorites
        }
        else {
          return sampleFavorites
        }
      }
      catch {
        return sampleFavorites
    }
}

