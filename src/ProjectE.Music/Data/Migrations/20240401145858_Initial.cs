using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectE.Music.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Music");

            migrationBuilder.CreateTable(
                name: "Music",
                schema: "Music",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SongName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Artist = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Emoji = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Music", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Music",
                table: "Music",
                columns: new[] { "Id", "Artist", "Emoji", "SongName" },
                values: new object[,]
                {
                    { new Guid("0a4a2648-a7f6-41c6-b3e6-d9329b2a345d"), "Abba", "Emoji", "Dancing Queen" },
                    { new Guid("10ea0c9a-d776-4d66-a383-dc6a00880d76"), "The Weeknd", "Emoji", "Die For You" },
                    { new Guid("14311560-98e1-4ca4-bfa6-4cb022501b2f"), "Lady Gaga", "Emoji", "Poker Face" },
                    { new Guid("2a31f0f1-e815-4590-885c-6c03de9c7ba2"), "Abba", "Emoji", "Angel Eyes" },
                    { new Guid("444521eb-fc20-4cf5-b935-fd6008b928bf"), "Avicii", "Emoji", "Addicted To You" },
                    { new Guid("59fdc46f-8528-44c3-8095-ebbc6e5785ea"), "Avicii", "Emoji", "Levels" },
                    { new Guid("850111d5-6409-4196-a362-c53f007ed4dd"), "Rihanna", "Emoji", "Where Have You Been" },
                    { new Guid("9268891c-3aa8-4aff-ac5a-4454fa6aa672"), "Lady Gaga", "Emoji", "Bad Romace" },
                    { new Guid("d469ca99-8520-4f03-ad64-324dda4b0d78"), "The Weeknd", "Emoji", "Blinding Lights" },
                    { new Guid("f25c986b-fc36-439e-bc29-9616ff2d7e95"), "Rihanna", "Emoji", "Don’t Stop the Music" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Music",
                schema: "Music");
        }
    }
}
