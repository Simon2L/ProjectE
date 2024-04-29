using FastEndpoints;

namespace ProjectE.Music.MusicEnpoints;

public class GetMusicByIdRequest 
{
    public Guid Id { get; set; }
}
internal class GetById(IMusicService musicService) :
    Endpoint<GetMusicByIdRequest, MusicDto>
{ 
    private readonly IMusicService _musicService = musicService;

    public override void Configure()
    {
        Get("/music/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(GetMusicByIdRequest req, 
        CancellationToken ct)
    {
        var  music = await _musicService.GetMusicByIdAsync(req.Id);

        if (music is null)
        {
            await SendNotFoundAsync();
            return;
        }

        await SendAsync(music);
    }
}

