import { useState } from "react"
import { Link } from "react-router-dom"

const Navbar = () => {
    const [loggedIn, setIsLoggedIn] = useState(true)

    return (
        <div className="flex gap-6 text-xl p-3 font-nunito uppercase font-bold">
          {(loggedIn === false) ? (
            <>
            <Link className="px-2 py-1 shadow-[0_9px_0_rgb(0,0,0)] hover:shadow-[0_4px_0px_rgb(0,0,0)] text-black bg-white bg-opacity-20 ease-out hover:translate-y-1 transition-all rounded" to="/login">Login</Link>
            <Link className="px-2 py-1 shadow-[0_9px_0_rgb(0,0,0)] hover:shadow-[0_4px_0px_rgb(0,0,0)] text-black bg-white bg-opacity-20 ease-out hover:translate-y-1 transition-all rounded" to="/signup">Signup</Link>
            </>
          ) : (
            <>
            <Link className="px-2 py-1 shadow-[0_9px_0_rgb(0,0,0)] hover:shadow-[0_4px_0px_rgb(0,0,0)] text-black bg-white bg-opacity-20 ease-out hover:translate-y-1 transition-all rounded" to="/">Home</Link>
            <Link className="px-2 py-1 shadow-[0_9px_0_rgb(0,0,0)] hover:shadow-[0_4px_0px_rgb(0,0,0)] text-black bg-white bg-opacity-20 ease-out hover:translate-y-1 transition-all rounded" to="/favorites">Favorites</Link>
            </>
          )}
        </div>
    )
}

export default Navbar