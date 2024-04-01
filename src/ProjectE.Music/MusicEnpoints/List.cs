using FastEndpoints;

namespace ProjectE.Music.MusicEnpoints;

internal class List(IMusicService musicService) : 
    EndpointWithoutRequest<ListMusicResponse>
{
    private readonly IMusicService _musicService = musicService;
    public override void Configure()
    {
        Get("/music");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        var music = await  _musicService.ListMusicAsync();

        await SendAsync(new ListMusicResponse()
        {
            Music = music
        });
    }
}

public class ListMusicResponse
{
    public List<MusicDto> Music { get; set; } = [];
}