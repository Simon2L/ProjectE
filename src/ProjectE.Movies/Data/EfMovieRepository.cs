using Microsoft.EntityFrameworkCore;

namespace ProjectE.Movies.Data;

internal class EfMovieRepository(MovieDbContext dbContext) : IMovieRepository
{
    private readonly MovieDbContext _dbContext = dbContext;

    public async Task<List<Movie>> ListAsync()
    {
        return await _dbContext.Movies.ToListAsync();
    }
}
