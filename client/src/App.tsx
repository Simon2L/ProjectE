import './App.css'
import Signup from './components/Signup/Signup'
import Login from './components/Login/Login'
import Header from './components/Header/Header'
import Main from './components/Main/Main'

function App() {

  return (
    <>
    <h1 className="text-3xl font-bold underline">
      Hello world!
    </h1>
      <Header />
      <Main />
      <Signup />
      <Login />
    </>
  )
}

export default App
