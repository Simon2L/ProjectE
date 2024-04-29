import { useState } from "react"
import { quizQuestions } from "../../contexts/questions"

interface IEmojiAnswers {
  firstEmoji : string,
  secondEmoji : string,
  thirdEmoji : string
}

interface ISong {
  id: string,
  songName: string,
  artist: string
  emoji: string
}

interface ISongResult {
  music: ISong[]
}

const BASE_URL = "https://localhost:7194";

 const songResult = async (emojiAnswers : IEmojiAnswers) : Promise<ISongResult>  => {
  const response = await fetch(`${BASE_URL}/music`, {
      method: 'GET',
      headers: {
          'Accept': 'application/json',
          'Content-Type': 'application/json'
      },
      body: JSON.stringify(emojiAnswers)
  });
  if (response.ok) {
      console.log("RESPONSE: " + response.json())
      return response.json();
  }
  else {
      console.log(emojiAnswers);
      console.log("Getting default songs");
      const defaultSongs : ISongResult = { music: getSongs() }
      return defaultSongs;
  }
}

const getSongs = () : ISong[] => {
  return [
      {id: "1", songName: "Don't stop the Music", artist: "Pirhana", emoji: "🍭"},
      {id: "2", songName: "Levels", artist: "Avicci", emoji: "🦓"},
      {id: "3", songName: "Poop", artist: "shit", emoji: "📺"},
      {id: "4", songName: "Valorant", artist: "xdd", emoji: "👑"},
      {id: "5", songName: "What am I even typing", artist: "lil bro", emoji: "⚡️💭"},
  ]
}

const Quiz = () => {
  const [currentQuestion, setCurrentQuestion] = useState(0)
  const [answers, setAnswers] = useState<IEmojiAnswers>({firstEmoji:"", secondEmoji:"", thirdEmoji:""})
  const [songResults, setSongsResults] = useState<ISongResult>()
  
  const handleNextQuestion = (selectedAnswer : string) => {
    const nextQuestion = currentQuestion + 1
    if (nextQuestion >= 3) {
      songResult({...answers, thirdEmoji:selectedAnswer}).then(songResults => setSongsResults(songResults));

      return;
    }
    setCurrentQuestion(nextQuestion)
  }

  const handleAnswerSelection = (questionIndex : number, selectedAnswer : string) => {

    const names : string[] = ["firstEmoji", "secondEmoji", "thirdEmoji"];

    setAnswers(prevState => ({
      ...prevState,
      [names[questionIndex]]: selectedAnswer
    }));
  
    handleNextQuestion(selectedAnswer); 

  }

  const consoleLog = () => {
    console.log(songResults);
  }

  return (
    <>
    <div className="quiz">
      <h2 className="quiz__title">/*Questionary or Results*/</h2>
      <ul>
        {quizQuestions.questions[currentQuestion].choices.map((choice, index) => (
          <li key={index}>
            <button value={choice} onClick={() => handleAnswerSelection(currentQuestion, choice)}>{choice}</button>
          </li>
        ))}
      </ul>
      <button onClick={consoleLog}>Console Log</button>
    </div>
    <div>
        <ul>
          {songResults?.music.map((song : ISong) => (
            <li key={song.id}> {song.artist} {song.songName} {song.emoji}</li>
          ))}
        </ul>
    </div>
    </>
  )
}
export default Quiz;

