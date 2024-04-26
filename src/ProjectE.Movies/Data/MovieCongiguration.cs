using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectE.Movies.Data;

internal class MovieCongiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.Property(p => p.Title)
            .HasMaxLength(DataSchemaConstants.DEFAULT_TITLE_LENGTH)
            .IsRequired();

        builder.Property(p => p.Rating)
            .IsRequired();

        builder.Property(p => p.Emoji)
            .HasMaxLength(DataSchemaConstants.DEFAULT_EMOJI_LENGTH)
            .IsRequired()
            .IsUnicode();

        builder.HasData(GetMovieData());
    }

    public static IEnumerable<Movie> GetMovieData()
    {
        yield return new Movie(Guid.NewGuid(), "Dune", 9.9, "yippe");
    }
}
