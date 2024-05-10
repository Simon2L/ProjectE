using Ardalis.Result;
using MediatR;
using ProjectE.Users.FavoritesEnpoints;

namespace ProjectE.Users.UseCases.Favorites;

public record AddSongToFavoritesCommand(AddSongRequest Song, string Email)
    : IRequest<Result>;

internal class AddSongToFavoritesHandler(IApplicationUserRepository userRepository)
    : IRequestHandler<AddSongToFavoritesCommand, Result>
{
    private readonly IApplicationUserRepository _userRepository = userRepository;

    public async Task<Result> Handle(AddSongToFavoritesCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserWithFavoritesByEmailAddress(request.Email);

        if (user is null)
        {
            return Result.Unauthorized();
        }

        var song = new Song(request.Song.Id,
            request.Song.SongName,
            request.Song.Artist,
            request.Song.Emoji);

        user.AddSongToFavorites(song);

        await _userRepository.SaveChangesAsync();

        return Result.Success();
    }
}
