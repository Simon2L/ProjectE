using Ardalis.Result;
using MediatR;
using ProjectE.Users.Contracts;

namespace ProjectE.Users.Integrations;

internal class IsFavoritedByUserHandler(IApplicationUserRepository applicationUser) 
    : IRequestHandler<IsFavoritedByUserQuery, Result<List<Guid>>>
{
    private readonly IApplicationUserRepository _applicationUser = applicationUser;

    public async Task<Result<List<Guid>>> Handle(IsFavoritedByUserQuery req, 
        CancellationToken ct)
    {
        var user = await _applicationUser.GetUserWithFavoritesByEmailAddress(req.Email);

        var result = user.FavoriteSongs.Join(
            req.SongIds, 
            song => song.SongId, 
            guid => guid, 
            (songId, guid) => songId)
            .Select(song => song.SongId)
            .ToList();

        return result;
    }
}
