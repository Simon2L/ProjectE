﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectE.Games.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Games");

            migrationBuilder.CreateTable(
                name: "Games",
                schema: "Games",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    Emoji = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "Games",
                table: "Games",
                columns: new[] { "Id", "Emoji", "Name", "Rating" },
                values: new object[,]
                {
                    { new Guid("1b8d5904-6a34-4793-ba18-7c5471e11c8e"), "🌦️", "Spiritfarer", 2020.0 },
                    { new Guid("2762c66d-ddec-439a-8107-23b4b1d0135b"), "🃏", "Balatro", 2024.0 },
                    { new Guid("34fcf3ec-d35e-4d02-906c-64ed86555929"), "🥲", "Elden Ring", 2022.0 },
                    { new Guid("40cd4519-0088-40ad-8802-5bd48277ed27"), "👻", "Phasmophobia", 2020.0 },
                    { new Guid("41009adf-7f4f-47a6-8878-4dd7b797fdd0"), "👻", "Lethal Company", 2023.0 },
                    { new Guid("4653eefd-5ca8-416f-95fc-81c5444d196f"), "🃏", "Inscryption", 2021.0 },
                    { new Guid("4a758435-c5f7-4c22-8758-6047e994b7e9"), "💀", "BPM: BULLETS PER MINUTE", 2020.0 },
                    { new Guid("55c16bbe-d6c5-4c6f-b892-7bac72b26e71"), "🌄", "Undertale", 2015.0 },
                    { new Guid("5ffd015b-4045-412a-82cc-e46665fc6ec5"), "🐸", "Risk of Rain 2", 2020.0 },
                    { new Guid("6592b6e7-d9ff-4ed1-ad52-581c58785a6d"), "💀", "Dusk", 2018.0 },
                    { new Guid("6ad0a3da-1f70-4e8e-b5b4-6f05ed8fac7a"), "🌦️", "Wandersong", 2018.0 },
                    { new Guid("6c43c854-eef9-417e-8703-23e68f6c9f6a"), "🫶", "Celeste", 2018.0 },
                    { new Guid("6e074183-70a5-486e-b6a7-950108d493c2"), "💟", "Portal 2", 2011.0 },
                    { new Guid("755b409d-1e15-4eb2-a3ea-dddfcb718e4e"), "💀", "Ultrakill", 2020.0 },
                    { new Guid("887eae4c-280a-486c-b96a-c8fe21a3ca63"), "🫶", "Hollow Knight", 2017.0 },
                    { new Guid("96539e50-84fa-411e-bfb0-601584a1dab5"), "🃏", "Slay the Spire", 2019.0 },
                    { new Guid("9e615e17-0e24-4881-8454-b12bd172cae8"), "💟", "We Were Here Together", 2019.0 },
                    { new Guid("a6132bec-de8c-4df6-bb47-e72d053ae040"), "🥲", "Sekiro: Shadows Die Twice", 2019.0 },
                    { new Guid("cb7e4820-eb31-4a15-8493-f2cedae0c152"), "🌄", "Stardew Valley", 2016.0 },
                    { new Guid("d88c04ca-e535-428f-9182-f63a92934d97"), "🐸", "Dead Cells", 2018.0 },
                    { new Guid("d9aad535-1e2f-4908-8090-18dcc5ff0a06"), "🌦️", "Stray", 2022.0 },
                    { new Guid("e80c6d13-abfe-4928-9f40-0eae0c4c6b38"), "🐸", "Hades", 2020.0 },
                    { new Guid("ed380097-59a6-4988-ac90-6971656d9d6b"), "👻", "Content Warning", 2024.0 },
                    { new Guid("edbf998c-5a48-45b1-bc43-1b810d98269d"), "🥲", "Bloodborne", 2015.0 },
                    { new Guid("f50109a8-e896-4057-8ead-32fbdc6bb308"), "🌄", "Terraria", 2011.0 },
                    { new Guid("f931325e-c134-45bb-84aa-9e3118c0d055"), "🫶", "Jump King", 2019.0 },
                    { new Guid("f97c8c66-9dfb-4ebd-902d-93710d6605f5"), "💟", "Haven", 2020.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Games",
                schema: "Games");
        }
    }
}
