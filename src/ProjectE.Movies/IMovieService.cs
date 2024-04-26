using ProjectE.Movies.MovieEndpoints;

namespace ProjectE.Movies;

internal interface IMovieService
{
    Task<List<MovieDto>> ListMoviesRelatedToEmojisAsync(ListMoviesRelatedToEmojisRequest req);
}
