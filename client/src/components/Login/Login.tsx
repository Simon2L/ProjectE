import { FormEvent, useState } from "react";
import { login } from "../../authentication";


const Login = () => {
    const [email, setEmail] = useState("")
    const [password, setPassword] = useState("")

    const handleSubmit = async (event : FormEvent<HTMLFormElement>) => {
        event.preventDefault();
        const token = await login({email: email, password: password})
        
        // handle token somewhere
        if (token) {
            console.log("LOGIN SUCCESSFUL!")
            console.log(token)
        }
        else {
            console.log("UNATHURIZED")
            console.log(token)
        }
        //setLoggedIn(true);
        localStorage.setItem('jwt', token)

    }

    return (
        <form className="flex flex-col max-w-sm justify-center items-center gap-4" onSubmit={handleSubmit}>
            <h2 className="text-4xl">Login now!</h2>

            <label className="text-xl mr-2">Email</label>
            <input className="p-2 text-xl rounded-md min-h-11" onChange={e => setEmail(e.target.value)} type="email"/>

            <label className="text-xl mr-2">Password</label>
            <input className="p-2 text-xl rounded-md min-h-11" onChange={e => setPassword(e.target.value)} type="password"/>

            <button className="max-w-24 min-w-24 min-h-8 rounded-md bg-indigo-600 text-white hover:bg-cyan-600">Login!</button>
        </form>
    )
}

export default Login;