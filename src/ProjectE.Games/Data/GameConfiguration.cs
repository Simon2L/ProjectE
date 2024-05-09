using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectE.Games.Data;

internal class GameConfiguration : IEntityTypeConfiguration<Game>
{
    public void Configure(EntityTypeBuilder<Game> builder)
    {
        builder.Property(g => g.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(g => g.Emoji)
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(g => g.Rating)
            .IsRequired();

        builder.HasData(GetGames());
    }

    public static IEnumerable<Game> GetGames()
    {
        yield return new Game(Guid.Parse("GUID"), "GAME NAME", 1, "Emoji");
    }
}