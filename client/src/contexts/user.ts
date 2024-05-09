import { createContext } from "react";

export interface IUser {
    username: string, 
    email: string,
    //isLoggedIn: boolean
}
const CurrentUserContext = createContext<IUser | undefined>(undefined)
export default CurrentUserContext