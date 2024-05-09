import { ILoginDetails, ISignupDetails } from "./Interfaces/ISignupDetails";



const BASE_URL = "https://localhost:7194"


export const login = async (signupDetails: ILoginDetails) => {
    try {
        const response = await fetch(`${BASE_URL}/users/login`, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(signupDetails)
        });
        return handleResponse(response);
    } catch {
        return false
    }
};

export const signup = async (signupDetails: ISignupDetails) => {
    try {
        const response = await fetch(`${BASE_URL}/users`, {
            method: 'POST',
            headers: {
                'Accept': 'application/json',
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(signupDetails)
        });
        return handleResponse(response);
    } catch {
        return false
    }
};

const handleResponse = async (response: Response): Promise<boolean> => {
    if (response.ok) {
        const token = await response.json()
        sessionStorage.setItem("token", token)
        return response.ok;
    }
    return false;
};
