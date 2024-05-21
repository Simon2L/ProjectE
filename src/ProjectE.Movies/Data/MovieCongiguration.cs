using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectE.Movies.Data;

internal class MovieCongiguration : IEntityTypeConfiguration<Movie>
{
    public void Configure(EntityTypeBuilder<Movie> builder)
    {
        builder.Property(p => p.Title)
            .HasMaxLength(DataSchemaConstants.DEFAULT_TITLE_LENGTH)
            .IsRequired();

        builder.Property(p => p.Rating)
            .IsRequired();

        builder.Property(p => p.Emoji)
            .HasMaxLength(DataSchemaConstants.DEFAULT_EMOJI_LENGTH)
            .IsRequired();

        builder.HasData(GetMovieData());
    }

    public static IEnumerable<Movie> GetMovieData()
    {
        #region DATA
        yield return new Movie(new Guid("fc7354e3-d210-4d78-ad78-aea1cf750878"), "Dune", 8.0, "🛰️");
        yield return new Movie(new Guid("cec6ea94-91b2-4fb8-adaa-d79dbf7993e0"), "Interstellar", 8.7, "🛰️");
        yield return new Movie(new Guid("1fb473de-4e19-454a-9e71-9333b7ce1c88"), "The Martian", 8.0, "🛰️");
        yield return new Movie(new Guid("849e8fbf-186a-4684-94ef-749c9cb97657"), "The Fellowship of the Ring ", 8.9, "🧝‍♀️");
        yield return new Movie(new Guid("b372fb74-26ee-41f7-9557-e00c95422609"), "The Hobbit", 7.8, "🧝‍♀️");
        yield return new Movie(new Guid("cb0d79d9-506e-4dfb-8805-2cddc447f819"), "The Chronicles of Narnia", 6.9, "🧝‍♀️");
        yield return new Movie(new Guid("dff682eb-87b6-40ee-96fb-4fe819e3a3f7"), "Whiplash", 8.5, "🎤 ");
        yield return new Movie(new Guid("414d085f-528c-45fe-8749-ee2e13bbe20a"), "La La Land", 8.0, "🎤 ");
        yield return new Movie(new Guid("60b82e02-14ee-431c-bb5a-2038b1483083"), "A Star is Born", 7.6, "🎤 ");
        yield return new Movie(new Guid("8d0e1c90-3dc7-464f-a9f6-1386d0712bc8"), "Bohemian Rhapsody", 7.9, "🧑‍🎤 ");
        yield return new Movie(new Guid("33c70fae-89bb-4169-95e0-7f755c7d6625"), "Rocketman", 7.3, "🧑‍🎤 ");
        yield return new Movie(new Guid("f5525218-aac2-48cf-bbc7-d49b1b95272f"), "Elvis", 7.3, "🧑‍🎤 ");
        yield return new Movie(new Guid("4ab7230b-00cc-4c19-bf6c-10757b034069"), "Rush", 8.1, "🏆");
        yield return new Movie(new Guid("e3ae85e0-6863-41c9-ad60-6ab6809a0934"), "The Iron Claw", 7.7, "🏆");
        yield return new Movie(new Guid("f8743c4c-7237-4b09-bad7-23ef21f017e0"), "Ford v Ferrari", 8.1, "🏆");
        yield return new Movie(new Guid("3ece3ab6-7727-4bc0-9317-778c49f3015c"), "Pride & Prejudice", 7.8, "💌");
        yield return new Movie(new Guid("47f4cc72-559e-4278-bcc5-f703f289a0d5"), "Dirty Dancing", 7.0, "💌");
        yield return new Movie(new Guid("cda4498c-7fda-4039-9d46-fa1cd83512a6"), "Brokeback Mountain", 7.7, "💌");
        yield return new Movie(new Guid("d34c3e25-41d7-4e71-8a84-8526ab524691"), "Late Night with the Devil", 7.1, "🩸");
        yield return new Movie(new Guid("aeb01cbc-0365-4773-801c-0e987329ef09"), "Get Out", 7.8, "🩸");
        yield return new Movie(new Guid("c09be204-ce54-4de2-aaaf-846b9ff3d3d2"), "The First Omen", 6.8, "🩸");
        yield return new Movie(new Guid("c16323d1-f1d5-4ba8-85a2-b6f2b425c511"), "Superbad", 7.6, "😂");
        yield return new Movie(new Guid("ee99387d-7c54-4eda-8ed6-94127ef9513a"), "The Fall Guy", 7.3, "😂");
        yield return new Movie(new Guid("cccf4cbb-9c69-424e-b52f-b234ba51c281"), "The Holdovers", 7.9, "😂");
        yield return new Movie(new Guid("191496d6-40cd-46ed-a749-4d6cc435d8ca"), "Killers of the Flower Moon", 7.6, "🔍");
        yield return new Movie(new Guid("d577bf06-829b-415b-816d-364367b90060"), "Shutter Island", 8.2, "🔍");
        yield return new Movie(new Guid("492e1cab-37a1-491f-b2e1-6b2c44272eb1"), "The Prestige", 8.5, "🔍");
        #endregion
    }
}
