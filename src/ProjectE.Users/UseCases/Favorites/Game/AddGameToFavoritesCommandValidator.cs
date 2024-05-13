using FluentValidation;

namespace ProjectE.Users.UseCases.Favorites;

public class AddGameToFavoritesCommandValidator : AbstractValidator<AddGameToFavoritesCommand>
{
    public AddGameToFavoritesCommandValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("EmailAddress is required");

        RuleFor(x => x.Game.Id)
            .NotEmpty()
            .WithMessage("Not a valid GameId");

        RuleFor(x => x.Game.Name)
            .NotEmpty()
            .WithMessage("Game name cannot be empty");

        RuleFor(x => x.Game.Emoji)
            .NotEmpty()
            .WithMessage("Emoji cannot be empty");

        RuleFor(x => x.Game.Rating)
            .NotEmpty()
            .WithMessage("Rating cannot be empty");
    }
}