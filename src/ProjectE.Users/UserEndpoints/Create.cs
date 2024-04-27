using FastEndpoints;
using Microsoft.AspNetCore.Identity;

namespace ProjectE.Users.UserEndpoints;

public record CreateUserRequest(string Email, string UserName, string Password);

internal class Create(UserManager<ApplicationUser> userManager) : Endpoint<CreateUserRequest>
{
    private readonly UserManager<ApplicationUser> _userManager = userManager;

    public override void Configure()
    {
        Post("/users");
        AllowAnonymous();
    }

    public override async Task HandleAsync(CreateUserRequest req, 
        CancellationToken ct)
    {
        var newUser = new ApplicationUser
        {
            Email = req.Email,
            UserName = req.UserName,
        };

        var result = await _userManager.CreateAsync(newUser, req.Password);

        await SendOkAsync(result);
    }
}

