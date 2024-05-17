using Ardalis.Result;
using MediatR;

namespace ProjectE.Users.UseCases.Favorites;

internal record RemoveSongFromFavoritesCommand(Guid Id, string Email) : IRequest<Result>;
internal class RemoveSongFromFavoritesHandler(IApplicationUserRepository userRepository) :
    IRequestHandler<RemoveSongFromFavoritesCommand, Result>
{
    private readonly IApplicationUserRepository _userRepository = userRepository;

    public async Task<Result> Handle(RemoveSongFromFavoritesCommand request,
        CancellationToken ct)
    {
        var user = await _userRepository.GetUserWithFavoritesByEmailAddress(request.Email);

        if (user is null)
        {
            return Result.Unauthorized();
        }

        var result = user.RemoveSongFromFavorites(request.Id);

        if (result.Status == ResultStatus.NotFound)
        {
            return Result.NotFound();
        }

        await _userRepository.SaveChangesAsync();

        return Result.Success();

    }
}
