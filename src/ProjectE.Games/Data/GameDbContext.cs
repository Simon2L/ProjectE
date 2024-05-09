using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ProjectE.Games.Data;

internal class GameDbContext : DbContext
{
    public DbSet<Game> Games { get; set; }

    public GameDbContext(DbContextOptions<GameDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasDefaultSchema("Games");

        //seperate configs for each entity
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
