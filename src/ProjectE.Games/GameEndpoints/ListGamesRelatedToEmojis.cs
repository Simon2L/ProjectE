using FastEndpoints;

namespace ProjectE.Games.GameEndpoints;


internal record ListGamesRelatedToEmojisRequest(string FirstEmoji, string SecondEmoji, string ThirdEmoji);

internal class ListGamesRelatedToEmojis(IGameService gameService) : 
    Endpoint<ListGamesRelatedToEmojisRequest, ListGamesRelatedToEmojisResponse>
{
    private readonly IGameService _gameService = gameService;

    public override void Configure()
    {
        Get("/games/emojis");
        AllowAnonymous();
    }
    public override async Task HandleAsync(ListGamesRelatedToEmojisRequest req, 
        CancellationToken ct)
    {
        var result = await _gameService.ListGamesRelatedToEmojis(req);

        if (result == null)
        {
            await SendNotFoundAsync();
            return;
        }

        var games = new ListGamesRelatedToEmojisResponse()
        {
            Games = result
        };

        await SendAsync(games);
    }
}

internal class ListGamesRelatedToEmojisResponse
{
    public List<GameDto> Games { get; set; } = [];
}