using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjectE.Movies.Data;
using System.Reflection;

namespace ProjectE.Movies;

public static class MovieServiceExtensions
{
    public static IServiceCollection AddMovieServices(
        this IServiceCollection services,
        ConfigurationManager config,
        List<Assembly> mediatRAssemblies)
    {
        string? connectionString = config.GetConnectionString("MoviesConnectionString");
        services.AddDbContext<MovieDbContext>(options =>
        options.UseSqlServer(connectionString));
        services.AddScoped<IMovieRepository, EfMovieRepository>();
        services.AddScoped<IMovieService, MovieService>();

        //add for mediatR to work
        mediatRAssemblies.Add(typeof(MovieServiceExtensions).Assembly);

        return services;
    }
}
