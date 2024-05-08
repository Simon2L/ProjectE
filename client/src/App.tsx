import './App.css'
import Signup from './components/Signup/Signup'
import Login from './components/Login/Login'
import Header from './components/Header/Header'
import Main from './components/Main/Main'
import Footer from './components/Footer/Footer'
import { BrowserRouter, Routes, Route } from 'react-router-dom'

function App() {

  return (
    <BrowserRouter>
      <Header />
      <Routes>
        <Route path='/' element={<Main/>} />
        <Route path='/login' element={<Login/>} />
        <Route path='/signup' element={<Signup/>} />
        <Route path='*' element={<h1 className='text-8xl text-center'>Not Found 😭</h1>}></Route>
      </Routes>
      <Footer />
    </BrowserRouter>
  )
}

export default App
