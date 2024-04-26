using ProjectE.Movies.Data;
using ProjectE.Movies.MovieEndpoints;

namespace ProjectE.Movies;

internal class MovieService(IMovieRepository movieRepository) : IMovieService
{
    private readonly IMovieRepository _movieRepository = movieRepository;
    public async Task<List<MovieDto>> ListMoviesRelatedToEmojisAsync(ListMoviesRelatedToEmojisRequest req)
    {
        var movies = (await _movieRepository.ListAsync())
            .Where(movie => movie.Emoji.Contains(req.FirstEmoji)
            || movie.Emoji.Contains(req.SecondEmoji)
            || movie.Emoji.Contains(req.ThirdEmoji))
            .Select(movie => new MovieDto(movie.Id, movie.Title, movie.Description, movie.Emoji))
            .ToList();

        return movies;
    }
}
