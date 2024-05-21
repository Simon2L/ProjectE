using Ardalis.Result;
using FastEndpoints;
using MediatR;
using ProjectE.Users.UseCases.Favorites;
using System.Security.Claims;

namespace ProjectE.Users.FavoritesEnpoints;


internal class ListAllFavorites(IMediator mediator) : 
    EndpointWithoutRequest<ListAllFavoritesResponse>
{
    private readonly IMediator _mediator = mediator;

    public override void Configure()
    {
        Get("/favorites");
        Claims("EmailAddress");
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var emailAddress = User.FindFirstValue("EmailAddress");

        var query = new ListAllFavoritesQuery(emailAddress!);

        var result = await _mediator.Send(query);

        if (result.Status == ResultStatus.Unauthorized)
        {
            await SendUnauthorizedAsync();
        }
        else
        {
            var response = new ListAllFavoritesResponse()
            {
                Music = result.Value.Music,
                Movies = result.Value.Movies,
                Games = result.Value.Games
            };

            await SendAsync(response); 
        }

    }

}

internal class ListAllFavoritesResponse
{
    public List<SongDto> Music { get; set; } = [];
    public List<MovieDto> Movies { get; set; } = [];
    public List<GameDto> Games { get; set; } = [];
}
