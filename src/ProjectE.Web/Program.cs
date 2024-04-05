using FastEndpoints;
using FastEndpoints.Security;
using FastEndpoints.Swagger;
using ProjectE.Music;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// TODO: Authentication for a later feature 
builder.Services
   //.AddAuthenticationJwtBearer(s => s.SigningKey = "secret key from json")
   //.AddAuthorization()
   .AddFastEndpoints()
   .SwaggerDocument();

List<Assembly> mediatRAssemblies = [typeof(Program).Assembly];
builder.Services.AddMusicServices(builder.Configuration, mediatRAssemblies);

// Set up MediatR
builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssemblies(mediatRAssemblies.ToArray()));

var app = builder.Build();

//app.UseAuthentication()
//    .UseAuthorization();

app.UseFastEndpoints().
    UseSwaggerGen();

app.Run();

public partial class Program { } // needed for tests
