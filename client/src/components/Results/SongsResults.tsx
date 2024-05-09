import { ISong, ISongResult } from "../../Interfaces/interfaces"
import { addSongToFavorites } from "../../utils/musicService"
import StarButton from "./StarButton"


interface IProps {
  songResults: ISongResult | undefined,
}

const SongsResults = (props: IProps) => {
  const songResults = props.songResults

  const handleAddToFavorites = (song: ISong) => {
    //addSongToFavorites(song)
    console.log(song);
  }

  return (
    <div>
      <ul className="flex flex-col list-none gap-6">
        {songResults?.music.map((song: ISong) => (
          <li className="flex justify-between items-center min-w-[600px] px-4 py-2 gap-4 w-60 h-16 rounded-md text-2xl uppercase bg-white bg-opacity-20 shadow-[0_4px_0_rgb(0,0,0)]" key={song.id}>
            {song.artist} {song.songName} {song.emoji}
            <StarButton add={song} handleAddToFavorits={handleAddToFavorites} />
          </li>
        ))}
      </ul>
    </div>
  )
}
export default SongsResults