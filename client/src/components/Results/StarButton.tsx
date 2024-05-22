import { IGame, IMovie, ISong } from "../../Interfaces/interfaces"
import star from "../../assets/star.svg"
import filledStar from  "../../assets/filledstar.svg"
import { useState } from "react"

interface IProps {
    add : IMovie | ISong | IGame | any
    handleAddToFavorites(add: unknown, isFavorite: boolean) : void
}

const StarButton = (props : IProps) => {
    const [isFavorite, setIsFavorite] = useState(props.add.isFavoritedByUser ? props.add.isFavoritedByUser : false)

    return (
        <button className="hover:scale-110 ease-in duration-150 hover:hue-rotate-0" onClick={() => {
                    props.handleAddToFavorites(props.add, isFavorite); 
                    setIsFavorite(true)
                }}>
            <img className="max-w-[30px] max-h-[30px]" src={isFavorite ? filledStar : star} />
        </button>
    )
}

export default StarButton