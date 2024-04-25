using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectE.Music.Data;

internal class MusicConfiguration : IEntityTypeConfiguration<Music>
{

    public void Configure(EntityTypeBuilder<Music> builder) 
    { 
        builder.Property(p => p.Artist)
            .HasMaxLength(DataSchemaConstants.DEFAULT_NAME_LENGTH)
            .IsRequired();

        builder.Property(p => p.Emoji)
            .HasMaxLength(DataSchemaConstants.DEFAULT_GENRE_LENGTH)
            .IsRequired();

        builder.Property(p => p.SongName)
            .HasMaxLength(DataSchemaConstants.DEFAULT_NAME_LENGTH)
            .IsRequired();

        builder.HasData(GetSampleMusicData());
    }

    private IEnumerable<Music> GetSampleMusicData()
    {

        #region DATA
        yield return new Music(new Guid("9268891c-3aa8-4aff-ac5a-4454fa6aa672"), "Electric Dreams", "Human League", "⚡️💭");
        yield return new Music(new Guid("f25c986b-fc36-439e-bc29-9616ff2d7e95"), "Bohemian Rhapsody", "Queen", "👑🎶");
        yield return new Music(new Guid("850111d5-6409-4196-a362-c53f007ed4dd"), "Shape of My Heart", "Sting", "💔♠️");
        yield return new Music(new Guid("59fdc46f-8528-44c3-8095-ebbc6e5785ea"), "Levels", "Avicii", "📶");
        yield return new Music(new Guid("444521eb-fc20-4cf5-b935-fd6008b928bf"), "Addicted To You", "Avicii", "💉");
        yield return new Music(new Guid("8e488507-57e1-4709-b31f-d05c2d1795df"), "Girls Just Want to Have Fun", "Cyndi Lauper", "👩‍👧‍👧🎉");
        yield return new Music(new Guid("9d07a75b-3dd0-4a86-8142-761f5621ef3c"), "Take On Me", "a-ha", "👨‍🎨📺");
        yield return new Music(new Guid("54c24bd3-3eae-40a2-b6cb-8404171b8e55"), "I Wanna Dance with Somebody", "Whitney Houston", "💃👩‍❤️‍👨");
        yield return new Music(new Guid("f5eddd4b-31b7-40da-8625-6bc1c05d478b"), "Eye of the Tiger", "Survivor", "👁️🐅");
        yield return new Music(new Guid("36924e37-aa68-4918-927b-48b57b8b5d7d"), "Don't Stop Believin'", "Journey", "🛣️🎤");
        yield return new Music(new Guid("c9b5b5b3-cf48-4096-8c3f-3d49e8372089"), "Africa", "Toto", "🌍🦓");
        yield return new Music(new Guid("74487c32-e158-4eb7-9ad8-77c88b2fd308"), "Sweet Caroline", "Neil Diamond", "🍭💎");
        yield return new Music(new Guid("8c1e9e28-ae50-4437-ba25-d1b6e542e306"), "Come On Eileen", "Dexys Midnight Runners", "🤵👱‍♀️");
        yield return new Music(new Guid("e8a3a187-11d3-42d2-b2e7-cf743da2f1dc"), "Livin' La Vida Loca", "Ricky Martin", "🎉🌎");
        yield return new Music(new Guid("64ed785a-b6da-43d4-981e-2290fbb6a72d"), "Footloose", "Kenny Loggins", "👞💃");
        yield return new Music(new Guid("0e4bc0a4-3e7a-4a7b-b98d-02402139e4ad"), "Careless Whisper", "George Michael", "💔🎷");
        yield return new Music(new Guid("2bdf4c4f-196b-462e-b857-c3bc85d55e6f"), "Total Eclipse of the Heart", "Bonnie Tyler", "🌑💔");
        yield return new Music(new Guid("46e914e2-5c60-44a3-97a5-f2df13aaed89"), "Beat It", "Michael Jackson", "🥁👊");
        yield return new Music(new Guid("a36db7b0-20de-4e9d-a482-df7ba1395f3c"), "Man in the Mirror", "Michael Jackson", "👨🔍🪞");
        yield return new Music(new Guid("98fd4f42-b4a1-4644-9344-25a343f3c89b"), "Another Brick in the Wall", "Pink Floyd", "🧱🧱🧱");
        yield return new Music(new Guid("3ff00557-4e4e-4b11-82a1-92fbd6d188e3"), "You're the One That I Want", "John Travolta & Olivia Newton-John", "👫💖");
        yield return new Music(new Guid("2d6d2865-0ec2-47d4-abe1-cc8bf2444652"), "Every Rose Has Its Thorn", "Poison", "🌹🎸💔");
        yield return new Music(new Guid("bb37ec6a-3f78-4d92-83f0-1a02ba253512"), "I Love Rock 'n' Roll", "Joan Jett & the Blackhearts", "🎸🖤");
        yield return new Music(new Guid("54553a19-7599-4655-bf43-141b3e40574d"), "Highway to Hell", "AC/DC", "🛣️😈");
        yield return new Music(new Guid("2d537b70-306d-4678-81f3-1d8a28c25438"), "We Are the Champions", "Queen", "🏆👑");
        yield return new Music(new Guid("30e8be19-cabb-4fc2-ae33-f74a84eeb441"), "We Will Rock You", "Queen", "👑🎸");
        yield return new Music(new Guid("272bd92b-7f2d-49eb-9a94-7a9c3ff870c4"), "Another One Bites the Dust", "Queen", "💀🎶");
        yield return new Music(new Guid("199b3034-5b8b-4648-b7f4-89fc2fa537f0"), "I Want to Break Free", "Queen", "🆓🎶");
        yield return new Music(new Guid("f6d80f06-ec46-49f8-9275-d59c8a68ac30"), "Under Pressure", "Queen & David Bowie", "🎶🔨❄️");
        yield return new Music(new Guid("c1e3f73d-2b26-48b1-a3d7-9f1b415cd8d5"), "Somebody to Love", "Queen", "🎵❤️");
        yield return new Music(new Guid("8c5cf2e8-4c9c-453b-9dfb-b2e75a5f59ad"), "Radio Ga Ga", "Queen", "📻👑");
        yield return new Music(new Guid("7e7937c6-8747-4a0f-81b4-3c464f6e88e2"), "Bohemian Rhapsody", "Queen", "👑🎶");
        yield return new Music(new Guid("05931f03-ec5e-4b68-8e1c-fc2bbfe27f47"), "Killer Queen", "Queen", "👑👸");
        yield return new Music(new Guid("0f22a7f2-5a12-4b1d-9365-4d63581a63e9"), "Love of My Life", "Queen", "💖🎶");
        yield return new Music(new Guid("fa87c373-e0b5-46c6-a277-c35734fb5394"), "Don't Stop Me Now", "Queen", "🛑🚀");
        yield return new Music(new Guid("b9a491e2-11e9-4b3c-bb8e-0c88be87d0de"), "Fat Bottomed Girls", "Queen", "🍑👩");
        yield return new Music(new Guid("c09e84d8-7da4-4c36-bf90-84008e019de1"), "We Are the World", "USA for Africa", "🌎👫🎵");
        yield return new Music(new Guid("9b23d302-88b5-4749-aa7d-c54ee9bc79b9"), "Heal the World", "Michael Jackson", "🌍👨‍👩‍👦‍👦");
        yield return new Music(new Guid("b8f8b5e0-2481-4a38-8715-c9b98c63c760"), "Maniac", "Michael Sembello", "🏃‍♂️💃");
        yield return new Music(new Guid("7ed19a5b-8c2c-4048-b2f5-c1a0e6d98c3c"), "Thriller", "Michael Jackson", "🧟🌃");
        yield return new Music(new Guid("4efc7e89-74e1-4ae1-b22a-fdbb027c1ab0"), "Smooth Criminal", "Michael Jackson", "🕴🔫");
        yield return new Music(new Guid("1e98208e-85c7-4b3e-8567-e1ff5e2f5d67"), "Billie Jean", "Michael Jackson", "🕺🌟");
        yield return new Music(new Guid("9f944c34-dde5-41d0-9f14-1fcd9ed52d9a"), "Beat It", "Michael Jackson", "🥁👊");
        yield return new Music(new Guid("b01608b3-7782-4924-97fc-d4f2f38aafab"), "The Way You Make Me Feel", "Michael Jackson", "👀💕");
        yield return new Music(new Guid("6f000b7e-d79a-4c48-926b-44f361fb4d8f"), "Black or White", "Michael Jackson", "⚫⚪");
        yield return new Music(new Guid("2c6d6935-0f4f-4c4b-b22e-4436aa06dbb0"), "Bad", "Michael Jackson", "🚫👎");
        yield return new Music(new Guid("120b547d-9d4f-44f2-8127-e298c05e4f56"), "Take My Breath Away", "Berlin", "🌬️💔");
        yield return new Music(new Guid("e21c33e8-e127-4c28-8f76-11c129fb6769"), "Careless Whisper", "George Michael", "💔🎷");
        yield return new Music(new Guid("19f003d5-3fe6-4a80-8a60-90b5cd1d8e1a"), "Every Breath You Take", "The Police", "👀👣");
        yield return new Music(new Guid("88b5c58a-37b7-4cf8-b92e-9d11cdd1d1a3"), "Time After Time", "Cyndi Lauper", "⏰🔄");
        yield return new Music(new Guid("c8f281fa-fd8a-458d-b60d-d7e44b196df5"), "My Heart Will Go On", "Celine Dion", "💔🚢");
        yield return new Music(new Guid("29220b79-1209-4fc9-9e89-c2565df2c390"), "Yesterday", "The Beatles", "📅🎵");
        yield return new Music(new Guid("bd091c18-175b-4af7-926e-468c3766cf64"), "Hello", "Lionel Richie", "👋🎵");
        yield return new Music(new Guid("b27b9c41-d7f8-4af6-b6f3-dc59ba25ee1a"), "I Will Always Love You", "Whitney Houston", "💔🎶");
        yield return new Music(new Guid("f01f20db-c66e-464f-a54d-8f7242f92b05"), "November Rain", "Guns N' Roses", "🍂🌧️");
        yield return new Music(new Guid("cef03b8b-7f24-4a95-bf4f-d78d9c4c5180"), "Every Rose Has Its Thorn", "Poison", "🌹🎸💔");
        yield return new Music(new Guid("4f08b1bc-8aef-42e5-9175-0626ab69f162"), "I Love Rock 'n' Roll", "Joan Jett & the Blackhearts", "🎸🖤");
        yield return new Music(new Guid("6e01b8a2-c228-42aa-8da5-8281db2dc589"), "Livin' on a Prayer", "Bon Jovi", "🙏🎸");
        yield return new Music(new Guid("12058a5a-89f5-45f4-94fb-d5bb16b44a82"), "Sweet Child o' Mine", "Guns N' Roses", "🍬👶🎸");
        yield return new Music(new Guid("a7d02de7-7c28-4cd1-a1d2-0a53c3c60d89"), "Highway to Hell", "AC/DC", "🛣️😈");
        yield return new Music(new Guid("d6c7f7e2-f4c8-4e70-bd9e-47ac218f0132"), "We Are the Champions", "Queen", "🏆👑");
        yield return new Music(new Guid("22a24321-7e5e-48d6-80bb-b8888bcbce2e"), "We Will Rock You", "Queen", "👑🎸");
        yield return new Music(new Guid("c6ccfd21-f085-4641-b570-22d261e48926"), "Another One Bites the Dust", "Queen", "💀🎶");
        yield return new Music(new Guid("b8dd307f-4f15-4996-9e8a-f03d2d59bc96"), "I Want to Break Free", "Queen", "🆓🎶");
        yield return new Music(new Guid("71e745f5-35b0-4fe4-a0cc-97a0d73654cc"), "Under Pressure", "Queen & David Bowie", "🎶🔨❄️");
        yield return new Music(new Guid("92d20026-b92f-4317-b3b2-0e6153288b7c"), "Somebody to Love", "Queen", "🎵❤️");
        yield return new Music(new Guid("15b4c9fb-83cd-4a06-9b5a-1cc9e66a5a89"), "Radio Ga Ga", "Queen", "📻👑");
        yield return new Music(new Guid("d8e1a7dc-8722-4374-9941-622c344b0f60"), "Bohemian Rhapsody", "Queen", "👑🎶");
        yield return new Music(new Guid("b78d13d7-78f2-4e0b-b95b-69ff9df44419"), "Killer Queen", "Queen", "👑👸");
        yield return new Music(new Guid("0f3f1275-cf79-4a65-aaf7-7e4d991cc4e0"), "Love of My Life", "Queen", "💖🎶");
        yield return new Music(new Guid("8a63da2e-6fa6-42ec-bc58-40937976c123"), "Don't Stop Me Now", "Queen", "🛑🚀");
        yield return new Music(new Guid("5cb1d6d7-3b02-4d72-a9e0-67abcc16d191"), "Fat Bottomed Girls", "Queen", "🍑👩");
        yield return new Music(new Guid("196839e8-0733-4813-b3e4-9edfb9917d3f"), "We Are the World", "USA for Africa", "🌎👫🎵");
        yield return new Music(new Guid("ff6793b4-41a0-4629-a152-1a37d3bc1ad7"), "Heal the World", "Michael Jackson", "🌍👨‍👩‍👦‍👦");
        yield return new Music(new Guid("9950b88c-ea1a-4b68-ae6d-156e86ab3842"), "Maniac", "Michael Sembello", "🏃‍♂️💃");
        yield return new Music(new Guid("8e0c4ad5-1c39-4181-b2a5-d7cc80d17349"), "Thriller", "Michael Jackson", "🧟🌃");
        yield return new Music(new Guid("43f2ef8c-24b6-43f0-a94c-55c8d828079a"), "Smooth Criminal", "Michael Jackson", "🕴🔫");
        yield return new Music(new Guid("4b41c417-1922-4763-98ec-b2f9e1b3b00c"), "Billie Jean", "Michael Jackson", "🕺🌟");
        yield return new Music(new Guid("1f398abc-72e5-4b47-895f-4aef46e53dc3"), "Beat It", "Michael Jackson", "🥁👊");
        yield return new Music(new Guid("d7a6712c-3c70-49df-8a10-3f0917c3f5fd"), "The Way You Make Me Feel", "Michael Jackson", "👀💕");
        yield return new Music(new Guid("77d7d19e-d6cc-4aeb-882f-0b35e2db05ab"), "Black or White", "Michael Jackson", "⚫⚪");
        yield return new Music(new Guid("73da92b1-1c0e-4a4b-8910-0529c9c5f833"), "Bad", "Michael Jackson", "🚫👎");
        yield return new Music(new Guid("51e0cfd4-f93e-46a4-8576-bf1a3e64db25"), "Take My Breath Away", "Berlin", "🌬️💔");
        yield return new Music(new Guid("a5b0fd3d-868e-4e19-88a5-d94448d6236c"), "Careless Whisper", "George Michael", "💔🎷");
        yield return new Music(new Guid("5f7f79fd-87f5-4c3e-8f5b-7c8995122034"), "Every Breath You Take", "The Police", "👀👣");
        yield return new Music(new Guid("0507276e-39b0-4d33-97fd-cb14d8bdaa2f"), "Time After Time", "Cyndi Lauper", "⏰🔄");
        yield return new Music(new Guid("b31db1c8-3c39-42e9-a2d3-57f3c7e4ebe5"), "My Heart Will Go On", "Celine Dion", "💔🚢");
        yield return new Music(new Guid("1da53585-99c4-48e3-b9cc-9f44748178e1"), "Yesterday", "The Beatles", "📅🎵");
        yield return new Music(new Guid("8e7d0802-7861-4f3f-ba7c-8449e2f4bf29"), "Hello", "Lionel Richie", "👋🎵");
        yield return new Music(new Guid("1f9ebd8b-65a7-4b40-b663-4fdcf6fd5df7"), "I Will Always Love You", "Whitney Houston", "💔🎶");
        yield return new Music(new Guid("87b52bfb-f077-44fb-8257-70b195f62be8"), "November Rain", "Guns N' Roses", "🍂🌧️");
        yield return new Music(new Guid("b2b92b2a-6825-4a90-8f0f-5d0a5e3f171b"), "Smooth Operator", "Sade", "👨‍💼🎷");
        yield return new Music(new Guid("c52b9626-f2e4-4051-b7f0-d88c8c5b2e39"), "With or Without You", "U2", "❤️🤝");
        yield return new Music(new Guid("57d7f041-991e-4a85-8b38-b2de4b6e4720"), "Sweet Child o' Mine", "Guns N' Roses", "🍬👶🎸");
        yield return new Music(new Guid("5127b23e-5702-40ee-918a-fd85ee7a7d78"), "Nothing Compares 2 U", "Sinéad O'Connor", "🔍💔");
        yield return new Music(new Guid("5cfb42cb-83a5-4cf0-80eb-0559a77b6c5a"), "Eternal Flame", "The Bangles", "🔥💖");
        yield return new Music(new Guid("9f628037-1c4f-4b0b-a7a3-2a8eae6cf26e"), "I Want to Hold Your Hand", "The Beatles", "🤝👐");
        yield return new Music(new Guid("8b73c99d-d425-44e2-a27e-99592b451947"), "Purple Rain", "Prince", "💜🌧️");
        yield return new Music(new Guid("080ef095-34b1-405b-a537-789fb9d067a9"), "Every Little Thing She Does Is Magic", "The Police", "✨🔮");
        yield return new Music(new Guid("4f06580e-eef5-41ac-b316-3ef54f3e203b"), "Another Day in Paradise", "Phil Collins", "🏝️🙏");
        yield return new Music(new Guid("2cb56062-8994-4c38-9717-24b8c96c855e"), "I Want to Know What Love Is", "Foreigner", "❤️🌏");
#endregion

    }
}