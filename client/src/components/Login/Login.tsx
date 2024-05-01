import { FormEvent, useState } from "react";
import { ILoginDetails } from "../../interfaces/ILoginDetails";
import { login } from "../../utils/authentication";


const Login = () => {

    const [signupDetails, setSignupDetails] = useState<ILoginDetails>({Email: "", Password: "" });

    const handleSubmit = async (event : FormEvent<HTMLFormElement>) => {
        event.preventDefault();
        const token = await login(signupDetails);
        
        if (token) {
            console.log("LOGIN SUCCESSFUL!")
            console.log(token);
        }
        else {
            console.log("ILLEGAL POLICE COMING YOUR WAY")
            console.log(token);
        }
        //setLoggedIn(true);
        localStorage.setItem('jwt', token);

    }

    const handleInputChange = (event : React.ChangeEvent<HTMLInputElement>) => {
        event.preventDefault();

        const { name, value } = event.target;
        setSignupDetails(prevState => ({
            ...prevState,
            [name]: value
        }));
    }

    return (
        <>
            <form onSubmit={handleSubmit}>
                <h2>Login now!</h2>

                <label>Email</label>
                <input onChange={event => handleInputChange(event)} name="Email" type="email"/>

                <label>Password</label>
                <input onChange={event => handleInputChange(event)} name="Password" type="password"/>

                <button>Login!</button>
            </form>
        </>
    )
}

export default Login;