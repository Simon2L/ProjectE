using Ardalis.GuardClauses;

namespace ProjectE.Movies;

internal class Movie
{
    public Guid Id { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public double Rating { get; private set; }
    public string Emoji { get; private set; } = string.Empty;

    internal Movie(Guid id, string title, double rating, string emoji)
    {
        Id = Guard.Against.Default(id);
        Title = Guard.Against.NullOrEmpty(title);
        Rating = Guard.Against.NegativeOrZero(rating);
        Emoji = Guard.Against.NullOrEmpty(emoji);
    }
}
