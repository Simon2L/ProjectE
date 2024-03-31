using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectE.Music.Data;
using System.Reflection;

namespace ProjectE.Music;

public static class MusicServiceExtensions
{
    public static IServiceCollection AddMusicServices(
        this IServiceCollection services,
        ConfigurationManager config,
        List<Assembly> mediatRAssemblies)
    {
        string? connectionString = config.GetConnectionString("MusicConnectionString");
        services.AddDbContext<MusicDbContext>(options =>
        options.UseSqlServer(connectionString));
        services.AddScoped<IMusicRepository, EfMusicRepository>();
        services.AddScoped<IMusicService, MusicService>();

        //add for mediatR to work
        mediatRAssemblies.Add(typeof(MusicServiceExtensions).Assembly);

        return services;
    }
}
