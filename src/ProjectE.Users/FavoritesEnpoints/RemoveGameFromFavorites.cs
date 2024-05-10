using Ardalis.Result;
using FastEndpoints;
using MediatR;
using ProjectE.Users.UseCases.Favorites;
using System.Security.Claims;

namespace ProjectE.Users.FavoritesEnpoints;

internal record RemoveGameFromFavoritesRequest(Guid Id);
internal class RemoveGameFromFavorites(IMediator mediator) :
    Endpoint<RemoveGameFromFavoritesRequest>
{
    private readonly IMediator _mediator = mediator;

    public override void Configure()
    {
        Delete("favorites/game/{id}");
        Claims("EmailAddress");
    }

    public override async Task HandleAsync(RemoveGameFromFavoritesRequest req,
        CancellationToken ct)
    {
        var emailAddress = User.FindFirstValue("EmailAddress");

        if (emailAddress is null)
        {
            await SendUnauthorizedAsync();
            return;
        }

        var command = new RemoveGameFromFavoritesCommand(req.Id, emailAddress);

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

