import { IMovie, IMovieResult } from "../../Interfaces/interfaces"
import star from "../../assets/star.svg"
import filledStar from  "../../assets/star-filled.svg"
import { useState } from "react"

interface IProps {
    movieResults: IMovieResult | undefined
}
const MoviesResults = (props: IProps) => {
    const [isFavorite, setIsFavorite] = useState(false);
    const handleAddToFavorites = (movie: IMovie) => {
        console.log(movie)
        setIsFavorite((previous) => !previous)
        //addMovieToFavorites(movie)
    }

    return (
        <div>
            <ul className="flex flex-col list-none gap-6">
                {props.movieResults?.movies.map((movie: IMovie) => (
                    <li className="flex justify-between items-center min-w-[600px] px-4 py-2 gap-4 w-60 h-16 rounded-md bg-transparent
                    bg-opacity-70 text-2xl uppercase border-[3px] border-black" key={movie.id}>
                        {movie.id} {movie.title} {movie.rating} {movie.emoji}
                        <button className="hover:scale-110 ease-in duration-150 hover:hue-rotate-0" onClick={() => handleAddToFavorites(movie)}>
                            <img className="max-w-[24px] max-h-[24px]" src={isFavorite ? filledStar : star} />
                        </button>
                    </li>
                ))}
            </ul>
        </div>
    )
}

export default MoviesResults
