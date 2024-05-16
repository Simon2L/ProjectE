using Microsoft.EntityFrameworkCore;

namespace ProjectE.Users;

internal class EfApplicationUserRepository(UsersDbContext dbContext) 
    : IApplicationUserRepository
{
    private readonly UsersDbContext _dbContext = dbContext;

    public Task<ApplicationUser> GetUserWithFavoritesByEmailAddress(string email)
    {
        return _dbContext.ApplicationUsers
            .Include(user => user.FavoriteSongs)
            .Include(user => user.FavoriteMovies)
            .Include(user => user.FavoriteGames)
            .SingleAsync(user => user.Email == email);
    }
    
    public Task SaveChangesAsync()
    {
        return _dbContext.SaveChangesAsync();
    }
}
