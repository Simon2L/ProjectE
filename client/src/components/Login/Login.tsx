import { FormEvent, useState } from "react";

interface IToken {
    token : string
}

export const handleResponse = async (response : Response) : Promise<IToken> => {
    if (response.ok) {
        const token : IToken = await response.json(); 
      return token;
    }
    return Promise.reject(`Error: ${response.status}`);
};

export const login = async (signupDetails : ILoginDetails) => {
    const BASE_URL = "https://localhost:7194:"
    const response = await fetch(`${BASE_URL}/users/login`, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(signupDetails)
    });
    return handleResponse(response);
};

interface ILoginDetails {
    Email : string,
    Password : string
}

const Login = () => {

    const [signupDetails, setSignupDetails] = useState<ILoginDetails>({Email: "", Password: "" });

    const handleSubmit = async (event : FormEvent<HTMLFormElement>) => {
        event.preventDefault();
        console.log(signupDetails);
        const user = await login(signupDetails);
        
        if (user.token) {
            console.log("LOGIN SUCCESSFUL!")
            console.log(user.token);
        }
        else {
            console.log("ILLEGAL POLICE COMING YOUR WAY")
            console.log(user.token);
        }
        //setLoggedIn(true);
        localStorage.setItem('jwt', user.token);

    }

    const handleInputChange = (event : React.ChangeEvent<HTMLInputElement>) => {
        event.preventDefault();

        const { name, value } = event.target;
        console.log(name);
        console.log(value)
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