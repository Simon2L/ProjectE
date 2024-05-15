import { IMovie, IMovieResult } from "../../Interfaces/interfaces"
import StarButton from "./StarButton"

interface IProps {
    movieResults: IMovieResult | undefined
}
const MoviesResults = (props: IProps) => {
    const handleAddToFavorites = (movie: IMovie) => {
        movie
    }
    return (
        <div>
            <ul className="flex flex-col list-none gap-6 max-h-[366px]">
                {props.movieResults?.movies.map((movie: IMovie) => (
                    <li className="flex justify-between items-center min-w-[600px] px-4 py-2 gap-4 w-60 h-16 rounded-md text-2xl uppercase bg-white bg-opacity-20 shadow-[0_4px_0_rgb(0,0,0)]" key={movie.id}>
                        {movie.emoji} {movie.title} {movie.rating}
                        <StarButton handleAddToFavorites={handleAddToFavorites} add={movie} />
                    </li>
                ))}
            </ul>
        </div>
    )
}

export default MoviesResults
