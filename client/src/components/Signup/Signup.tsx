import { FormEvent, useState } from "react";
import { signup } from "../../authentication";
import { useNavigate } from "react-router-dom";

const Signup = () => {
  const [username, setUsername] = useState("")
  const [email, setEmail] = useState("")
  const [password, setPassword] = useState("")
  const navigate = useNavigate()

  const handleSubmit = async (event: FormEvent<HTMLFormElement>) => {
    event.preventDefault()
    const response = await signup({ username: username, email: email, password: password })
      if(response === true){
        navigate("/login");
      } else {
            // Failed to create user
      }
  }

  return (
      <div className="grid place-items-center font-nunito font-bold uppercase">
          <form className="flex flex-col max-w-sm justify-center items-center gap-4" onSubmit={handleSubmit}>

              <label className="text-xl mr-2">Username 🧑‍🍳</label>
              <input className="bg-white p-2 text-xl rounded-md min-h-11" onChange={e => setUsername(e.target.value)} type="text" />

              <label className="text-xl mr-2">Email 📧</label>
              <input className="bg-white p-2 text-xl rounded-md min-h-11" onChange={e => setEmail(e.target.value)} type="email" />

              <label className="text-xl mr-2">Password 🔑</label>
              <input className="bg-white p-2 text-xl rounded-md min-h-11" onChange={e => setPassword(e.target.value)} type="password" />

              <button className="mt-24 uppercase text-lg px-3 py-1 shadow-[0_4px_0_rgb(0,0,0)] hover:shadow-[0_3px_0px_rgb(0,0,0)] text-black bg-white bg-opacity-20 ease-out hover:translate-y-1 transition-all rounded">Signup</button>
          </form>
      </div>
  )
}

export default Signup;