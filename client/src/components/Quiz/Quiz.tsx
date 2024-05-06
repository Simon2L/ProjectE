import { useState } from "react"
import { musicQuestions } from "../../contexts/questions"
import { IEmojiAnswers, IMovie, IMovieResult, IQuiz, ISong, ISongResult } from "../../Interfaces/interfaces"
import { addSongToFavorites, songResult } from "../../utils/musicService"
import { movieResult } from "../../utils/movieService"
import './Quiz.css'

interface IProps {
  quizQuestions : IQuiz
}

const Quiz = (props : IProps) => {
  const [currentQuestion, setCurrentQuestion] = useState(0)
  const [answers, setAnswers] = useState<IEmojiAnswers>({firstEmoji:"", secondEmoji:"", thirdEmoji:""})
  const [disableButton, setDisableButton] = useState(false)
  
  const [songResults, setSongsResults] = useState<ISongResult>()
  const [movieResults, setMovieResults] = useState<IMovieResult>()

  const handleNextQuestion = (selectedAnswer : string) => {
    const nextQuestion = currentQuestion + 1
    if (nextQuestion === musicQuestions.questions.length) {
      getResults(selectedAnswer)
    }
    setCurrentQuestion(nextQuestion)
  }

  const getResults = (selectedAnswer : string) => {
    console.log(props.quizQuestions.topic)
    // TODO: GET RID OF HORRIBLE ANSWERS STUFF
    switch (props.quizQuestions.topic) {
      case "music":
        songResult({...answers, thirdEmoji:selectedAnswer})
          .then(result => setSongsResults(result))
        break
      case "movie":
        movieResult({...answers, thirdEmoji:selectedAnswer})
          .then(result => setMovieResults(result))
        break
      default:
        songResult({...answers, thirdEmoji:selectedAnswer})
        .then(result => setSongsResults(result))
        break
    }
    setDisableButton(true)
  }

  const handleAnswerSelection = (selectedAnswer : string) => {
    if (disableButton) {
      return
    }

    const names : string[] = ["firstEmoji", "secondEmoji", "thirdEmoji"]
    setAnswers(prevState => ({
      ...prevState,
      [names[currentQuestion]]: selectedAnswer
    }));

    console.log(answers)
    console.log(selectedAnswer)
  
    handleNextQuestion(selectedAnswer)
  }

  const handleAddToFavorites = (song : ISong) => {
    addSongToFavorites(song)
  }

  return (
    <>
    {!disableButton &&
      <div className="quiz">
        <h2 className="quiz__title">{props.quizQuestions.topic.toUpperCase()}</h2>
        <ul>
          {props.quizQuestions.questions[currentQuestion].choices.map((choice, index) => (
            <li key={index}>
              <button disabled={disableButton} value={choice} onClick={() => handleAnswerSelection(choice)}>{choice}</button>
            </li>
          ))}
        </ul>
      </div>}
      <button onClick={() => console.log(answers)}>Console</button>

      <div>
        <ul>
          {songResults?.music.map((song : ISong) => (
            <li key={song.id}>
              <button onClick={() => handleAddToFavorites(song)}>⭐</button>
              {song.artist} {song.songName} {song.emoji}
            </li>
          ))}
        </ul>
      </div>
      <div>
        <ul>
          {movieResults?.movies.map((movie : IMovie) => (
            <li key={movie.id}> {movie.title} {movie.rating} {movie.emoji}</li>
          ))}
        </ul>
      </div>
      

    </>
  )
}
export default Quiz;

