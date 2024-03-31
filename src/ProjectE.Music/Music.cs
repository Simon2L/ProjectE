using Ardalis.GuardClauses;

namespace ProjectE.Music;

internal class Music
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string SongName { get; private set; } = string.Empty;
    public string Artist { get; private set; } = string.Empty;
    public string Genre { get; private set; } = string.Empty; //Should be enumerable list of genres

    internal Music(Guid id, string songName, string artist, string genre) 
    { 
        Id = Guard.Against.Default(id);
        SongName = Guard.Against.NullOrEmpty(songName);
        Artist = Guard.Against.NullOrEmpty(artist);
        Genre = Guard.Against.NullOrEmpty(genre);
    }

    // TODO: update Name/Artist?
    //internal void UpdateArtist(string newSongName)
    //{
    //    SongName = Guard.Against.NullOrEmpty(newSongName);
    //}
    //...
}

internal enum SongGenre
{
    Rock,
    Pop,
    HipHop,
    Jazz,
    Blues,
    Country,
    Electronic,
    RnB,
    Classical,
    Reggae,
    Metal,
    Folk,
    Punk,
    Rap,
    Indie,
    Dance,
    Soul,
    Funk,
    Gospel,
    World,
    Latin,
    Alternative,
    Experimental,
    Ambient
}
