using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectE.Movies.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Movies");

            migrationBuilder.CreateTable(
                name: "Movies",
                schema: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Rating = table.Column<double>(type: "float(3)", precision: 3, scale: 1, nullable: false),
                    Emoji = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Movies",
                table: "Movies",
                columns: new[] { "Id", "Emoji", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("191496d6-40cd-46ed-a749-4d6cc435d8ca"), "🔍", 7.5999999999999996, "Killers of the Flower Moon" },
                    { new Guid("1fb473de-4e19-454a-9e71-9333b7ce1c88"), "🛰️", 8.0, "The Martian" },
                    { new Guid("33c70fae-89bb-4169-95e0-7f755c7d6625"), "🧑‍🎤 ", 7.2999999999999998, "Rocketman" },
                    { new Guid("3ece3ab6-7727-4bc0-9317-778c49f3015c"), "💌", 7.7999999999999998, "Pride & Prejudice" },
                    { new Guid("414d085f-528c-45fe-8749-ee2e13bbe20a"), "🎤 ", 8.0, "La La Land" },
                    { new Guid("47f4cc72-559e-4278-bcc5-f703f289a0d5"), "💌", 7.0, "Dirty Dancing" },
                    { new Guid("492e1cab-37a1-491f-b2e1-6b2c44272eb1"), "🔍", 8.5, "The Prestige" },
                    { new Guid("4ab7230b-00cc-4c19-bf6c-10757b034069"), "🏆", 8.0999999999999996, "Rush" },
                    { new Guid("60b82e02-14ee-431c-bb5a-2038b1483083"), "🎤 ", 7.5999999999999996, "A Star is Born" },
                    { new Guid("849e8fbf-186a-4684-94ef-749c9cb97657"), "🧝‍♀️", 8.9000000000000004, "The Fellowship of the Ring " },
                    { new Guid("8d0e1c90-3dc7-464f-a9f6-1386d0712bc8"), "🧑‍🎤 ", 7.9000000000000004, "Bohemian Rhapsody" },
                    { new Guid("aeb01cbc-0365-4773-801c-0e987329ef09"), "🩸", 7.7999999999999998, "Get Out" },
                    { new Guid("b372fb74-26ee-41f7-9557-e00c95422609"), "🧝‍♀️", 7.7999999999999998, "The Hobbit" },
                    { new Guid("c09be204-ce54-4de2-aaaf-846b9ff3d3d2"), "🩸", 6.7999999999999998, "The First Omen" },
                    { new Guid("c16323d1-f1d5-4ba8-85a2-b6f2b425c511"), "😂", 7.5999999999999996, "Superbad" },
                    { new Guid("cb0d79d9-506e-4dfb-8805-2cddc447f819"), "🧝‍♀️", 6.9000000000000004, "The Chronicles of Narnia" },
                    { new Guid("cccf4cbb-9c69-424e-b52f-b234ba51c281"), "😂", 7.9000000000000004, "The Holdovers" },
                    { new Guid("cda4498c-7fda-4039-9d46-fa1cd83512a6"), "💌", 7.7000000000000002, "Brokeback Mountain" },
                    { new Guid("cec6ea94-91b2-4fb8-adaa-d79dbf7993e0"), "🛰️", 8.6999999999999993, "Interstellar" },
                    { new Guid("d34c3e25-41d7-4e71-8a84-8526ab524691"), "🩸", 7.0999999999999996, "Late Night with the Devil" },
                    { new Guid("d577bf06-829b-415b-816d-364367b90060"), "🔍", 8.1999999999999993, "Shutter Island" },
                    { new Guid("dff682eb-87b6-40ee-96fb-4fe819e3a3f7"), "🎤 ", 8.5, "Whiplash" },
                    { new Guid("e3ae85e0-6863-41c9-ad60-6ab6809a0934"), "🏆", 7.7000000000000002, "The Iron Claw" },
                    { new Guid("ee99387d-7c54-4eda-8ed6-94127ef9513a"), "😂", 7.2999999999999998, "The Fall Guy" },
                    { new Guid("f5525218-aac2-48cf-bbc7-d49b1b95272f"), "🧑‍🎤 ", 7.2999999999999998, "Elvis" },
                    { new Guid("f8743c4c-7237-4b09-bad7-23ef21f017e0"), "🏆", 8.0999999999999996, "Ford v Ferrari" },
                    { new Guid("fc7354e3-d210-4d78-ad78-aea1cf750878"), "🛰️", 8.0, "Dune" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies",
                schema: "Movies");
        }
    }
}
