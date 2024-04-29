using FastEndpoints;

namespace ProjectE.Music.MusicEnpoints;
public class CreateMusicRequest
{
    public Guid? Id { get; set; }
    public string SongName { get; set; } = string.Empty;
    public string Artist { get; set; } = string.Empty;
    public string Emoji { get; set; } = string.Empty;
}

internal class Create(IMusicService musicService) : 
    Endpoint<CreateMusicRequest, MusicDto> 
{
    private readonly IMusicService _musicService = musicService;

    public override void Configure()
    {
        Post("/music");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateMusicRequest req, 
        CancellationToken ct)
    {
        var newMusicDto = new MusicDto(req.Id ?? Guid.NewGuid(),
            req.SongName,
            req.Artist,
            req.Emoji);

        await _musicService.CreateMusicAsync(newMusicDto);

        await SendCreatedAtAsync<GetById>(new { newMusicDto.Id },
            newMusicDto);
    }
}

