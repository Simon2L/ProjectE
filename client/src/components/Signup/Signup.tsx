import { FormEvent, useState } from "react";
import { signup } from "../../authentication";

const Signup = () => {
    const [username, setUsername] = useState("")
    const [email, setEmail] = useState("")
    const [password, setPassword] = useState("")

    const handleSubmit = async (event: FormEvent<HTMLFormElement>) => {
        event.preventDefault()
        const response = await signup({ username: username, email: email, password: password })
        response
    }

    return (
        <div className="grid place-items-center">
            <form className="flex flex-col max-w-sm justify-center items-center gap-4" onSubmit={handleSubmit}>

                <label className="text-xl mr-2">Username 🧑‍🍳</label>
                <input className="p-2 text-xl rounded-md min-h-11" onChange={e => setUsername(e.target.value)} type="text" />

                <label className="text-xl mr-2">Email 📧</label>
                <input className="p-2 text-xl rounded-md min-h-11" onChange={e => setEmail(e.target.value)} type="email" />

                <label className="text-xl mr-2">Password 🔑</label>
                <input className="p-2 text-xl rounded-md min-h-11" onChange={e => setPassword(e.target.value)} type="password" />

                <button className="max-w-24 min-w-24 min-h-8 rounded-md bg-indigo-600 text-white hover:bg-cyan-600">Signup!</button>
            </form>
        </div>
    )
}

export default Signup;