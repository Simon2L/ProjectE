using Ardalis.GuardClauses;

namespace ProjectE.Games;

internal class Game(Guid id, string name, double rating, string emoji)
{
    public Guid Id { get; private set; } = Guard.Against.Default(id);
    public string Name { get; private set; } = Guard.Against.NullOrEmpty(name);
    public double Rating { get; private set; } = Guard.Against.NegativeOrZero(rating);
    public string Emoji { get; private set; } = Guard.Against.NullOrEmpty(emoji);
}