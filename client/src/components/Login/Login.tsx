import { FormEvent, useState } from "react";
import { login } from "../../authentication";
import TextField from "@mui/material/TextField";
import Button from "@mui/material/Button";


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
        <>
            <form onSubmit={handleSubmit}>
                <h2>Login now!</h2>
                <TextField
                    className="input"
                    label="Email" 
                    variant="standard"
                    onChange={e => setEmail(e.target.value)}
                />
                <br/>
                <TextField
                    className="input"
                    label="Password"
                    type="password"
                    autoComplete="current-password"
                    variant="standard"
                    onChange={e => setPassword(e.target.value)}
                />
                <br/>
                <Button type="submit" variant="contained">Login!</Button>
            </form>
        </>
    )
}

export default Login;