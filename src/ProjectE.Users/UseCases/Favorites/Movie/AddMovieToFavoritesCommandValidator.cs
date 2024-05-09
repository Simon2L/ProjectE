using FluentValidation;

namespace ProjectE.Users.UseCases.Favorites.Movie;

public class AddMovieToFavoritesCommandValidator : AbstractValidator<AddMovieToFavoritesCommand>
{
    public AddMovieToFavoritesCommandValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("EmailAddress is required");

        RuleFor(x => x.Movie.Id)
            .NotEmpty()
            .WithMessage("Not a valid SongId");

        RuleFor(x => x.Movie.Title)
            .NotEmpty()
            .WithMessage("Song name cannot be empty");

        RuleFor(x => x.Movie.Emoji)
            .NotEmpty()
            .WithMessage("Artist cannot be empty");

        RuleFor(x => x.Movie.Rating)
            .NotEmpty()
            .WithMessage("Ratinmg cannot be empty");
    }
}