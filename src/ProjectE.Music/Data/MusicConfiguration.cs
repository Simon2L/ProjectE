using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectE.Music.Data;

internal class MusicConfiguration : IEntityTypeConfiguration<Music>
{
    internal static readonly Guid Music1Guid = new("9268891c-3aa8-4aff-ac5a-4454fa6aa672");
    internal static readonly Guid Music2Guid = new("f25c986b-fc36-439e-bc29-9616ff2d7e95");
    internal static readonly Guid Music3Guid = new("850111d5-6409-4196-a362-c53f007ed4dd");
    internal static readonly Guid Music5Guid = new("2a31f0f1-e815-4590-885c-6c03de9c7ba2");
    internal static readonly Guid Music4Guid = new("10ea0c9a-d776-4d66-a383-dc6a00880d76");
    internal static readonly Guid Music6Guid = new("0a4a2648-a7f6-41c6-b3e6-d9329b2a345d");
    internal static readonly Guid Music7Guid = new("d469ca99-8520-4f03-ad64-324dda4b0d78");
    internal static readonly Guid Music8Guid = new("14311560-98e1-4ca4-bfa6-4cb022501b2f");
    internal static readonly Guid Music9Guid = new("59fdc46f-8528-44c3-8095-ebbc6e5785ea");
    internal static readonly Guid Music10Guid = new("444521eb-fc20-4cf5-b935-fd6008b928bf");

    public void Configure(EntityTypeBuilder<Music> builder) 
    { 
        builder.Property(p => p.Artist)
            .HasMaxLength(DataSchemaConstants.DEFAULT_NAME_LENGTH)
            .IsRequired();

        builder.Property(p => p.Emoji)
            .HasMaxLength(DataSchemaConstants.DEFAULT_GENRE_LENGTH)
            .IsRequired();

        builder.Property(p => p.SongName)
            .HasMaxLength(DataSchemaConstants.DEFAULT_NAME_LENGTH)
            .IsRequired();

        builder.HasData(GetSampleMusicData());
    }

    private IEnumerable<Music> GetSampleMusicData()
    {
        string ladyGaga = "Lady Gaga";
        string rihanna = "Rihanna";
        string theWeeknd = "The Weeknd";
        string abba = "Abba";
        string avicii = "Avicii";

        yield return new Music(Music1Guid, "Bad Romace", ladyGaga, "Emoji");
        yield return new Music(Music8Guid, "Poker Face", ladyGaga, "Emoji");
        yield return new Music(Music2Guid, "Don’t Stop the Music", rihanna, "Emoji");
        yield return new Music(Music3Guid, "Where Have You Been", rihanna, "Emoji");
        yield return new Music(Music4Guid, "Die For You", theWeeknd, "Emoji");
        yield return new Music(Music7Guid, "Blinding Lights", theWeeknd, "Emoji");
        yield return new Music(Music5Guid, "Angel Eyes", abba, "Emoji");
        yield return new Music(Music6Guid, "Dancing Queen", abba, "Emoji");
        yield return new Music(Music9Guid, "Levels", avicii, "Emoji");
        yield return new Music(Music10Guid, "Addicted To You", avicii, "Emoji");

    }
}