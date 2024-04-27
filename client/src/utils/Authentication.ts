import { ILoginDetails } from "../Interfaces/ILoginDetails";
import { ISignupDetails } from "../Interfaces/ISignupDetails";

const BASE_URL = "https://localhost:7194";

export const login = async (signupDetails : ILoginDetails) => {
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

export const signup = async (signupDetails : ISignupDetails) => {
    const response = await fetch(`${BASE_URL}/users`, {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(signupDetails)
    });
    return handleResponse(response);
};

const handleResponse = (response : Response) : Promise<string> => {
    if (response.ok) {
      return response.json(); 
    }
    return Promise.reject(`Error: ${response.status}`);
};
