using FastEndpoints;
using FastEndpoints.Testing;
using FluentAssertions;
using ProjectE.Music.MusicEnpoints;

namespace ProjectE.Music.Tests.Enpoints;

public class MusicList(Fixture fixture) :
    TestBase<Fixture>()
{
    [Fact]
    public async Task ReturnsAMusicListAsync()
    {
        var testResult = await fixture.Client.GETAsync<List, ListMusicResponse>();

        testResult.Response.EnsureSuccessStatusCode();
        testResult.Result.Music.Should().NotBeNullOrEmpty().And.BeOfType<List<MusicDto>>();
    }
}

