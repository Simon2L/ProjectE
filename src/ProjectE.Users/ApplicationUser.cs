using Ardalis.GuardClauses;
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

        // TODO: ADD IF SONG ALREADY EXISTS IN FAVORITES
        //var existingMusic = _favorites.FirstOrDefault(m => m.Id == music.Id);

        //if (existingMusic is not null)
        //{
        //    return;
        //}

        _favoriteSongs.Add(song);

    }

    public void AddMovieToFavorites(Movie movie) 
    { 
        Guard.Against.Null(movie);
        _favoriteMovies.Add(movie);
    }
}
