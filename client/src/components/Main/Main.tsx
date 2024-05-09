import { useState } from "react"
import Quiz from "../Quiz/Quiz"
import { gameQuestions, musicQuestions, movieQuestions } from "../../contexts/questions"
import { IQuiz } from "../../Interfaces/interfaces"

const Main = () => {
  const [buttonIsPressed, setButtonIsPressed] = useState(false)
  const [questionType, setQuestionType] = useState<IQuiz>(musicQuestions)

  const onButtonClick = (topic: string) => {
    setButtonIsPressed(!buttonIsPressed)
    switch (topic) {
      case "music":
        setQuestionType(musicQuestions)
        break
      case "movie":
        setQuestionType(movieQuestions)
        break
      case "game":
        setQuestionType(gameQuestions)
        break
      default:
        setQuestionType(musicQuestions)
        break
    }
  }

  return (
    <main className="flex flex-col items-center min-h-[50vh] font-nunito text-2xl font-medium">
      {(buttonIsPressed === false) ? (
        <>
        <h4 className="mb-12">Pick emoji to start the quiz!</h4>
        <ul className="flex flex-row list-none gap-10">
          <li>
            <button value="music" className="text-8xl hover:scale-110 ease-in duration-150" onClick={(event) => onButtonClick(event.currentTarget.value)}>🎧</button>
          </li>
          <li>
            <button value="movie" className="text-8xl hover:scale-110 ease-in duration-150" onClick={(event) => onButtonClick(event.currentTarget.value)}>🍿</button>
          </li>
          <li>
            <button value="game" className="text-8xl hover:scale-110 ease-in duration-150" onClick={(event) => onButtonClick(event.currentTarget.value)}>🎮</button>
          </li>
        </ul>
        </>
      ) : (
        <>        
          <Quiz quizQuestions={questionType} />
          <button className=" bg-white bg-opacity-20 border-[3px] border-black p-3 rounded-lg mt-20 uppercase" onClick={() => setButtonIsPressed(false)}>Return</button>
        </>
      )}
    </main>
  )
}

export default Main