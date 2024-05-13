using FastEndpoints;
using MediatR;
using ProjectE.Users.Contracts;
using System.Security.Claims;

namespace ProjectE.Music.MusicEnpoints;

public record ListMusicRelatedToEmojisRequest(string FirstEmoji, string SecondEmoji, string ThirdEmoji);

internal class ListMusicRelatedToEmojis(IMusicService musicService, IMediator mediator) : 
    Endpoint<ListMusicRelatedToEmojisRequest, ListMusicRelatedToEmojisResponse>
{
    private readonly IMusicService _musicService = musicService;
    private readonly IMediator _mediator = mediator;

    public override void Configure()
    {
        Get("/music/emojis");
        AllowAnonymous();
        Claims("EmailAddress");
    }

    public override async Task HandleAsync(ListMusicRelatedToEmojisRequest req, 
        CancellationToken ct)
    {
        var music = await _musicService.ListMusicRelatedToEmojisAsync(req);

        var emailAddress = User.FindFirstValue("EmailAddress");

        if (emailAddress is not null)
        {
            var query = new IsFavoritedByUserQuery(emailAddress, music.Select(song => song.Id).ToList());

            var result = await _mediator.Send(query);

            if (result is not null || result?.Value?.Count > 0)
            {
                foreach (var id in result.Value)
                {
                    foreach (var song in music.Where(m => m.Id == id))
                    {
                        song.IsFavoritedByUser = true;
                    }
                }
            }
        }

        var musicRessponse = new ListMusicRelatedToEmojisResponse()
        {
            Music = music,
        };

        await SendAsync(musicRessponse);
    }
}

public class ListMusicRelatedToEmojisResponse
{
    public List<MusicDto> Music { get; set; } = [];
}
