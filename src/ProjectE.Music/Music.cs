using Ardalis.GuardClauses;

namespace ProjectE.Music;

internal class Music
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string SongName { get; private set; } = string.Empty;
    public string Artist { get; private set; } = string.Empty;
    public string Emoji { get; private set; } = string.Empty;

    internal Music(Guid id, string songName, string artist, string emoji) 
    { 
        Id = Guard.Against.Default(id);
        SongName = Guard.Against.NullOrEmpty(songName);
        Artist = Guard.Against.NullOrEmpty(artist);
        Emoji = Guard.Against.NullOrEmpty(emoji);
    }

    // TODO: update Name/Artist?
    //internal void UpdateArtist(string newSongName)
    //{
    //    SongName = Guard.Against.NullOrEmpty(newSongName);
    //}
    //...
}
