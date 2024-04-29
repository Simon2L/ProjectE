using ProjectE.Music.MusicEnpoints;

namespace ProjectE.Music;

internal interface IMusicService
{
    Task<MusicDto> GetMusicByIdAsync(Guid id);
    Task<List<MusicDto>> ListMusicAsync();
    Task CreateMusicAsync(MusicDto newMusic);
    Task DeleteMusicAsync(Guid id);
    Task<List<MusicDto>> ListMusicRelatedToEmojisAsync(ListMusicRelatedToEmojisRequest req);
}
