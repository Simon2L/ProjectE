import { IMovie, IMovieResult } from "../../Interfaces/interfaces"
import { addMovieToFavorites } from "../../utils/movieService"
import StarButton from "./StarButton"

interface IProps {
    movieResults: IMovieResult | undefined
}
const MoviesResults = (props: IProps) => {
    const handleAddToFavorites = (movie: IMovie, isFavorite: boolean) => {
        if (isFavorite) {
            //removeMovieFromFavorites(movie.id)
        } else {
            addMovieToFavorites({ id: movie.id, title: movie.title, rating: movie.rating, emoji: movie.emoji })
        }
    }
    return (
        <div>
            <ul className="flex flex-col list-none gap-6 max-h-[366px]">
                {props.movieResults?.movies.map((movie: IMovie) => (
                    <li className="flex justify-between items-center min-w-[500px] px-4 py-4 gap-4 w-60 h-12 rounded-md text-xl uppercase bg-white bg-opacity-20 shadow-[0_4px_0_rgb(0,0,0)]" key={movie.id}>
                        {movie.emoji} {movie.title} {movie.rating.toFixed(1)}
                        <StarButton handleAddToFavorites={handleAddToFavorites} add={movie} />
                    </li>
                ))}
            </ul>
        </div>
    )
}

export default MoviesResults
