using ProjectE.Music.Data;
using ProjectE.Music.MusicEnpoints;

namespace ProjectE.Music;

internal class MusicService(IMusicRepository musicRepository) : IMusicService
{
    private readonly IMusicRepository _musicRepository = musicRepository;

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

    public async Task<List<MusicDto>> ListMusicRelatedToEmojisAsync(ListMusicRelatedToEmojisRequest req)
    {
        var random = new Random();
        var music = (await _musicRepository.ListAsync())
            .Where(music => music.Emoji.Contains(req.FirstEmoji)
            || music.Emoji.Contains(req.SecondEmoji)
            || music.Emoji.Contains(req.ThirdEmoji))
            .Select(music => new MusicDto(music.Id, music.SongName, music.Artist, music.Emoji))
            .OrderBy(x => random.Next())
            .Take(5)
            .ToList();

        return music;
    }
}
