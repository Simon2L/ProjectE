import { FormEvent, useState } from "react";
import { signup } from "../../authentication";
import './Signup.css';

const Signup = () => {
    const [username, setUsername] = useState("")
    const [email, setEmail] = useState("")
    const [password, setPassword] = useState("")

    const handleSubmit = async (event : FormEvent<HTMLFormElement>) => {
        event.preventDefault()
        const response = await signup({username: username, email: email, password: password})
        console.log(response)
    }

    return (
        <form className="flex flex-col max-w-sm justify-center items-center gap-4" onSubmit={handleSubmit}>
            <h2 className="text-4xl">Signup now!</h2>

            <label className="text-xl mr-2">Username</label>
            <input className="text-xl rounded-md min-h-11" onChange={e => setUsername(e.target.value)} name="Username" type="text"/>

            <label className="text-xl mr-2">Email</label>
            <input className="text-xl rounded-md min-h-11" onChange={e => setEmail(e.target.value)} name="Email" type="email"/>

            <label className="text-xl mr-2">Password</label>
            <input className="text-xl rounded-md min-h-11" onChange={e => setPassword(e.target.value)} name="Password" type="password"/>

            <button className="max-w-24 min-w-24 min-h-8 rounded-md bg-indigo-600 text-white hover:bg-cyan-600">Signup!</button>
        </form>
    )
}

export default Signup;