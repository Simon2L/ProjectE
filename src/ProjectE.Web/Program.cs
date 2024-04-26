using FastEndpoints;
using FastEndpoints.Security;
using FastEndpoints.Swagger;
using ProjectE.Music;
using Serilog;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(policy =>
{
    policy.AddPolicy("CorsAllAccessPolicy", option =>
    option.AllowAnyOrigin()
    .AllowAnyHeader()
    .AllowAnyMethod()
    );
});

builder.Services
   .AddAuthenticationJwtBearer(s => s.SigningKey = "EXTREMLY LONG LOGIN KEY THAT SHOULD BE IN A JSON FILE")
   .AddAuthorization()
   .AddFastEndpoints()
   .SwaggerDocument();

List<Assembly> mediatRAssemblies = [typeof(Program).Assembly];
builder.Services.AddMusicServices(builder.Configuration, mediatRAssemblies);

// Set up MediatR
builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssemblies(mediatRAssemblies.ToArray()));


var app = builder.Build();

app.UseCors("CorsAllAccessPolicy");

app.UseAuthentication()
    .UseAuthorization();

app.UseFastEndpoints().
    UseSwaggerGen();

app.Run();

public partial class Program { } // needed for tests
