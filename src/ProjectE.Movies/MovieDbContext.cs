using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection;

namespace ProjectE.Movies;

internal class MovieDbContext : DbContext
{
    internal DbSet<Movie> Movies { get; set; }
    public MovieDbContext(DbContextOptions<MovieDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasDefaultSchema("Movies");

        //seperate configs for each entity
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

internal class MovieCongiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.Property(p => p.Title)
            .HasMaxLength(DataSchemaConstants.DEFAULT_TITLE_LENGTH)
            .IsRequired();

        builder.Property(p => p.Description)
            .HasMaxLength(DataSchemaConstants.DEFAULT_DESCRIPTION_LENGTH)
            .IsRequired();

        builder.Property(p => p.Emoji)
            .HasMaxLength(DataSchemaConstants.DEFAULT_EMOJI_LENGTH)
            .IsRequired()
            .IsUnicode();

        builder.HasData(GetMovieData());
    }

    public static IEnumerable<Movie> GetMovieData()
    {
        yield return new Movie(Guid.NewGuid(), "Dune", "Lisan-Al-Gahib", "yippe");
    }
}
