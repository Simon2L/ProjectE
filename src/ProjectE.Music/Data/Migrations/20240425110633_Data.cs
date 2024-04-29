using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectE.Music.Data.Migrations
{
    /// <inheritdoc />
    public partial class Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("0a4a2648-a7f6-41c6-b3e6-d9329b2a345d"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("10ea0c9a-d776-4d66-a383-dc6a00880d76"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("14311560-98e1-4ca4-bfa6-4cb022501b2f"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("2a31f0f1-e815-4590-885c-6c03de9c7ba2"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("d469ca99-8520-4f03-ad64-324dda4b0d78"));

            migrationBuilder.UpdateData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("444521eb-fc20-4cf5-b935-fd6008b928bf"),
                column: "Emoji",
                value: "💉");

            migrationBuilder.UpdateData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("59fdc46f-8528-44c3-8095-ebbc6e5785ea"),
                column: "Emoji",
                value: "📶");

            migrationBuilder.UpdateData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("850111d5-6409-4196-a362-c53f007ed4dd"),
                columns: new[] { "Artist", "Emoji", "SongName" },
                values: new object[] { "Sting", "💔♠️", "Shape of My Heart" });

            migrationBuilder.UpdateData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("9268891c-3aa8-4aff-ac5a-4454fa6aa672"),
                columns: new[] { "Artist", "Emoji", "SongName" },
                values: new object[] { "Human League", "⚡️💭", "Electric Dreams" });

            migrationBuilder.UpdateData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("f25c986b-fc36-439e-bc29-9616ff2d7e95"),
                columns: new[] { "Artist", "Emoji", "SongName" },
                values: new object[] { "Queen", "👑🎶", "Bohemian Rhapsody" });

            migrationBuilder.InsertData(
                schema: "Music",
                table: "Music",
                columns: new[] { "Id", "Artist", "Emoji", "SongName" },
                values: new object[,]
                {
                    { new Guid("0507276e-39b0-4d33-97fd-cb14d8bdaa2f"), "Cyndi Lauper", "⏰🔄", "Time After Time" },
                    { new Guid("05931f03-ec5e-4b68-8e1c-fc2bbfe27f47"), "Queen", "👑👸", "Killer Queen" },
                    { new Guid("080ef095-34b1-405b-a537-789fb9d067a9"), "The Police", "✨🔮", "Every Little Thing She Does Is Magic" },
                    { new Guid("0e4bc0a4-3e7a-4a7b-b98d-02402139e4ad"), "George Michael", "💔🎷", "Careless Whisper" },
                    { new Guid("0f22a7f2-5a12-4b1d-9365-4d63581a63e9"), "Queen", "💖🎶", "Love of My Life" },
                    { new Guid("0f3f1275-cf79-4a65-aaf7-7e4d991cc4e0"), "Queen", "💖🎶", "Love of My Life" },
                    { new Guid("12058a5a-89f5-45f4-94fb-d5bb16b44a82"), "Guns N' Roses", "🍬👶🎸", "Sweet Child o' Mine" },
                    { new Guid("120b547d-9d4f-44f2-8127-e298c05e4f56"), "Berlin", "🌬️💔", "Take My Breath Away" },
                    { new Guid("15b4c9fb-83cd-4a06-9b5a-1cc9e66a5a89"), "Queen", "📻👑", "Radio Ga Ga" },
                    { new Guid("196839e8-0733-4813-b3e4-9edfb9917d3f"), "USA for Africa", "🌎👫🎵", "We Are the World" },
                    { new Guid("199b3034-5b8b-4648-b7f4-89fc2fa537f0"), "Queen", "🆓🎶", "I Want to Break Free" },
                    { new Guid("19f003d5-3fe6-4a80-8a60-90b5cd1d8e1a"), "The Police", "👀👣", "Every Breath You Take" },
                    { new Guid("1da53585-99c4-48e3-b9cc-9f44748178e1"), "The Beatles", "📅🎵", "Yesterday" },
                    { new Guid("1e98208e-85c7-4b3e-8567-e1ff5e2f5d67"), "Michael Jackson", "🕺🌟", "Billie Jean" },
                    { new Guid("1f398abc-72e5-4b47-895f-4aef46e53dc3"), "Michael Jackson", "🥁👊", "Beat It" },
                    { new Guid("1f9ebd8b-65a7-4b40-b663-4fdcf6fd5df7"), "Whitney Houston", "💔🎶", "I Will Always Love You" },
                    { new Guid("22a24321-7e5e-48d6-80bb-b8888bcbce2e"), "Queen", "👑🎸", "We Will Rock You" },
                    { new Guid("272bd92b-7f2d-49eb-9a94-7a9c3ff870c4"), "Queen", "💀🎶", "Another One Bites the Dust" },
                    { new Guid("29220b79-1209-4fc9-9e89-c2565df2c390"), "The Beatles", "📅🎵", "Yesterday" },
                    { new Guid("2bdf4c4f-196b-462e-b857-c3bc85d55e6f"), "Bonnie Tyler", "🌑💔", "Total Eclipse of the Heart" },
                    { new Guid("2c6d6935-0f4f-4c4b-b22e-4436aa06dbb0"), "Michael Jackson", "🚫👎", "Bad" },
                    { new Guid("2cb56062-8994-4c38-9717-24b8c96c855e"), "Foreigner", "❤️🌏", "I Want to Know What Love Is" },
                    { new Guid("2d537b70-306d-4678-81f3-1d8a28c25438"), "Queen", "🏆👑", "We Are the Champions" },
                    { new Guid("2d6d2865-0ec2-47d4-abe1-cc8bf2444652"), "Poison", "🌹🎸💔", "Every Rose Has Its Thorn" },
                    { new Guid("30e8be19-cabb-4fc2-ae33-f74a84eeb441"), "Queen", "👑🎸", "We Will Rock You" },
                    { new Guid("36924e37-aa68-4918-927b-48b57b8b5d7d"), "Journey", "🛣️🎤", "Don't Stop Believin'" },
                    { new Guid("3ff00557-4e4e-4b11-82a1-92fbd6d188e3"), "John Travolta & Olivia Newton-John", "👫💖", "You're the One That I Want" },
                    { new Guid("43f2ef8c-24b6-43f0-a94c-55c8d828079a"), "Michael Jackson", "🕴🔫", "Smooth Criminal" },
                    { new Guid("46e914e2-5c60-44a3-97a5-f2df13aaed89"), "Michael Jackson", "🥁👊", "Beat It" },
                    { new Guid("4b41c417-1922-4763-98ec-b2f9e1b3b00c"), "Michael Jackson", "🕺🌟", "Billie Jean" },
                    { new Guid("4efc7e89-74e1-4ae1-b22a-fdbb027c1ab0"), "Michael Jackson", "🕴🔫", "Smooth Criminal" },
                    { new Guid("4f06580e-eef5-41ac-b316-3ef54f3e203b"), "Phil Collins", "🏝️🙏", "Another Day in Paradise" },
                    { new Guid("4f08b1bc-8aef-42e5-9175-0626ab69f162"), "Joan Jett & the Blackhearts", "🎸🖤", "I Love Rock 'n' Roll" },
                    { new Guid("5127b23e-5702-40ee-918a-fd85ee7a7d78"), "Sinéad O'Connor", "🔍💔", "Nothing Compares 2 U" },
                    { new Guid("51e0cfd4-f93e-46a4-8576-bf1a3e64db25"), "Berlin", "🌬️💔", "Take My Breath Away" },
                    { new Guid("54553a19-7599-4655-bf43-141b3e40574d"), "AC/DC", "🛣️😈", "Highway to Hell" },
                    { new Guid("54c24bd3-3eae-40a2-b6cb-8404171b8e55"), "Whitney Houston", "💃👩‍❤️‍👨", "I Wanna Dance with Somebody" },
                    { new Guid("57d7f041-991e-4a85-8b38-b2de4b6e4720"), "Guns N' Roses", "🍬👶🎸", "Sweet Child o' Mine" },
                    { new Guid("5cb1d6d7-3b02-4d72-a9e0-67abcc16d191"), "Queen", "🍑👩", "Fat Bottomed Girls" },
                    { new Guid("5cfb42cb-83a5-4cf0-80eb-0559a77b6c5a"), "The Bangles", "🔥💖", "Eternal Flame" },
                    { new Guid("5f7f79fd-87f5-4c3e-8f5b-7c8995122034"), "The Police", "👀👣", "Every Breath You Take" },
                    { new Guid("64ed785a-b6da-43d4-981e-2290fbb6a72d"), "Kenny Loggins", "👞💃", "Footloose" },
                    { new Guid("6e01b8a2-c228-42aa-8da5-8281db2dc589"), "Bon Jovi", "🙏🎸", "Livin' on a Prayer" },
                    { new Guid("6f000b7e-d79a-4c48-926b-44f361fb4d8f"), "Michael Jackson", "⚫⚪", "Black or White" },
                    { new Guid("71e745f5-35b0-4fe4-a0cc-97a0d73654cc"), "Queen & David Bowie", "🎶🔨❄️", "Under Pressure" },
                    { new Guid("73da92b1-1c0e-4a4b-8910-0529c9c5f833"), "Michael Jackson", "🚫👎", "Bad" },
                    { new Guid("74487c32-e158-4eb7-9ad8-77c88b2fd308"), "Neil Diamond", "🍭💎", "Sweet Caroline" },
                    { new Guid("77d7d19e-d6cc-4aeb-882f-0b35e2db05ab"), "Michael Jackson", "⚫⚪", "Black or White" },
                    { new Guid("7e7937c6-8747-4a0f-81b4-3c464f6e88e2"), "Queen", "👑🎶", "Bohemian Rhapsody" },
                    { new Guid("7ed19a5b-8c2c-4048-b2f5-c1a0e6d98c3c"), "Michael Jackson", "🧟🌃", "Thriller" },
                    { new Guid("87b52bfb-f077-44fb-8257-70b195f62be8"), "Guns N' Roses", "🍂🌧️", "November Rain" },
                    { new Guid("88b5c58a-37b7-4cf8-b92e-9d11cdd1d1a3"), "Cyndi Lauper", "⏰🔄", "Time After Time" },
                    { new Guid("8a63da2e-6fa6-42ec-bc58-40937976c123"), "Queen", "🛑🚀", "Don't Stop Me Now" },
                    { new Guid("8b73c99d-d425-44e2-a27e-99592b451947"), "Prince", "💜🌧️", "Purple Rain" },
                    { new Guid("8c1e9e28-ae50-4437-ba25-d1b6e542e306"), "Dexys Midnight Runners", "🤵👱‍♀️", "Come On Eileen" },
                    { new Guid("8c5cf2e8-4c9c-453b-9dfb-b2e75a5f59ad"), "Queen", "📻👑", "Radio Ga Ga" },
                    { new Guid("8e0c4ad5-1c39-4181-b2a5-d7cc80d17349"), "Michael Jackson", "🧟🌃", "Thriller" },
                    { new Guid("8e488507-57e1-4709-b31f-d05c2d1795df"), "Cyndi Lauper", "👩‍👧‍👧🎉", "Girls Just Want to Have Fun" },
                    { new Guid("8e7d0802-7861-4f3f-ba7c-8449e2f4bf29"), "Lionel Richie", "👋🎵", "Hello" },
                    { new Guid("92d20026-b92f-4317-b3b2-0e6153288b7c"), "Queen", "🎵❤️", "Somebody to Love" },
                    { new Guid("98fd4f42-b4a1-4644-9344-25a343f3c89b"), "Pink Floyd", "🧱🧱🧱", "Another Brick in the Wall" },
                    { new Guid("9950b88c-ea1a-4b68-ae6d-156e86ab3842"), "Michael Sembello", "🏃‍♂️💃", "Maniac" },
                    { new Guid("9b23d302-88b5-4749-aa7d-c54ee9bc79b9"), "Michael Jackson", "🌍👨‍👩‍👦‍👦", "Heal the World" },
                    { new Guid("9d07a75b-3dd0-4a86-8142-761f5621ef3c"), "a-ha", "👨‍🎨📺", "Take On Me" },
                    { new Guid("9f628037-1c4f-4b0b-a7a3-2a8eae6cf26e"), "The Beatles", "🤝👐", "I Want to Hold Your Hand" },
                    { new Guid("9f944c34-dde5-41d0-9f14-1fcd9ed52d9a"), "Michael Jackson", "🥁👊", "Beat It" },
                    { new Guid("a36db7b0-20de-4e9d-a482-df7ba1395f3c"), "Michael Jackson", "👨🔍🪞", "Man in the Mirror" },
                    { new Guid("a5b0fd3d-868e-4e19-88a5-d94448d6236c"), "George Michael", "💔🎷", "Careless Whisper" },
                    { new Guid("a7d02de7-7c28-4cd1-a1d2-0a53c3c60d89"), "AC/DC", "🛣️😈", "Highway to Hell" },
                    { new Guid("b01608b3-7782-4924-97fc-d4f2f38aafab"), "Michael Jackson", "👀💕", "The Way You Make Me Feel" },
                    { new Guid("b27b9c41-d7f8-4af6-b6f3-dc59ba25ee1a"), "Whitney Houston", "💔🎶", "I Will Always Love You" },
                    { new Guid("b2b92b2a-6825-4a90-8f0f-5d0a5e3f171b"), "Sade", "👨‍💼🎷", "Smooth Operator" },
                    { new Guid("b31db1c8-3c39-42e9-a2d3-57f3c7e4ebe5"), "Celine Dion", "💔🚢", "My Heart Will Go On" },
                    { new Guid("b78d13d7-78f2-4e0b-b95b-69ff9df44419"), "Queen", "👑👸", "Killer Queen" },
                    { new Guid("b8dd307f-4f15-4996-9e8a-f03d2d59bc96"), "Queen", "🆓🎶", "I Want to Break Free" },
                    { new Guid("b8f8b5e0-2481-4a38-8715-c9b98c63c760"), "Michael Sembello", "🏃‍♂️💃", "Maniac" },
                    { new Guid("b9a491e2-11e9-4b3c-bb8e-0c88be87d0de"), "Queen", "🍑👩", "Fat Bottomed Girls" },
                    { new Guid("bb37ec6a-3f78-4d92-83f0-1a02ba253512"), "Joan Jett & the Blackhearts", "🎸🖤", "I Love Rock 'n' Roll" },
                    { new Guid("bd091c18-175b-4af7-926e-468c3766cf64"), "Lionel Richie", "👋🎵", "Hello" },
                    { new Guid("c09e84d8-7da4-4c36-bf90-84008e019de1"), "USA for Africa", "🌎👫🎵", "We Are the World" },
                    { new Guid("c1e3f73d-2b26-48b1-a3d7-9f1b415cd8d5"), "Queen", "🎵❤️", "Somebody to Love" },
                    { new Guid("c52b9626-f2e4-4051-b7f0-d88c8c5b2e39"), "U2", "❤️🤝", "With or Without You" },
                    { new Guid("c6ccfd21-f085-4641-b570-22d261e48926"), "Queen", "💀🎶", "Another One Bites the Dust" },
                    { new Guid("c8f281fa-fd8a-458d-b60d-d7e44b196df5"), "Celine Dion", "💔🚢", "My Heart Will Go On" },
                    { new Guid("c9b5b5b3-cf48-4096-8c3f-3d49e8372089"), "Toto", "🌍🦓", "Africa" },
                    { new Guid("cef03b8b-7f24-4a95-bf4f-d78d9c4c5180"), "Poison", "🌹🎸💔", "Every Rose Has Its Thorn" },
                    { new Guid("d6c7f7e2-f4c8-4e70-bd9e-47ac218f0132"), "Queen", "🏆👑", "We Are the Champions" },
                    { new Guid("d7a6712c-3c70-49df-8a10-3f0917c3f5fd"), "Michael Jackson", "👀💕", "The Way You Make Me Feel" },
                    { new Guid("d8e1a7dc-8722-4374-9941-622c344b0f60"), "Queen", "👑🎶", "Bohemian Rhapsody" },
                    { new Guid("e21c33e8-e127-4c28-8f76-11c129fb6769"), "George Michael", "💔🎷", "Careless Whisper" },
                    { new Guid("e8a3a187-11d3-42d2-b2e7-cf743da2f1dc"), "Ricky Martin", "🎉🌎", "Livin' La Vida Loca" },
                    { new Guid("f01f20db-c66e-464f-a54d-8f7242f92b05"), "Guns N' Roses", "🍂🌧️", "November Rain" },
                    { new Guid("f5eddd4b-31b7-40da-8625-6bc1c05d478b"), "Survivor", "👁️🐅", "Eye of the Tiger" },
                    { new Guid("f6d80f06-ec46-49f8-9275-d59c8a68ac30"), "Queen & David Bowie", "🎶🔨❄️", "Under Pressure" },
                    { new Guid("fa87c373-e0b5-46c6-a277-c35734fb5394"), "Queen", "🛑🚀", "Don't Stop Me Now" },
                    { new Guid("ff6793b4-41a0-4629-a152-1a37d3bc1ad7"), "Michael Jackson", "🌍👨‍👩‍👦‍👦", "Heal the World" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("0507276e-39b0-4d33-97fd-cb14d8bdaa2f"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("05931f03-ec5e-4b68-8e1c-fc2bbfe27f47"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("080ef095-34b1-405b-a537-789fb9d067a9"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("0e4bc0a4-3e7a-4a7b-b98d-02402139e4ad"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("0f22a7f2-5a12-4b1d-9365-4d63581a63e9"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("0f3f1275-cf79-4a65-aaf7-7e4d991cc4e0"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("12058a5a-89f5-45f4-94fb-d5bb16b44a82"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("120b547d-9d4f-44f2-8127-e298c05e4f56"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("15b4c9fb-83cd-4a06-9b5a-1cc9e66a5a89"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("196839e8-0733-4813-b3e4-9edfb9917d3f"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("199b3034-5b8b-4648-b7f4-89fc2fa537f0"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("19f003d5-3fe6-4a80-8a60-90b5cd1d8e1a"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("1da53585-99c4-48e3-b9cc-9f44748178e1"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("1e98208e-85c7-4b3e-8567-e1ff5e2f5d67"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("1f398abc-72e5-4b47-895f-4aef46e53dc3"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("1f9ebd8b-65a7-4b40-b663-4fdcf6fd5df7"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("22a24321-7e5e-48d6-80bb-b8888bcbce2e"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("272bd92b-7f2d-49eb-9a94-7a9c3ff870c4"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("29220b79-1209-4fc9-9e89-c2565df2c390"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("2bdf4c4f-196b-462e-b857-c3bc85d55e6f"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("2c6d6935-0f4f-4c4b-b22e-4436aa06dbb0"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("2cb56062-8994-4c38-9717-24b8c96c855e"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("2d537b70-306d-4678-81f3-1d8a28c25438"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("2d6d2865-0ec2-47d4-abe1-cc8bf2444652"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("30e8be19-cabb-4fc2-ae33-f74a84eeb441"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("36924e37-aa68-4918-927b-48b57b8b5d7d"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("3ff00557-4e4e-4b11-82a1-92fbd6d188e3"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("43f2ef8c-24b6-43f0-a94c-55c8d828079a"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("46e914e2-5c60-44a3-97a5-f2df13aaed89"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("4b41c417-1922-4763-98ec-b2f9e1b3b00c"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("4efc7e89-74e1-4ae1-b22a-fdbb027c1ab0"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("4f06580e-eef5-41ac-b316-3ef54f3e203b"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("4f08b1bc-8aef-42e5-9175-0626ab69f162"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("5127b23e-5702-40ee-918a-fd85ee7a7d78"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("51e0cfd4-f93e-46a4-8576-bf1a3e64db25"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("54553a19-7599-4655-bf43-141b3e40574d"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("54c24bd3-3eae-40a2-b6cb-8404171b8e55"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("57d7f041-991e-4a85-8b38-b2de4b6e4720"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("5cb1d6d7-3b02-4d72-a9e0-67abcc16d191"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("5cfb42cb-83a5-4cf0-80eb-0559a77b6c5a"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("5f7f79fd-87f5-4c3e-8f5b-7c8995122034"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("64ed785a-b6da-43d4-981e-2290fbb6a72d"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("6e01b8a2-c228-42aa-8da5-8281db2dc589"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("6f000b7e-d79a-4c48-926b-44f361fb4d8f"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("71e745f5-35b0-4fe4-a0cc-97a0d73654cc"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("73da92b1-1c0e-4a4b-8910-0529c9c5f833"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("74487c32-e158-4eb7-9ad8-77c88b2fd308"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("77d7d19e-d6cc-4aeb-882f-0b35e2db05ab"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("7e7937c6-8747-4a0f-81b4-3c464f6e88e2"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("7ed19a5b-8c2c-4048-b2f5-c1a0e6d98c3c"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("87b52bfb-f077-44fb-8257-70b195f62be8"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("88b5c58a-37b7-4cf8-b92e-9d11cdd1d1a3"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("8a63da2e-6fa6-42ec-bc58-40937976c123"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("8b73c99d-d425-44e2-a27e-99592b451947"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("8c1e9e28-ae50-4437-ba25-d1b6e542e306"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("8c5cf2e8-4c9c-453b-9dfb-b2e75a5f59ad"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("8e0c4ad5-1c39-4181-b2a5-d7cc80d17349"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("8e488507-57e1-4709-b31f-d05c2d1795df"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("8e7d0802-7861-4f3f-ba7c-8449e2f4bf29"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("92d20026-b92f-4317-b3b2-0e6153288b7c"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("98fd4f42-b4a1-4644-9344-25a343f3c89b"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("9950b88c-ea1a-4b68-ae6d-156e86ab3842"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("9b23d302-88b5-4749-aa7d-c54ee9bc79b9"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("9d07a75b-3dd0-4a86-8142-761f5621ef3c"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("9f628037-1c4f-4b0b-a7a3-2a8eae6cf26e"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("9f944c34-dde5-41d0-9f14-1fcd9ed52d9a"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("a36db7b0-20de-4e9d-a482-df7ba1395f3c"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("a5b0fd3d-868e-4e19-88a5-d94448d6236c"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("a7d02de7-7c28-4cd1-a1d2-0a53c3c60d89"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("b01608b3-7782-4924-97fc-d4f2f38aafab"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("b27b9c41-d7f8-4af6-b6f3-dc59ba25ee1a"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("b2b92b2a-6825-4a90-8f0f-5d0a5e3f171b"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("b31db1c8-3c39-42e9-a2d3-57f3c7e4ebe5"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("b78d13d7-78f2-4e0b-b95b-69ff9df44419"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("b8dd307f-4f15-4996-9e8a-f03d2d59bc96"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("b8f8b5e0-2481-4a38-8715-c9b98c63c760"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("b9a491e2-11e9-4b3c-bb8e-0c88be87d0de"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("bb37ec6a-3f78-4d92-83f0-1a02ba253512"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("bd091c18-175b-4af7-926e-468c3766cf64"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("c09e84d8-7da4-4c36-bf90-84008e019de1"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("c1e3f73d-2b26-48b1-a3d7-9f1b415cd8d5"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("c52b9626-f2e4-4051-b7f0-d88c8c5b2e39"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("c6ccfd21-f085-4641-b570-22d261e48926"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("c8f281fa-fd8a-458d-b60d-d7e44b196df5"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("c9b5b5b3-cf48-4096-8c3f-3d49e8372089"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("cef03b8b-7f24-4a95-bf4f-d78d9c4c5180"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("d6c7f7e2-f4c8-4e70-bd9e-47ac218f0132"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("d7a6712c-3c70-49df-8a10-3f0917c3f5fd"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("d8e1a7dc-8722-4374-9941-622c344b0f60"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("e21c33e8-e127-4c28-8f76-11c129fb6769"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("e8a3a187-11d3-42d2-b2e7-cf743da2f1dc"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("f01f20db-c66e-464f-a54d-8f7242f92b05"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("f5eddd4b-31b7-40da-8625-6bc1c05d478b"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("f6d80f06-ec46-49f8-9275-d59c8a68ac30"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("fa87c373-e0b5-46c6-a277-c35734fb5394"));

            migrationBuilder.DeleteData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("ff6793b4-41a0-4629-a152-1a37d3bc1ad7"));

            migrationBuilder.UpdateData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("444521eb-fc20-4cf5-b935-fd6008b928bf"),
                column: "Emoji",
                value: "Emoji");

            migrationBuilder.UpdateData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("59fdc46f-8528-44c3-8095-ebbc6e5785ea"),
                column: "Emoji",
                value: "Emoji");

            migrationBuilder.UpdateData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("850111d5-6409-4196-a362-c53f007ed4dd"),
                columns: new[] { "Artist", "Emoji", "SongName" },
                values: new object[] { "Rihanna", "Emoji", "Where Have You Been" });

            migrationBuilder.UpdateData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("9268891c-3aa8-4aff-ac5a-4454fa6aa672"),
                columns: new[] { "Artist", "Emoji", "SongName" },
                values: new object[] { "Lady Gaga", "Emoji", "Bad Romace" });

            migrationBuilder.UpdateData(
                schema: "Music",
                table: "Music",
                keyColumn: "Id",
                keyValue: new Guid("f25c986b-fc36-439e-bc29-9616ff2d7e95"),
                columns: new[] { "Artist", "Emoji", "SongName" },
                values: new object[] { "Rihanna", "Emoji", "Don’t Stop the Music" });

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
                    { new Guid("d469ca99-8520-4f03-ad64-324dda4b0d78"), "The Weeknd", "Emoji", "Blinding Lights" }
                });
        }
    }
}
