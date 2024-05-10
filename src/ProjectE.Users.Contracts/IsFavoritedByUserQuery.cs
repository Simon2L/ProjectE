using Ardalis.Result;
using MediatR;

namespace ProjectE.Users.Contracts;

public record IsFavoritedByUserQuery(string Email, List<Guid> SongIds) 
    : IRequest<Result<List<Guid>>>;
