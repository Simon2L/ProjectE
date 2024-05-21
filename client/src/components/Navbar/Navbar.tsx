import { useContext } from "react"
import { Link } from "react-router-dom"
import CurrentUserContext from "../../contexts/user"
interface IProps {
  logout() : void
}

const Navbar = (props : IProps) => {
    const user = useContext(CurrentUserContext)

    return (
        <div className="flex gap-6 text-lg py-3 font-nunito uppercase font-bold">
          <Link className="px-3 py-1 shadow-[0_7px_0_rgb(0,0,0)] hover:shadow-[0_3px_0px_rgb(0,0,0)] text-black bg-white bg-opacity-20 ease-out hover:translate-y-1 transition-all rounded" to="/">Home🏠</Link>
          {(user === undefined) ? (
            <>
            <Link className="px-3 py-1 shadow-[0_7px_0_rgb(0,0,0)] hover:shadow-[0_3px_0px_rgb(0,0,0)] text-black bg-white bg-opacity-20 ease-out hover:translate-y-1 transition-all rounded" to="/login">Login👋</Link>
            <Link className="px-3 py-1 shadow-[0_7px_0_rgb(0,0,0)] hover:shadow-[0_3px_0px_rgb(0,0,0)] text-black bg-white bg-opacity-20 ease-out hover:translate-y-1 transition-all rounded" to="/signup">Signup🤝</Link>
            </>
          ) : (
            <>
            <Link className="px-3 py-1 shadow-[0_7px_0_rgb(0,0,0)] hover:shadow-[0_3px_0px_rgb(0,0,0)] text-black bg-white bg-opacity-20 ease-out hover:translate-y-1 transition-all rounded" to="/favorites">Favorites⭐</Link>
            <h2>Welcome {user.username}!</h2>
            <button onClick={props.logout} className="px-2 py-1 shadow-[0_7px_0_rgb(0,0,0)] hover:shadow-[0_3px_0px_rgb(0,0,0)] text-black bg-white bg-opacity-20 ease-out hover:translate-y-1 transition-all rounded">Logout</button>
            </>
          )}
        </div>
    )
}

export default Navbar