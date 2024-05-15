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
                    <li className="flex justify-between items-center min-w-[500px] px-4 py-4 gap-4 w-60 h-12 rounded-md text-xl uppercase bg-white bg-opacity-20 shadow-[0_4px_0_rgb(0,0,0)]" key={game.id}>
                        {game.emoji} {game.name} {game.publishYear}
                        <StarButton handleAddToFavorites={handleAddToFavorites} add={game} />
                    </li>
                ))}
            </ul>
        </div>
    )
}

export default GamesResults
