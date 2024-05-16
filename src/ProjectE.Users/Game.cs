using Ardalis.GuardClauses;

namespace ProjectE.Users;

internal class Game
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid GameId { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Rating { get; set; }
    public string Emoji { get; set; } = string.Empty;

    public Game(Guid id, string title, double rating, string emoji)
    {
        GameId = Guard.Against.Default(id);
        Name = Guard.Against.NullOrEmpty(title);
        Rating = Guard.Against.NegativeOrZero(rating);
        Emoji = Guard.Against.NullOrEmpty(emoji);
    }

    public Game()
    {
        // for EF
    }
}
