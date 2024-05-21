import github from "../../assets/github.png"

const Footer = () => {
  return (
    <footer className="fixed bottom-0 font-nunito uppercase font-semibold mt-auto mb-4">
      <ul className="flex flex-row items-center gap-2 text-base">
        <li>
        <a href="https://github.com/Simon2L">Simon</a>
        </li>
        <li>
          <img className="w-5" src={github} />
        </li>
        <li>
          <a href="https://github.com/m0chimoon">M0chi</a>
        </li>
      </ul>
    </footer>
  )
}

export default Footer
