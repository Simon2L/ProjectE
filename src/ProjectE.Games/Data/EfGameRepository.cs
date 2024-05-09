using Microsoft.EntityFrameworkCore;

namespace ProjectE.Games.Data;

internal class EfGameRepository(GameDbContext dbContext) : IGameRepository
{
    private readonly GameDbContext _dbContext = dbContext;

    public async Task<List<Game>> ListAsync()
    {
        return await _dbContext.Games.ToListAsync();
    }
}
