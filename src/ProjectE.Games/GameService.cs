using ProjectE.Games.Data;
using ProjectE.Games.GameEndpoints;

namespace ProjectE.Games;

internal class GameService(IGameRepository gameRepository) : IGameService
{
    private readonly IGameRepository _gameRepository = gameRepository;

    public async Task<List<GameDto>> ListGamesRelatedToEmojis(ListGamesRelatedToEmojisRequest req)
    {
        var random = new Random();
        var games = (await _gameRepository.ListAsync()).Where(game => req.FirstEmoji.Contains(game.Emoji)
             || req.SecondEmoji.Contains(game.Emoji)
             || req.ThirdEmoji.Contains(game.Emoji))
            .OrderBy(x => random.Next())
            .Take(5)
            .Select(game => new GameDto(game.Id, game.Name, game.Rating, game.Emoji))
            .ToList();

        return games;
    }
}