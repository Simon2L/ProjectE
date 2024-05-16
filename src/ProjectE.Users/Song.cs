using Ardalis.GuardClauses;

namespace ProjectE.Users;

internal class Song
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid SongId { get; private set; }
    public string Name { get; private set; } = string.Empty;
    public string Artist { get; private set; } = string.Empty;
    public string Emoji { get; private set; } = string.Empty;

    public Song(Guid id, string name, string artist, string emoji)
    {
        SongId = Guard.Against.Default(id);
        Name = Guard.Against.NullOrEmpty(name);
        Artist = Guard.Against.NullOrEmpty(artist);
        Emoji = Guard.Against.NullOrEmpty(emoji);
    }

    public Song()
    {
        // for ef
    }
}
