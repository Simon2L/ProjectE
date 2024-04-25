using FastEndpoints;

namespace ProjectE.Music.MusicEnpoints;

internal class ListMusicRelatedToEmojis(IMusicService musicService) : 
    Endpoint<ListMusicRelatedToEmojisRequest, ListMusicRelatedToEmojisResponse>
{
    private readonly IMusicService _musicService = musicService;

    public override void Configure()
    {
        Get("/music/emojis");
        AllowAnonymous();
    }

    public override async Task HandleAsync(ListMusicRelatedToEmojisRequest req, 
        CancellationToken ct)
    {
        var music = await _musicService.ListMusicRelatedToEmojisAsync(req);

        await SendAsync(new ListMusicRelatedToEmojisResponse()
        {
            Music = music
        });
    }
}

public class ListMusicRelatedToEmojisResponse
{
    public List<MusicDto> Music { get; set; } = [];
}

public record ListMusicRelatedToEmojisRequest(string FirstEmoji, string SecondEmoji, string ThirdEmoji);
