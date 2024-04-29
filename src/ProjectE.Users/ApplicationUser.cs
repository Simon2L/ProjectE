using Ardalis.GuardClauses;
using Microsoft.AspNetCore.Identity;

namespace ProjectE.Users;

internal class ApplicationUser : IdentityUser
{
    private readonly List<Song> _favoriteSongs = [];
    public IReadOnlyCollection<Song> FavoriteSongs => _favoriteSongs.AsReadOnly();

    public void AddSongToFavorites(Song song)
    {
        Guard.Against.Null(song);

        //var existingMusic = _favorites.FirstOrDefault(m => m.Id == music.Id);

        //if (existingMusic is not null)
        //{
        //    return;
        //}

        _favoriteSongs.Add(song);

    }
}
