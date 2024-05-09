using FluentValidation;

namespace ProjectE.Users.UseCases.Favorites;

public class AddMovieToFavoritesCommandValidator : AbstractValidator<AddMovieToFavoritesCommand>
{
    public AddMovieToFavoritesCommandValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("EmailAddress is required");

        RuleFor(x => x.Movie.Id)
            .NotEmpty()
            .WithMessage("Not a valid MovieId");

        RuleFor(x => x.Movie.Title)
            .NotEmpty()
            .WithMessage("Movie name cannot be empty");

        RuleFor(x => x.Movie.Emoji)
            .NotEmpty()
            .WithMessage("Emoji cannot be empty");

        RuleFor(x => x.Movie.Rating)
            .NotEmpty()
            .WithMessage("Rating cannot be empty");
    }
}