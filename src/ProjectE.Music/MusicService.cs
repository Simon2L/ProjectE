using ProjectE.Music.Data;

namespace ProjectE.Music;

internal class MusicService : IMusicService
{
    private readonly IMusicRepository _musicRepository;
    public MusicService(IMusicRepository musicRepository)
    {
        _musicRepository = musicRepository;
    }

    public async Task CreateMusicAsync(MusicDto newMusic)
    {
        var music = new Music(newMusic.Id, newMusic.SongName, newMusic.Artist, newMusic.Emoji);

        await _musicRepository.AddAsync(music);
        await _musicRepository.SaveChangesAsync();
    }

    public async Task DeleteMusicAsync(Guid id)
    {
        var deleteMusic = await _musicRepository.GetByIdAsync(id);
        if (deleteMusic is not null) 
        { 
            await _musicRepository.DeleteAsync(deleteMusic);
            await _musicRepository.SaveChangesAsync();
        }
    }

    public async Task<MusicDto> GetMusicByIdAsync(Guid id)
    {
        var music = await _musicRepository.GetByIdAsync(id);

        // TODO: if not found?
        return new MusicDto(music!.Id, music.SongName, music.Artist, music.Emoji);
    }

    public async Task<List<MusicDto>> ListMusicAsync()
    {
        var music = (await _musicRepository.ListAsync())
            .Select(music => new MusicDto(music.Id, music.SongName, music.Artist, music.Emoji))
            .ToList();

        return music;
    }
}
