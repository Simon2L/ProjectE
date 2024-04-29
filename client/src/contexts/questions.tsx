interface IQuiz {
  topic : string
  questions : IQuestion[]
}

interface IQuestion {
  question : string,
  choices : string[]
}


export const quizQuestions : IQuiz = {
  topic: 'Music',
  questions: [
    {
      question: 'Pick the set of emojis!',
      choices: ['⚡️💭👑', '🎶💔♠️', '💉👩‍👧‍👧🎉'],
    },
    {
      question: 'Pick the set of emojis!',
      choices: ['📺🦓🍭', '💎🤵👱‍♀️', '👞🎷🌑'],
    },
    {
      question: 'Pick the set of emojis!',
      choices: ['🥁👊🔍', '🪞🧱👫', '💖🌹🎸'],
    },
  ],
}

/*
⚡️💭👑
🎶💔♠️
💉👩‍👧‍👧🎉

📺🦓🍭
💎🤵👱‍♀️
👞🎷🌑

🥁👊🔍
🪞🧱👫
💖🌹🎸

🖤😈🏆
👸🎵🚀
🍑👩👨‍👩‍👦‍👦
🏃‍♂️🧟🌃
🕴️🔫🌟
👀💕⚫
⚪🚫👎
🌬️👣⏰
🔄🚢📅
🍂🌧️🙏
🔥🤝💃
👩‍❤️‍👨👁️🐅
🛣️🎤🌍
👨‍🎨👨📶
*/