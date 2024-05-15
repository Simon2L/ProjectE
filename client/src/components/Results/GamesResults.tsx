//import { IGame, IGameResult } from "../../Interfaces/interfaces"
import { IGame, IGameResult } from "../../Interfaces/interfaces"
import StarButton from "./StarButton"

interface IProps {
    gameResults: IGameResult | undefined
}
const GamesResults = (props: IProps) => {
    const handleAddToFavorites = (game: IGame) => {
        game
    }
    return (
        <div>
            <ul className="flex flex-col list-none gap-6 max-h-[366px]">
                {props.gameResults?.games.map((game: IGame) => (
                    <li className="flex justify-between items-center min-w-[600px] px-4 py-2 gap-4 w-60 h-16 rounded-md text-2xl uppercase bg-white bg-opacity-20 shadow-[0_4px_0_rgb(0,0,0)]" key={game.id}>
                        {game.emoji} {game.name} {game.publishYear}
                        <StarButton handleAddToFavorites={handleAddToFavorites} add={game} />
                    </li>
                ))}
            </ul>
        </div>
    )
}

export default GamesResults
