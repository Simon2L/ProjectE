using Ardalis.Result;
using MediatR;

namespace ProjectE.Users.UseCases.Favorites;

internal record RemoveGameFromFavoritesCommand(Guid Id, string Email) : IRequest<Result>;
internal class RemoveGameFromFavoritesHandler(IApplicationUserRepository userRepository) :
    IRequestHandler<RemoveGameFromFavoritesCommand, Result>
{
    private readonly IApplicationUserRepository _userRepository = userRepository;

    public async Task<Result> Handle(RemoveGameFromFavoritesCommand request,
        CancellationToken ct)
    {
        var user = await _userRepository.GetUserWithFavoritesByEmailAddress(request.Email);

        if (user is null)
        {
            return Result.Unauthorized();
        }

        var result = user.RemoveGameFromFavorites(request.Id);

        if (result.Status == ResultStatus.NotFound)
        {
            return Result.NotFound();
        }

        await _userRepository.SaveChangesAsync();

        return Result.Success();

    }
}
