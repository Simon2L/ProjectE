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
    <main className="flex flex-col items-center content-between min-h-[40vh] font-nunito uppercase text-xl font-bold">
      {(buttonIsPressed === false) ? (
        <>
        <h4 className="mb-14">Pick an emoji to start the quiz</h4>
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
          <button className="mt-9 uppercase text-lg px-3 py-1 shadow-[0_4px_0_rgb(0,0,0)] hover:shadow-[0_3px_0px_rgb(0,0,0)] text-black bg-white bg-opacity-20 ease-out hover:translate-y-1 transition-all rounded" onClick={() => setButtonIsPressed(false)}>Return🙅</button>
        </>
      )}
    </main>
  )
}

export default Main