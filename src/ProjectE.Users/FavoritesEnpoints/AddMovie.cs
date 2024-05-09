using Ardalis.Result;
using Ardalis.Result.AspNetCore;
using FastEndpoints;
using MediatR;
using ProjectE.Users.UseCases.Favorites;
using System.Security.Claims;

namespace ProjectE.Users.FavoritesEnpoints;

public record AddMovieRequest(Guid Id, string Title, double Rating, string Emoji);

internal class AddMovie(IMediator mediator) : Endpoint<AddMovieRequest>
{
    private readonly IMediator _mediator = mediator;

    public override void Configure()
    {
        Post("/favorites/movie");
        Claims("EmailAddress");
    }

    public async override Task HandleAsync(AddMovieRequest req,
        CancellationToken ct)
    {
        var emailAddress = User.FindFirstValue("EmailAddress");

        if (emailAddress is null)
        {
            await SendAsync("Email Null");
        }

        var command = new AddMovieToFavoritesCommand(req, emailAddress!);

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
