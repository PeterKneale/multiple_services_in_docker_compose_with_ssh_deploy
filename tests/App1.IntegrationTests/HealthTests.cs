namespace App1.IntegrationTests;

public class HealthTests(ServiceFixture service, ITestOutputHelper output) : BaseTest(service, output)
{
    [Fact]
    public async Task Service_should_be_alive() =>
        (await Client.GetAsync("/health/alive")).EnsureSuccessStatusCode();

    [Fact]
    public async Task Service_should_be_ready() =>
        (await Client.GetAsync("/health/ready")).EnsureSuccessStatusCode();
}