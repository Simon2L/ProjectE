using Ardalis.GuardClauses;
using Ardalis.Result;
using Microsoft.AspNetCore.Identity;

namespace ProjectE.Users;

internal class ApplicationUser : IdentityUser
{
    private readonly List<Song> _favoriteSongs = [];
    public IReadOnlyCollection<Song> FavoriteSongs => _favoriteSongs.AsReadOnly();

    private readonly List<Movie> _favoriteMovies = [];
    public IReadOnlyCollection<Movie> FavoriteMovies =>  _favoriteMovies.AsReadOnly();

    private readonly List<Game> _favoriteGames = [];
    public IReadOnlyCollection<Game> FavoriteGames => _favoriteGames.AsReadOnly();

    public void AddSongToFavorites(Song song)
    {
        Guard.Against.Null(song);
        var existingSong = _favoriteSongs.FirstOrDefault(s => s.SongId == song.SongId);
        if (existingSong is not null)
        {
            return;
        }
        _favoriteSongs.Add(song);
    }

    public void AddMovieToFavorites(Movie movie) 
    {
        Guard.Against.Null(movie);
        var existingMovie = _favoriteMovies.FirstOrDefault(m => m.MovieId == movie.MovieId);
        if (existingMovie is not null)
        {
            return;
        }
        _favoriteMovies.Add(movie);
    }
    public void AddGameToFavorites(Game game)
    {
        Guard.Against.Null(game);
        var existingGame = _favoriteGames.FirstOrDefault(g => game.GameId == g.GameId);
        if (existingGame is not null)
        {
            return;
        }
        _favoriteGames.Add(game);
    }

    public Result RemoveSongFromFavorites(Guid id)
    {
        Guard.Against.Default(id);
        var song = _favoriteSongs.FirstOrDefault(song => song.Id == id);
        if (song is not null)
        {
            _favoriteSongs.Remove(song);
            return Result.Success();
        }
        return Result.NotFound();
    }

    public Result RemoveMovieFromFavorites(Guid id)
    {
        Guard.Against.Default(id);
        var movie = _favoriteMovies.FirstOrDefault(movie => movie.Id == id);
        if (movie is not null)
        {
            _favoriteMovies.Remove(movie);
            return Result.Success();
        }
        return Result.NotFound();
    }
    public Result RemoveGameFromFavorites(Guid id)
    {
        Guard.Against.Default(id);
        var game = _favoriteGames.FirstOrDefault(game => game.Id == id);
        if (game is not null)
        {
            _favoriteGames.Remove(game);
            return Result.Success();
        }
        return Result.NotFound();
    }
}
