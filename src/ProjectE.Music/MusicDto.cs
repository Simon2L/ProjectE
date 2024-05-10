namespace ProjectE.Music;

public record MusicDto(Guid Id, string SongName, string Artist, string Emoji)
{
    public bool IsFavoritedByUser { get; set; } = false;
};
