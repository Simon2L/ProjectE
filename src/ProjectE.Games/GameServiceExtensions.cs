using FastEndpoints;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using ProjectE.Games.Data;
using System.Reflection;

namespace ProjectE.Games;

public static class GameServiceExtensions
{
    public static IServiceCollection AddGamesServices(
        this IServiceCollection services,
        ConfigurationManager config,
        List<Assembly> mediatRAssemblies)
    {
        string? connectionString = config.GetConnectionString("GamesConnectionString");
        services.AddDbContext<GameDbContext>(options =>
        options.UseSqlServer(connectionString));
        services.AddScoped<IGameRepository, EfGameRepository>();
        services.AddScoped<IGameService, GameService>();

        //add for mediatR to work
        mediatRAssemblies.Add(typeof(GameServiceExtensions).Assembly);

        return services;
    }
}
