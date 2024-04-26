using Microsoft.EntityFrameworkCore;

namespace ProjectE.Music.Data;

internal class EfMusicRepository(MusicDbContext dbContext) : IMusicRepository
{
    private readonly MusicDbContext _dbContext = dbContext;

    public Task AddAsync(Music music)
    {
        _dbContext.Music.AddAsync(music);
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Music music)
    {
        _dbContext.Music.Remove(music);
        return Task.CompletedTask;
    }

    public async Task<Music?> GetByIdAsync(Guid id)
    {
        return await _dbContext!.Music.FindAsync(id);
    }

    public async Task<List<Music>> ListAsync()
    {
        return await _dbContext.Music.ToListAsync();
    }

    public async Task SaveChangesAsync()
    {
        await _dbContext.SaveChangesAsync();
    }
}
