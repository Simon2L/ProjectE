import { IMovie, IMovieResult } from "../../Interfaces/interfaces"
import StarButton from "./StarButton"

interface IProps {
    movieResults: IMovieResult | undefined
}
const MoviesResults = (props: IProps) => {
    const handleAddToFavorites = (movie: IMovie) => {

    }
    return (
        <div>
            <ul className="flex flex-col list-none gap-6">
                {props.movieResults?.movies.map((movie: IMovie) => (
                    <li className="flex justify-between items-center min-w-[600px] px-4 py-2 gap-4 w-60 h-16 rounded-md text-2xl uppercase bg-white bg-opacity-20 shadow-[0_4px_0_rgb(0,0,0)]" key={movie.id}>
                        {movie.id} {movie.title} {movie.rating} {movie.emoji}
                        <StarButton handleAddToFavorits={handleAddToFavorites} add={movie} />
                    </li>
                ))}
            </ul>
        </div>
    )
}

export default MoviesResults
