using Ardalis.Result;
using MediatR;

namespace ProjectE.Users.UseCases.Favorites;

internal record FavoritesDto
{
    public List<SongDto> Music { get; set; } = [];
    public List<MovieDto> Movies { get; set; } = [];
}

public record SongDto(Guid Id, string Name, string Artist, string Emoji);
public record MovieDto(Guid Id, string Title, double Rating, string Emoji);

internal record ListAllFavoritesQuery(string Email)
    : IRequest<Result<FavoritesDto>>;


internal class ListAllFavoritesHandler(IApplicationUserRepository userRepository)
    : IRequestHandler<ListAllFavoritesQuery, Result<FavoritesDto>>
{
    private readonly IApplicationUserRepository _userRepository = userRepository;
    public async Task<Result<FavoritesDto>> Handle(ListAllFavoritesQuery request,
        CancellationToken ct)
    {
        var user = await _userRepository.GetUserWithFavoritesByEmailAddress(request.Email);

        if (user is null)
        {
            return Result.Unauthorized();
        }

        var favoriteMusic = user.FavoriteSongs
            .Select(item => new SongDto(item.Id, item.Name, item.Artist, System.Net.WebUtility.HtmlDecode(item.Emoji)))
            .ToList();
        
        var favoriteMovies = user.FavoriteMovies
            .Select(item => new MovieDto(item.Id, item.Title, item.Rating, Uri.UnescapeDataString(item.Emoji)))
            .ToList();

        return new FavoritesDto
        {
            Music = favoriteMusic,
            Movies = favoriteMovies
        };
    }
}
