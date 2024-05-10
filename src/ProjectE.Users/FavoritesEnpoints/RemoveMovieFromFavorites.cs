using Ardalis.Result;
using FastEndpoints;
using MediatR;
using ProjectE.Users.UseCases.Favorites;
using System.Security.Claims;

namespace ProjectE.Users.FavoritesEnpoints;

internal record RemoveMovieFromFavoritesRequest(Guid Id);
internal class RemoveMovieFromFavorites(IMediator mediator) :
    Endpoint<RemoveMovieFromFavoritesRequest>
{
    private readonly IMediator _mediator = mediator;

    public override void Configure()
    {
        Delete("favorites/movie/{id}");
        Claims("EmailAddress");
    }

    public override async Task HandleAsync(RemoveMovieFromFavoritesRequest req,
        CancellationToken ct)
    {
        var emailAddress = User.FindFirstValue("EmailAddress");

        if (emailAddress is null)
        {
            await SendUnauthorizedAsync();
            return;
        }

        var command = new RemoveMovieFromFavoritesCommand(req.Id, emailAddress);

        var result = await _mediator.Send(command);

        if (result.IsSuccess)
        {
            await SendNoContentAsync();
        }
        else
        {
            await SendNotFoundAsync();
        }
    }
}

