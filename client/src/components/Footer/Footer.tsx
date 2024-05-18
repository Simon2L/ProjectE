import github from "../../assets/github.png"

const Footer = () => {
  return (
    <footer className="font-nunito uppercase font-semibold">
      <ul>
        <li>
          <a href="https://github.com/Simon2L"><img className="w-4" src={github}/>Simon</a>
        </li>
        <li>
          <a href="https://github.com/m0chimoon"><img className="w-4" src={github} />M0chi</a>
        </li>
      </ul>
    </footer>
  )
}

export default Footer
