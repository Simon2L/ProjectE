import { FormEvent, useState } from "react";
import { signup } from "../../authentication";
import TextField from "@mui/material/TextField";
import { Button } from "@mui/material";
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
        <>
            <form onSubmit={handleSubmit}>
                <h2>Signup now!</h2>
                <TextField
                    className="input"
                    label="Username" 
                    variant="standard" 
                    onChange={e => setUsername(e.target.value)}
                />
                <br/>
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
                <Button type="submit" variant="contained">Signup!</Button>
            </form>
        </>
    )
}

export default Signup;