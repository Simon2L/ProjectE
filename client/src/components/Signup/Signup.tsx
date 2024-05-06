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
        <form onSubmit={handleSubmit}>
            <h2>Signup now!</h2>

            <label>Username</label>
            <input onChange={e => setUsername(e.target.value)} name="Username" type="text"/>

            <label>Email</label>
            <input onChange={e => setEmail(e.target.value)} name="Email" type="email"/>

            <label>Password</label>
            <input onChange={e => setPassword(e.target.value)} name="Password" type="password"/>

            <button>Signup!</button>
        </form>
    )
}

export default Signup;