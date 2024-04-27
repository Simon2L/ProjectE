import { FormEvent, useState } from "react";


export const handleResponse = (response : Response) : Promise<string> => {
    if (response.ok) {
        const token  = response.json(); 
      return token;
    }
    return Promise.reject(`Error: ${response.status}`);
};

export const login = async (signupDetails : ILoginDetails) => {
    const BASE_URL = "https://localhost:7194"
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