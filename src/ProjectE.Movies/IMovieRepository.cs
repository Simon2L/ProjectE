namespace ProjectE.Movies;

// TODO: change to IReadonlyRepository
internal interface IMovieRepository
{
    Task<List<Movie>> ListAsync();
}
