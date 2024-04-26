namespace ProjectE.Movies;

internal interface IMovieRepository
{
    Task<List<Movie>> ListAsync();
}
