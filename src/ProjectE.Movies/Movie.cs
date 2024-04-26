using Ardalis.GuardClauses;

namespace ProjectE.Movies;

internal class Movie
{
    public Guid Id { get; private set; }
    public string Title { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public string Emoji { get; private set; } = string.Empty;

    internal Movie(Guid id, string title, string description, string emoji)
    {
        Id = Guard.Against.Default(id);
        Title = Guard.Against.NullOrEmpty(title);
        Description = Guard.Against.NullOrEmpty(description);
        Emoji = Guard.Against.NullOrEmpty(emoji);
    }
}
