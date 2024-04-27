import { FormEvent, useState } from "react";

export const handleResponse = (res : Response) => {
    if (res.ok) {
      return res.json();
    }
    return Promise.reject(`Error: ${res.status}`);
};

export const signup = (signupDetails : ISignupDetails) => {
    const BASE_URL = "https://localhost:7194"
    /*return*/ fetch(`${BASE_URL}/users`, {
      method: 'POST',
      headers: {
        'Accept': 'application/json',
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(signupDetails)
    })
      //.then(handleResponse)
};

interface ISignupDetails {
    Username : string,
    Email : string,
    Password : string
}

const Signup = () => {

    const [signupDetails, setSignupDetails] = useState<ISignupDetails>({ Username: "", Email: "", Password: "" });

    const handleSubmit = (event : FormEvent<HTMLFormElement>) => {
        event.preventDefault();
        console.log(signupDetails);
        signup(signupDetails);
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
                <h2>Signup now!</h2>

                <label>Username</label>
                <input onChange={event => handleInputChange(event)} name="Username" type="text"/>

                <label>Email</label>
                <input onChange={event => handleInputChange(event)} name="Email" type="email"/>

                <label>Password</label>
                <input onChange={event => handleInputChange(event)} name="Password" type="password"/>

                <button>Signup!</button>
            </form>
        </>
    )
}

export default Signup;