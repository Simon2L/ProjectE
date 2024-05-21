using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ProjectE.Users;

internal class UsersDbContext : IdentityDbContext
{
    public UsersDbContext(DbContextOptions<UsersDbContext> options) : base(options)
    {
    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("Users");

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(modelBuilder);
    }

    protected override void ConfigureConventions(
        ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<double>()
            .HavePrecision(3, 1);


    }

}