global using MartinCostello.Logging.XUnit;
global using Microsoft.AspNetCore.Hosting;
global using Microsoft.AspNetCore.Mvc.Testing;
global using Microsoft.Extensions.Logging;
global using Xunit;
global using Xunit.Abstractions;
using System.Diagnostics.CodeAnalysis;

[assembly: ExcludeFromCodeCoverage]
[assembly: AssemblyTrait("Type", "Integration")]