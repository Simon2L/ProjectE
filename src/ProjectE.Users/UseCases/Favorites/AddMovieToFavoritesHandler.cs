using Ardalis.Result;
using MediatR;
using ProjectE.Users.FavoritesEnpoints;

namespace ProjectE.Users.UseCases.Favorites;

public record AddMovieToFavoritesCommand(AddMovieRequest Movie, string Email)
    : IRequest<Result>;

internal class AddMovieToFavoritesHandler(IApplicationUserRepository userRepository)
    : IRequestHandler<AddMovieToFavoritesCommand, Result>
{
    private readonly IApplicationUserRepository _userRepository = userRepository;

    public async Task<Result> Handle(AddMovieToFavoritesCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetUserWithFavoritesByEmailAddress(request.Email);

        if (user is null)
        {
            return Result.Unauthorized();
        }

        var movie = new Movie(request.Movie.Id,
            request.Movie.Title,
            request.Movie.Rating,
            request.Movie.Emoji);

        user.AddMovieToFavorites(movie);

        await _userRepository.SaveChangesAsync();

        return Result.Success();
    }
}
