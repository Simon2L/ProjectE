using FluentValidation;

namespace ProjectE.Users.UseCases.Favorites;

public class AddSongToFavoritesCommandValidator : AbstractValidator<AddSongToFavoritesCommand>
{
    public AddSongToFavoritesCommandValidator()
    {
        RuleFor(x => x.Email)
            .NotEmpty()
            .WithMessage("EmailAddress is required");

        RuleFor(x => x.Song.Id)
            .NotEmpty()
            .WithMessage("Not a valid SongId");

        RuleFor(x => x.Song.SongName)
            .NotEmpty()
            .WithMessage("Song name cannot be empty");

        RuleFor(x => x.Song.Artist)
            .NotEmpty()
            .WithMessage("Artist cannot be empty");
    }
}