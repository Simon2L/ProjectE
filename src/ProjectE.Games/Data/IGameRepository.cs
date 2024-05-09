namespace ProjectE.Games.Data;

internal interface IGameRepository
{
    Task<List<Game>> ListAsync();
}
