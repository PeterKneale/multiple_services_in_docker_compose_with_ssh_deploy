using App1;
using MartinCostello.Logging.XUnit;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Logging;
using Xunit.Abstractions;

namespace App2.IntegrationTests;

public class ServiceFixture : WebApplicationFactory<AssemblyInfo>, ITestOutputHelperAccessor
{
    public ITestOutputHelper? OutputHelper { get; set; }

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureLogging(p => p.AddXUnit(this));
    }
}