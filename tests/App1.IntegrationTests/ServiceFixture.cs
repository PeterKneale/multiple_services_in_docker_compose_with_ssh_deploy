namespace App1.IntegrationTests;

public class ServiceFixture : WebApplicationFactory<AssemblyInfo>, ITestOutputHelperAccessor
{
    public ITestOutputHelper? OutputHelper { get; set; }

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureLogging(p => p.AddXUnit(this));
    }
}