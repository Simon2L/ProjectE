import './App.css'
import Signup from './components/Signup/Signup'
import Login from './components/Login/Login'
import Header from './components/Header/Header'
import Main from './components/Main/Main'
import {pageTheme} from './themes/page.css'
import ThemeProvider from '@mui/material/styles/ThemeProvider'

function App() {
  const theme = pageTheme;

  return (
    
    <ThemeProvider theme={theme}>
      <Header />
      <Main />
      <Signup />
      <Login />
    </ThemeProvider>
  )
}

export default App
