import { useState } from "react"
import Quiz from "../Quiz/Quiz"
import { gameQuestions, musicQuestions, movieQuestions } from "../../contexts/questions"
import { IQuiz } from "../../Interfaces/interfaces"

const Main = () => {
  const [buttonIsPressed, setButtonIsPressed] = useState(false)
  const [questionType, setQuestionType] = useState<IQuiz>(musicQuestions)

  const onButtonClick = (topic : string) => {
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
    <>
    {(buttonIsPressed === false) ? (
      <div className="main">
        <ul className="main__menu">
          <li className="main__menu-item">
            <button value="music" className="main__menu-btn" onClick={(event) =>  onButtonClick(event.currentTarget.value)}>🎮</button>
          </li>
          <li className="main__menu-item">
            <button value="movie" className="main__menu-btn" onClick={(event) =>  onButtonClick(event.currentTarget.value)}/>
          </li>
          <li className="main__menu-item">
            <button value="game" className="main__menu-btn" onClick={(event) =>  onButtonClick(event.currentTarget.value)}/>
          </li>
        </ul>
      </div>
    ) : (
    <Quiz quizQuestions={questionType}/>
    )}
  </>
  )
}

export default Main