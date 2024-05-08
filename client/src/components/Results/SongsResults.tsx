import { ISong, ISongResult } from "../../Interfaces/interfaces"
import star from "../../assets/star.svg"
import { addSongToFavorites } from "../../utils/musicService"

interface IProps {
  songResults: ISongResult | undefined,
}

const SongsResults = (props: IProps) => {
  const songResults = props.songResults

  const handleAddToFavorites = (song: ISong) => {
    addSongToFavorites(song)
  }

  return (
    <div>
      <ul className="flex flex-col list-none gap-6">
        {songResults?.music.map((song: ISong) => (
          <li className="flex justify-between items-center min-w-[600px] px-4 py-2 gap-4 w-60 h-16 rounded-md 
          bg-transparent bg-opacity-70 text-2xl uppercase border-[3px] border-black" key={song.id}>
            {song.artist} {song.songName} {song.emoji}
            <button className="hover:scale-110 ease-in duration-150 hover:hue-rotate-0" onClick={() => handleAddToFavorites(song)}>
              <img className="max-w-[24px] max-h-[24px]" src={star} />
            </button>
          </li>
        ))}
      </ul>
    </div>
  )
}
export default SongsResults