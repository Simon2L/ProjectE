import { useEffect, useState } from "react"
import { IFavorites, getAllFavorites } from "../../utils/favoritesService"
import { IGame, IMovie, ISong } from "../../Interfaces/interfaces"

const Favorites = () => {
    const [favorites, setFavorites] = useState<IFavorites>()
    useEffect(() => {
        const response = getAllFavorites()
        response.then((fav) => setFavorites(fav))
    }, [])

    return (
        <div className=" flex flex-col items-center gap-10">
            <div>
            <h2 className="text-3xl mb-4">Your favorite Music!</h2>
                <ul className="flex flex-col list-none gap-6">
                    {favorites?.music.map((song: ISong) => (
                        <li className="flex justify-between items-center min-w-[600px] px-4 py-2 gap-4 w-60 h-16 rounded-md text-2xl uppercase  bg-white bg-opacity-20 shadow-[0_4px_0_rgb(0,0,0)]" key={song.id}>
                            {song.artist} {song.songName} {song.emoji}
                            {/* <button className="hover:scale-110 ease-in duration-150 hover:hue-rotate-0" onClick={() => handleAddToFavorites(song)}>
                <img className="max-w-[24px] max-h-[24px]" src={star} />
              </button> */}
                        </li>
                    ))}
                </ul>
            </div>
            <div>
                <h2 className="text-3xl mb-4">Your favorite Movies!</h2>
                <ul className="flex flex-col list-none gap-6">
                    {favorites?.movies?.map((movie: IMovie) => (
                        <li className="flex justify-between items-center min-w-[600px] px-4 py-2 gap-4 w-60 h-16 rounded-md text-2xl uppercase  bg-white bg-opacity-20 shadow-[0_4px_0_rgb(0,0,0)]" key={movie.id}>
                            {movie.id} {movie.title} {movie.rating} {movie.emoji}
                            {/* <button className="hover:scale-110 ease-in duration-150 hover:hue-rotate-0" onClick={() => handleAddToFavorites(movie)}>
                            <img className="max-w-[24px] max-h-[24px]" src={isFavorite ? filledStar : star} />
                        </button> */}
                        </li>
                    ))}
                </ul>
            </div>
            <div>
            <ul className="flex flex-col list-none gap-6">
                {favorites?.games.map((game: IGame) => (
                    <li className="flex justify-between items-center min-w-[600px] px-4 py-2 gap-4 w-60 h-16 rounded-md text-2xl uppercase bg-white bg-opacity-20 shadow-[0_4px_0_rgb(0,0,0)]" key={game.id}>
                        {game.id} {game.name} {game.publishYear} {game.emoji}
                        {/* <StarButton handleAddToFavorits={handleAddToFavorites} add={game} /> */}
                    </li>
                ))}
            </ul>
        </div>
        </div>
    )
}

export default Favorites