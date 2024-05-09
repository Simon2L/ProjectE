import './App.css'
import Signup from './components/Signup/Signup'
import Login from './components/Login/Login'
import Header from './components/Header/Header'
import Main from './components/Main/Main'
import Favorites from './components/Favorites/Favorites'
import Footer from './components/Footer/Footer'
import { BrowserRouter, Routes, Route } from 'react-router-dom'
import Navbar from './components/Navbar/Navbar'
import CurrentUserContext, { IUser } from './contexts/user'
import { useState } from 'react'

function App() {
  const [currentUser, setCurrentUser] = useState<IUser>()

  const setUserContext = (user: IUser) => {
    setCurrentUser(user);
  }

  return (
    <CurrentUserContext.Provider value={currentUser}>
      <BrowserRouter>
        <Navbar />
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
