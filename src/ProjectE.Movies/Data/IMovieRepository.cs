namespace ProjectE.Movies.Data;

// TODO: change to IReadonlyRepository
internal interface IMovieRepository
{
    Task<List<Movie>> ListAsync();
}
