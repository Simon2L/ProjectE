import { useEffect, useState } from "react"
import { IFavorites, getAllFavorites } from "../../utils/favoritesService"
import { IGame, IMovie, ISong } from "../../Interfaces/interfaces"
import QuizResultsSkeleton from "../Skeletons/QuizResultSkeleton"
import { removeSongFromFavorites } from "../../utils/musicService"
import { removeMovieFromFavorites } from "../../utils/movieService"
import { removeGameFromFavorites } from "../../utils/gamesService"

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
                {favorites === undefined && <QuizResultsSkeleton/>}
                <ul className="flex flex-col list-none gap-6">
                    {favorites?.music.map((song: ISong) => (
                        <li className="flex justify-between items-center min-w-[600px] px-4 py-2 gap-4 w-60 h-16 rounded-md text-2xl uppercase  bg-white bg-opacity-20 shadow-[0_4px_0_rgb(0,0,0)]" key={song.id}>
                            {song.artist} {song.songName} {song.emoji}
                            <button className="hover:scale-110 ease-in duration-150" onClick={() => {
                                removeSongFromFavorites(song.id);
                                setFavorites((prev) => {
                                    if (!prev) return prev
                                    return {
                                        ...prev,
                                        music: prev.music.filter((s) => s.id !== song.id),
                                        movies: prev.movies ? prev.movies : [],
                                        games: prev.games ? prev.games : []
                                    };
                                });
                                }}>
                                Remove
                            </button>
                        </li>
                    ))}
                </ul>
            </div>
            <div>
                <h2 className="text-3xl mb-4">Your favorite Movies!</h2>
                {favorites === undefined && <QuizResultsSkeleton/>}
                <ul className="flex flex-col list-none gap-6">
                    {favorites?.movies?.map((movie: IMovie) => (
                        <li className="flex justify-between items-center min-w-[600px] px-4 py-2 gap-4 w-60 h-16 rounded-md text-2xl uppercase  bg-white bg-opacity-20 shadow-[0_4px_0_rgb(0,0,0)]" key={movie.id}>
                            {movie.title} {movie.rating.toFixed(1)} {movie.emoji}
                            <button className="hover:scale-110 ease-in duration-150 hover:hue-rotate-0" onClick={() => {
                                removeMovieFromFavorites(movie.id)
                                setFavorites((prev) => {
                                    if (!prev) return prev
                                    return {
                                        ...prev,
                                        music: prev.music ? prev.music : [],
                                        movies: prev.movies.filter((m) => m.id !== movie.id),
                                        games: prev.games ? prev.games : []
                                    };
                                });
                                }}>
                                Remove
                            </button>
                        </li>
                    ))}
                </ul>
            </div>
            <div>
                <ul className="flex flex-col list-none gap-6">
                <h2 className="text-3xl mb-4">Your favorite Games!</h2>
                {favorites === undefined && <QuizResultsSkeleton/>}
                    {favorites?.games?.map((game: IGame) => (
                        <li className="flex justify-between items-center min-w-[600px] px-4 py-2 gap-4 w-60 h-16 rounded-md text-2xl uppercase bg-white bg-opacity-20 shadow-[0_4px_0_rgb(0,0,0)]" key={game.id}>
                            {game.name} {game.rating} {game.emoji}
                            <button className="hover:scale-110 ease-in duration-150 hover:hue-rotate-0" onClick={() => {
                                removeGameFromFavorites(game.id)
                                setFavorites((prev) => {
                                    if (!prev) return prev
                                    return {
                                        ...prev,
                                        music: prev.music ? prev.music : [],
                                        movies: prev.movies ? prev.movies : [],
                                        games: prev.games.filter((g) => g.id !== game.id),
                                    };
                                });
                                }}>
                                Remove
                            </button>
                        </li>
                    ))}
                </ul>
            </div>
        </div>
    )
}

export default Favorites