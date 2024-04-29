using Ardalis.Result;
using MediatR;

namespace ProjectE.Users.UseCases.Favorites;

public record AddSongToFavoritesCommand(Guid SongId, string Email)
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

        // GET SONG DETAILS FROM SONG MODULE

        // var query = new SongDetailsQuery(request.SongId);
        // mediatr send to Music.Contracts

        var song = new Song(request.SongId,
            "SONGNAME",
            "ARTIST",
            "EMOJI");

        user.AddSongToFavorites(song);

        await _userRepository.SaveChangesAsync();

        return Result.Success();
    }
}
