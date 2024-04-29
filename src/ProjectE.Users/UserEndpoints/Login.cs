using FastEndpoints;
using FastEndpoints.Security;
using Microsoft.AspNetCore.Identity;

namespace ProjectE.Users.UserEndpoints;

public record UserLoginRequest(string Email, string Password);
internal class Login(UserManager<ApplicationUser> userManager) : Endpoint<UserLoginRequest>
{
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    public override void Configure()
    {
        Post("/users/login");
        AllowAnonymous();
    }

    public override async Task HandleAsync(UserLoginRequest req, 
        CancellationToken ct)
    {
        var user = await _userManager.FindByEmailAsync(req.Email);
        if (user is null)
        {
            await SendUnauthorizedAsync();
            return;
        }
        var loginSuccessful = await _userManager.CheckPasswordAsync(user, req.Password);

        if (!loginSuccessful) 
        {
            await SendUnauthorizedAsync();
            return;
        }

        var token = JwtBearer.CreateToken(o =>
        {
            o.SigningKey = "EXTREMLY LONG LOGIN KEY THAT SHOULD BE IN A JSON FILE";
            o.ExpireAt = DateTime.UtcNow.AddDays(7);
            o.User.Claims.Add(("EmailAddress", req.Email));
        });

        await SendAsync(token);
    }
}
