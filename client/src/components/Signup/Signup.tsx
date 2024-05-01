import { FormEvent, useState } from "react";
import { ISignupDetails } from "../../Interfaces/ISignupDetails";
import { signup } from "../../authentication";

const Signup = () => {

    const [signupDetails, setSignupDetails] = useState<ISignupDetails>({ Username: "", Email: "", Password: "" });

    const handleSubmit = async (event : FormEvent<HTMLFormElement>) => {
        event.preventDefault();
        const response = await signup(signupDetails);
        console.log(response);
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