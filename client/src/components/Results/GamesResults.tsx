//import { IGame, IGameResult } from "../../Interfaces/interfaces"
import { IGame, IGameResult } from "../../Interfaces/interfaces"
import { addGameToFavorites } from "../../utils/gamesService"
import StarButton from "./StarButton"

interface IProps {
    gameResults: IGameResult | undefined
}
const GamesResults = (props: IProps) => {
    const handleAddToFavorites = (game: IGame, isFavorite: boolean) => {
        if (isFavorite) {
            //removeGameFromFavorites(game.id)
        } else {
            addGameToFavorites({ id: game.id, name: game.name, rating: game.rating, emoji: game.emoji })
        }
    }
    return (
        <div>
            <ul className="flex flex-col list-none gap-6 max-h-[366px]">
                {props.gameResults?.games.map((game: IGame) => (
                    <li className="flex justify-between items-center min-w-[500px] px-4 py-4 gap-4 w-60 h-12 rounded-md text-xl uppercase bg-white bg-opacity-20 shadow-[0_4px_0_rgb(0,0,0)]" key={game.id}>
                        {game.emoji} {game.name} {game.rating}
                        <StarButton handleAddToFavorites={handleAddToFavorites} add={game} />
                    </li>
                ))}
            </ul>
        </div>
    )
}

export default GamesResults
