import { FormEvent, useState } from "react";
import { login } from "../../authentication";
import { IUser } from "../../contexts/user";
import { useNavigate } from "react-router-dom";

interface IProps {
    setUserContext(user: IUser): void
}

const Login = (props: IProps) => {
    const [email, setEmail] = useState("")
    const [password, setPassword] = useState("")
    const [unathorized, setUnatharized] = useState(false)
    const [disableButton, setDisableButton] = useState(false);
    const navigate = useNavigate()

    const handleSubmit = async (event: FormEvent<HTMLFormElement>) => {
        event.preventDefault();
        setDisableButton(true)

        const loginSuccess = await login({ email: email, password: password })
        console.log(loginSuccess)
        if (loginSuccess) {
            console.log("LOGIN SUCCESSFUL!")
            props.setUserContext({ username: email, email: email })
            navigate("/")
        }
        else {
            console.log("UNATHURIZED")
            setUnatharized(true)
            setDisableButton(false);
        }
        //localStorage.setItem('jwt', token)

    }

    return (
        <div className="grid place-items-center">
            <form className="flex flex-col max-w-sm justify-center items-center gap-4" onSubmit={handleSubmit}>
                <h2 className="text-4xl">Login now!</h2>

                <label className="text-xl mr-2">Email</label>
                <input className="p-2 text-xl rounded-md min-h-11" onChange={e => setEmail(e.target.value)} type="email" />

                <label className="text-xl mr-2">Password</label>
                <input className="p-2 text-xl rounded-md min-h-11" onChange={e => setPassword(e.target.value)} type="password" />

                <button disabled={disableButton} className="max-w-24 min-w-24 min-h-8 rounded-md bg-indigo-600 text-white hover:bg-cyan-600">Login!</button>
                {unathorized && <span className=" text-red-600 p-2 bg-white rounded-lg">Incorrect email or password</span>}
            </form>
        </div>
    )
}

export default Login;