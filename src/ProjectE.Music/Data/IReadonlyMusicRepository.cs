namespace ProjectE.Music.Data;

internal interface IReadonlyMusicRepository
{
    Task<Music?> GetByIdAsync(Guid id);
    Task<List<Music>> ListAsync();
}
