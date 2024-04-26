using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ProjectE.Movies.Data;

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

    protected override void ConfigureConventions(
        ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<double>()
            .HavePrecision(3, 1);
    }
}
