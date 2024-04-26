using FastEndpoints;

namespace ProjectE.Movies.MovieEndpoints;
public record ListMoviesRelatedToEmojisRequest(string FirstEmoji, string SecondEmoji, string ThirdEmoji);

internal class ListMoviesRelatedToEmojis(IMovieService movieService) 
    : Endpoint<ListMoviesRelatedToEmojisRequest, ListMoviesRelatedToEmojisResponse>
{
    private readonly IMovieService _movieService = movieService;
    public override void Configure()
    {
        Get("/movies/emojis");
        AllowAnonymous();
    }

    public async override Task HandleAsync(ListMoviesRelatedToEmojisRequest req,
        CancellationToken ct)
    {
        var movies = await _movieService.ListMoviesRelatedToEmojisAsync(req);

        await SendAsync(new ListMoviesRelatedToEmojisResponse()
        {
            Movies = movies
        });
    }
}

public class ListMoviesRelatedToEmojisResponse
{
    public List<MovieDto> Movies { get; set; } = [];
}