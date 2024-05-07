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
        <form onSubmit={handleSubmit}>
            <h2>Login now!</h2>

            <label>Email</label>
            <input onChange={e => setEmail(e.target.value)} name="Email" type="email"/>

            <label>Password</label>
            <input onChange={e => setPassword(e.target.value)} name="Password" type="password"/>

            <button>Login!</button>
        </form>
    )
}

export default Login;