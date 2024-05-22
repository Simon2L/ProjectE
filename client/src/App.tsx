import './App.css'
import Signup from './components/Signup/Signup'
import Login from './components/Login/Login'
import Main from './components/Main/Main'
import Favorites from './components/Favorites/Favorites'
import { BrowserRouter, Routes, Route } from 'react-router-dom'
import Navbar from './components/Navbar/Navbar'
import CurrentUserContext, { IUser } from './contexts/user'
import { useEffect, useState } from 'react'
import Header from './components/Header/Header'
import Footer from './components/Footer/Footer'

function App() {
  const [currentUser, setCurrentUser] = useState<IUser>()

  const setUserContext = (user: IUser) => {
    setCurrentUser(user);
  }

  useEffect(() => {
    if (sessionStorage.getItem("email") && sessionStorage.getItem("username")) {
      setCurrentUser({username: sessionStorage.getItem("email") ?? undefined, email: sessionStorage.getItem("email") ?? undefined})
    }
  },[])

  const logout = () => {
    setCurrentUser(undefined)
    sessionStorage.clear();
  }
  

  return (
    <CurrentUserContext.Provider value={currentUser}>
      <BrowserRouter>
        <Navbar logout={logout}/>
        <Header />
        <Routes>
          <Route path="/" element={<Main />} />
          <Route path="/login" element={<Login setUserContext={setUserContext} />} />
          <Route path="/signup" element={<Signup />} />
          <Route path='/favorites' element={<Favorites />} />
          <Route path="*" element={<h1 className="text-8xl text-center">Not Found 😭</h1>}></Route>
        </Routes>
        <Footer />
      </BrowserRouter>
    </CurrentUserContext.Provider>
  )
}

export default App
