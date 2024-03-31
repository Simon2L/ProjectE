namespace ProjectE.Music.Data;

internal interface IMusicRepository : IReadonlyMusicRepository
{
    Task AddAsync(Music music);
    Task DeleteAsync(Music music);
    Task SaveChangesAsync();
}
