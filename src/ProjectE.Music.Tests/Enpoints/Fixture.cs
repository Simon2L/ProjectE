using FastEndpoints.Testing;
using Xunit.Abstractions;

namespace ProjectE.Music.Tests.Enpoints;

public class Fixture(IMessageSink messageSink) : AppFixture<Program>(messageSink)
{
    protected override Task SetupAsync()
    {
        Client = CreateClient();

        return Task.CompletedTask;
    }

    protected override Task TearDownAsync()
    {
        Client.Dispose();

        return base.TearDownAsync();
    }
}
