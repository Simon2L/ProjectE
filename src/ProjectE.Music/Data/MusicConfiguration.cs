using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectE.Music.Data;

internal class MusicConfiguration : IEntityTypeConfiguration<Music>
{

    public void Configure(EntityTypeBuilder<Music> builder) 
    { 
        builder.Property(p => p.Artist)
            .HasMaxLength(DataSchemaConstants.DEFAULT_NAME_LENGTH)
            .IsRequired();

        builder.Property(p => p.Emoji)
            .HasMaxLength(DataSchemaConstants.DEFAULT_EMOJI_LENGTH)
            .IsRequired();

        builder.Property(p => p.SongName)
            .HasMaxLength(DataSchemaConstants.DEFAULT_NAME_LENGTH)
            .IsRequired();

        builder.HasData(GetSampleMusicData());
    }

    private IEnumerable<Music> GetSampleMusicData()
    {

        #region DATA
        yield return new Music(new Guid("6543f18f-2166-4211-bbd0-0d757076b6f5"), "Lana Del Rey", "Love", "🩷");
        yield return new Music(new Guid("e851180a-cd8e-4442-a5b1-3fd38e35c495"), "Melanie Martinez", "Light Shower", "🩷");
        yield return new Music(new Guid("f3a72592-5dc8-4999-bd3b-91c6b99a88dd"), "Dua Lipa", "Training Season", "🩷");
        yield return new Music(new Guid("cd0f784a-06a1-442c-921f-87cbeb5a0d93"), "Halsey", "Without Me", "💧");
        yield return new Music(new Guid("1b6be275-943a-454b-b054-4eb1153af7af"), "Middle Part ", "& Cry!", "💧");
        yield return new Music(new Guid("c43d0481-f20b-4c48-b039-3cbc89a0574b"), "Sky Ferreira", "Everything is Embarrassing", "💧");
        yield return new Music(new Guid("f1aabc42-59f6-4a64-9f16-145bd924d42c"), "Post Malone", "Fall Apart", "🥀");
        yield return new Music(new Guid("405429b5-cfde-406f-82fe-fcfa5ceebf5c"), "Tegan and Sara & CHVRCHES", "Call it Off", "🥀");
        yield return new Music(new Guid("a1894ad3-02f4-4516-9013-7eae0d6764e1"), "Caroline Polachek", "Hit Me Where It Hurst", "🥀");
        yield return new Music(new Guid("c19d4f43-fc42-4be3-936c-df2aaafbc014"), "LE SSERAFIM", "EASY", "🍧");
        yield return new Music(new Guid("f4662dbe-9666-4727-9074-727075841bc5"), "Stray Kids", "MEGAVERSE", "🍧");
        yield return new Music(new Guid("e280f79b-284d-4512-9d25-2b4e8ea9d387"), "BABYMONSTER", "SHEESH", "🍧");
        yield return new Music(new Guid("60d0a53f-2482-4536-b2bf-fb59b1b540da"), "Pentakill", "Lost Chapter", "⛓️");
        yield return new Music(new Guid("ab1799c7-ca34-49d6-8fd1-a87a6443160e"), "Muse", "Hysteria", "⛓️");
        yield return new Music(new Guid("202d7276-0bc9-4210-a912-342ca836821f"), "Bon Jovi", "You Give Love A Bad Name", "⛓️");
        yield return new Music(new Guid("78eee64e-4456-4b14-b512-603c1a061219"), "Madonna", "Material Girl", "👑");
        yield return new Music(new Guid("aa892533-6f75-4443-a047-3b6d4d0dea5e"), "Queen", "Radio Gaga", "👑");
        yield return new Music(new Guid("07b6d031-a79a-44ce-a52d-307873c66ce7"), "Michael Jackson", "Smooth Criminal", "👑");
        yield return new Music(new Guid("f016aff2-862a-416b-b46f-c5ec40ec1a80"), "Rihanna", "Don't Stop the Music", "🪩");
        yield return new Music(new Guid("b6da79ad-e133-45f1-bb3b-8adc44353e26"), "Britney", "Gimme More", "🪩");
        yield return new Music(new Guid("340dab64-34d3-46d0-8b4b-e48df7cbffde"), "Lady Gaga", "Just Dance", "🪩");
        yield return new Music(new Guid("369cbee7-6c8a-4f25-a35b-556debfb1aea"), "Kendrick Lamar", "HUMBLE.", "🥶");
        yield return new Music(new Guid("237fdd5d-41bd-425b-8678-c5facb2cad28"), "Metro Boomin & The Weeknd & 21 Savage", "Creepin", "🥶");
        yield return new Music(new Guid("dc5762e6-8a34-4ae7-abe9-168625059797"), "Megan Thee Stallion & Spiritbox", "Cobra (Rock Remix)", "🥶");
        yield return new Music(new Guid("1cd0e7c8-5368-4fd7-bfbc-3de2cfd27b4f"), "Ghost", "Mary On A Cross", "💥");
        yield return new Music(new Guid("eb6a3906-fffc-475f-92ce-d4d28f5171ba"), "Night Club & MJ Keenan", "Gone", "💥");
        yield return new Music(new Guid("0d8c9a04-09c9-4998-b91c-49f4aa510247"), "Bad Omens", "Just Pretend", "💥");
        #endregion

    }
}