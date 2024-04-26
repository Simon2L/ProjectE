using FluentValidation;

namespace ProjectE.Users.UseCases.Favorites;

public class AddSongToFavoritesCommandValidator : AbstractValidator<AddSongToFavoritesCommand>
{
    public AddSongToFavoritesCommandValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("EmailAddress is required");

        RuleFor(x => x.SongId)
            .NotEmpty()
            .WithMessage("Not a valid SongId");
    }
}