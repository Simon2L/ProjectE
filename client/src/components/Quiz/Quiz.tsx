import { useState } from "react"
import { musicQuestions } from "../../contexts/questions"
import { IEmojiAnswers, IMovieResult, IQuiz, ISongResult } from "../../Interfaces/interfaces"
import { songResult } from "../../utils/musicService"
import { movieResult } from "../../utils/movieService"
import SongResults from "../Results/SongsResults"
import MoviesResults from "../Results/MoviesResults"

interface IProps {
  quizQuestions: IQuiz
}

const Quiz = (props: IProps) => {
  const [currentQuestion, setCurrentQuestion] = useState(0)
  const [answers, setAnswers] = useState<IEmojiAnswers>({ firstEmoji: "", secondEmoji: "", thirdEmoji: "" })
  const [disableButton, setDisableButton] = useState(false)

  const [songResults, setSongsResults] = useState<ISongResult>()
  const [movieResults, setMovieResults] = useState<IMovieResult>()

  const handleNextQuestion = (selectedAnswer: string) => {
    const nextQuestion = currentQuestion + 1
    if (nextQuestion === musicQuestions.questions.length) {
      getResults(selectedAnswer)
    }
    setCurrentQuestion(nextQuestion)
  }

  const getResults = (selectedAnswer: string) => {
    console.log(props.quizQuestions.topic)
    // TODO: GET RID OF HORRIBLE ANSWERS STUFF
    switch (props.quizQuestions.topic) {
      case "music":
        songResult({ ...answers, thirdEmoji: selectedAnswer })
          .then(result => setSongsResults(result))
        break
      case "movie":
        movieResult({ ...answers, thirdEmoji: selectedAnswer })
          .then(result => setMovieResults(result))
        break
      default:
        songResult({ ...answers, thirdEmoji: selectedAnswer })
          .then(result => setSongsResults(result))
        break
    }
    setDisableButton(true)
  }

  const handleAnswerSelection = (selectedAnswer: string) => {
    if (disableButton) {
      return
    }

    const names: string[] = ["firstEmoji", "secondEmoji", "thirdEmoji"]
    setAnswers(prevState => ({
      ...prevState,
      [names[currentQuestion]]: selectedAnswer
    }));

    console.log(answers)
    console.log(selectedAnswer)

    handleNextQuestion(selectedAnswer)
  }

  return (
    <>
      {!disableButton &&
        <div>
          <h4 className="text-center mb-10">Pick an emoji related to: {props.quizQuestions.topic}</h4>
          <ul className="flex flex-col items-center list-none gap-6">
            {props.quizQuestions.questions[currentQuestion].choices.map((choice, index) => (
              <li key={index}>
                <button className="text-7xl hover:scale-110 ease-in duration-150" 
                disabled={disableButton} value={choice} onClick={() => handleAnswerSelection(choice)}>{choice}</button>
              </li>
            ))}
          </ul>
        </div>}
      {/* <button onClick={() => console.log(answers)}>Console</button> */}

      {songResults && <SongResults songResults={songResults} />}
      {movieResults && <MoviesResults movieResults={movieResults} />}

    </>
  )
}
export default Quiz;

