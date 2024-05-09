using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectE.Games.Data;

public class GameConfiguration : IEntityTypeConfiguration<Game>
{
    void IEntityTypeConfiguration<Game>.Configure(EntityTypeBuilder<Game> builder)
    {
        builder.Property(g => g.Name)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(g => g.Emoji)
            .HasMaxLength(50)
            .IsRequired();
        builder.Property(g => g.Rating)
            .IsRequired();
    }
}