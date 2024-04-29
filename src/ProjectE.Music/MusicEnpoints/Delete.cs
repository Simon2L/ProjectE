using FastEndpoints;

namespace ProjectE.Music.MusicEnpoints;

public class DeleteMusicRequest
{
    public Guid Id { get; set; }
}
internal class Delete(IMusicService musicService) : 
    Endpoint<DeleteMusicRequest>
{
    private readonly IMusicService _musicService = musicService;

    public override void Configure()
    {
        Delete("/music/{id}");
        AllowAnonymous();
    }

    public override async Task HandleAsync(DeleteMusicRequest req, 
        CancellationToken ct)
    {
        await _musicService.DeleteMusicAsync(req.Id);

        await SendNoContentAsync();
    }
}

