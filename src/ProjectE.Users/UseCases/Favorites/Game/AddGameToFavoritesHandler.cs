using Ardalis.Result;
using MediatR;
using ProjectE.Users.FavoritesEnpoints;

namespace ProjectE.Users.UseCases.Favorites;

public record AddGameToFavoritesCommand(AddGameRequest Game, string Email)
    : IRequest<Result>;

internal class AddGameToFavoritesHandler(IApplicationUserRepository userRepository)
    : IRequestHandler<AddGameToFavoritesCommand, Result>
{
    private readonly IApplicationUserRepository _userRepository = userRepository;

    public async Task<Result> Handle(AddGameToFavoritesCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserWithFavoritesByEmailAddress(request.Email);

        if (user is null)
        {
            return Result.Unauthorized();
        }

        var game = new Game(request.Game.Id,
            request.Game.Name,
            request.Game.Rating,
            request.Game.Emoji);

        user.AddGameToFavorites(game);

        await _userRepository.SaveChangesAsync();

        return Result.Success();
    }
}
