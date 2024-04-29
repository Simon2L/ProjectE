namespace ProjectE.Users;

internal interface IApplicationUserRepository
{
    Task<ApplicationUser> GetUserWithFavoritesByEmailAddress(string email);
    Task SaveChangesAsync();
}
