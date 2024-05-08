import { Link } from "react-router-dom"

const Navbar = () => {
 //bg-indigo-600 text-white
    return (
        <div className="flex gap-6 text-3xl p-3 bg-gradient-to-r from-purple-600 to-orange-300 text-white">
            <Link className="ml-2" to="/">Home</Link>
            <Link to="/favorites">Favorites</Link>
            <Link to="/login">Login</Link>
            <Link to="/signup">Signup</Link>
        </div>
    )
}

export default Navbar