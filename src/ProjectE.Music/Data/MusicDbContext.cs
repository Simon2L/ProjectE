using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ProjectE.Music.Data;

internal class MusicDbContext : DbContext
{
    internal DbSet<Music> Music { get; set; }
    public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.HasDefaultSchema("Music");

        //seperate configs for each entity
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
