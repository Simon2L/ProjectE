import { ISong, ISongResult } from "../../Interfaces/interfaces"
import { addSongToFavorites } from "../../utils/musicService"
import StarButton from "./StarButton"


interface IProps {
  songResults: ISongResult | undefined,
}

const SongsResults = (props: IProps) => {
  const songResults = props.songResults

  const handleAddToFavorites = (song: ISong, isFavorite: boolean) => {
    if (isFavorite) {
      //removeSongFromFavorites(song.id)
    } else {
      addSongToFavorites({ id: song.id, songName: song.songName, artist: song.artist, emoji: song.emoji })
    }
  }

  return (
    <div className="max-h-[400px]">
      <ul className="flex flex-col list-none gap-6 max-h-[366px]">
        {songResults?.music.map((song: ISong) => (
          <li className="flex justify-between items-center min-w-[500px] px-4 py-4 gap-4 w-60 h-12 rounded-md text-xl uppercase bg-white bg-opacity-20 shadow-[0_4px_0_rgb(0,0,0)]" key={song.id}>
            {song.emoji} {song.artist} {song.songName}
            <StarButton add={song} handleAddToFavorites={handleAddToFavorites} />
          </li>
        ))}
      </ul>
    </div>
  )
}
export default SongsResults