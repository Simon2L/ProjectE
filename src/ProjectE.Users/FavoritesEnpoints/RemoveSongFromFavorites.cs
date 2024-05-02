using Ardalis.Result;
using FastEndpoints;
using MediatR;
using ProjectE.Users.UseCases.Favorites;
using System.Security.Claims;

namespace ProjectE.Users.FavoritesEnpoints;

internal record RemoveSongFromFavoritesRequest(Guid Id);
internal class RemoveSongFromFavorites(IMediator mediator) :
    Endpoint<RemoveSongFromFavoritesRequest>
{
    private readonly IMediator _mediator = mediator;

    public override void Configure()
    {
        Delete("favorites/song/{id}");
        Claims("EmailAddress");
    }

    public override async Task HandleAsync(RemoveSongFromFavoritesRequest req,
        CancellationToken ct)
    {
        var emailAddress = User.FindFirstValue("EmailAddress");

        if (emailAddress is null)
        {
            await SendUnauthorizedAsync();
            return;
        }

        var command = new RemoveSongFromFavoritesCommand(req.Id, emailAddress);

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

