using Ardalis.GuardClauses;

namespace ProjectE.Users;

internal class Movie
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public Guid MovieId { get; set; }
    public string Title { get; set; } = string.Empty;
    public double Rating { get; set; }
    public string Emoji { get; set; } = string.Empty;

    public Movie(Guid id, string title, double rating, string emoji)
    {
        MovieId = Guard.Against.Default(id);
        Title= Guard.Against.NullOrEmpty(title);
        Rating = Guard.Against.NegativeOrZero(rating);
        Emoji = Guard.Against.NullOrEmpty(emoji);
    }

    public Movie()
    {
        // for EF
    }
}