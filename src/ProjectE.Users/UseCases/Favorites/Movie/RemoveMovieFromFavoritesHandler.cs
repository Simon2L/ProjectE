using Ardalis.Result;
using MediatR;

namespace ProjectE.Users.UseCases.Favorites;

internal record RemoveMovieFromFavoritesCommand(Guid Id, string Email) : IRequest<Result>;
internal class RemoveMovieFromFavoritesHandler(IApplicationUserRepository userRepository) :
    IRequestHandler<RemoveMovieFromFavoritesCommand, Result>
{
    private readonly IApplicationUserRepository _userRepository = userRepository;

    public async Task<Result> Handle(RemoveMovieFromFavoritesCommand request,
        CancellationToken ct)
    {
        var user = await _userRepository.GetUserWithFavoritesByEmailAddress(request.Email);

        if (user is null)
        {
            return Result.Unauthorized();
        }

        var result = user.RemoveMovieFromFavorites(request.Id);

        if (result.Status == ResultStatus.NotFound)
        {
            return Result.NotFound();
        }

        await _userRepository.SaveChangesAsync();

        return Result.Success();

    }
}
