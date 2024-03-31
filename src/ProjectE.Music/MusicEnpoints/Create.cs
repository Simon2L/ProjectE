using FastEndpoints;

namespace ProjectE.Music.MusicEnpoints;

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
            req.Genre);

        await _musicService.CreateMusicAsync(newMusicDto);

        await SendCreatedAtAsync<GetById>(new { newMusicDto.Id },
            newMusicDto);
    }
}

public class CreateMusicRequest
{
    public Guid? Id { get; set; }
    public string SongName { get; set; } = string.Empty;
    public string Artist { get; set; } = string.Empty;
    public string Genre { get; set; } = string.Empty;
}
