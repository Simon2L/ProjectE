import { createContext } from "react";

export interface IUser {
    username: string | undefined, 
    email: string | undefined,
    //isLoggedIn: boolean
}
const CurrentUserContext = createContext<IUser | undefined>(undefined)
export default CurrentUserContext