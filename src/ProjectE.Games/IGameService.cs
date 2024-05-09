using ProjectE.Games.GameEndpoints;

namespace ProjectE.Games;

internal interface IGameService
{
    Task<List<GameDto>> ListGamesRelatedToEmojis(ListGamesRelatedToEmojisRequest req);
}
