using ProjectE.Games.Data;

namespace ProjectE.Games;

internal class GameService(IGameRepository gameRepository) : IGameService
{
    private readonly IGameRepository _gameRepository = gameRepository;

    public async Task<List<GameDto>> ListGamesRelatedToEmojis(ListGamesRelatedToEmojisRequest req)
    {
        var games = (await _gameRepository.ListAsync()).Where(game => req.FirstEmoji.Contains(game.Emoji)
             || req.SecondEmoji.Contains(game.Emoji)
             || req.ThirdEmoji.Contains(game.Emoji))
            .Take(5)
            .Select(game => new GameDto(game.Id, game.Name, game.Rating, game.Emoji))
            .ToList();

        return games;
    }
}