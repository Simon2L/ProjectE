using Ardalis.Result;
using Ardalis.Result.AspNetCore;
using FastEndpoints;
using MediatR;
using ProjectE.Users.UseCases.Favorites;
using System.Security.Claims;

namespace ProjectE.Users.FavoritesEnpoints;

public record AddGameRequest(Guid Id, string Name, double Rating, string Emoji);

internal class AddGame(IMediator mediator) : Endpoint<AddGameRequest>
{
    private readonly IMediator _mediator = mediator;

    public override void Configure()
    {
        Post("/favorites/game");
        Claims("EmailAddress");
    }

    public async override Task HandleAsync(AddGameRequest req,
        CancellationToken ct)
    {
        var emailAddress = User.FindFirstValue("EmailAddress");

        if (emailAddress is null)
        {
            await SendAsync("Email Null");
        }

        var command = new AddGameToFavoritesCommand(req, emailAddress!);

        var result = await _mediator!.Send(command);

        if (result.Status == ResultStatus.Unauthorized)
        {
            await SendUnauthorizedAsync();
        }
        if (result.Status == ResultStatus.Invalid)
        {
            await SendResultAsync(result.ToMinimalApiResult());
        }
        else
        {
            await SendOkAsync();
        }
    }
}
