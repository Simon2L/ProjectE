using Ardalis.Result;
using Ardalis.Result.AspNetCore;
using FastEndpoints;
using MediatR;
using ProjectE.Users.UseCases.Favorites;
using System.Security.Claims;

namespace ProjectE.Users.FavoritesEnpoints;

public record AddSongRequest(Guid Id, string SongName, string Artist, string Emoji);

internal class AddSong(IMediator mediator) : Endpoint<AddSongRequest>
{
    private readonly IMediator _mediator = mediator;

    public override void Configure()
    {
        Post("/favorites/song");
        Claims("EmailAddress");
    }

    public async override Task HandleAsync(AddSongRequest req,
        CancellationToken ct)
    {
        var emailAddress = User.FindFirstValue("EmailAddress");

        if (emailAddress is null)
        {
            await SendAsync("Email Null");
        }

        var command = new AddSongToFavoritesCommand(req, emailAddress!);

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
