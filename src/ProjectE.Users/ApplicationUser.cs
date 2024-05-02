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

    public void AddSongToFavorites(Song song)
    {
        Guard.Against.Null(song);

        var existingSong = _favoriteSongs.FirstOrDefault(s => s.Id == song.Id);
        if (existingSong is not null)
        {
            return;
        }

        _favoriteSongs.Add(song);

    }

    public void AddMovieToFavorites(Movie movie) 
    { 
        Guard.Against.Null(movie);

        var existingMovie = _favoriteSongs.FirstOrDefault(m => m.Id == m.Id);
        if (existingMovie is not null)
        {
            return;
        }

        _favoriteMovies.Add(movie);
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
}
